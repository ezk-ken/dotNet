using System.Collections;
using System.Collections.Immutable;

namespace Data.Support.Configuration;

public class ConfigurationRoot
{
    public IEnumerable<SqlErrorCodesConfiguration>? Databases { get; set; }
}

public class SqlErrorCodesConfiguration
{
    public IEnumerable<string>? DatabaseProductNames { get; set; }
    public bool UseSqlStateForTranslation { get; set; }
    public IEnumerable<string>? BadSqlGrammarCodes { get; set; }
    public IEnumerable<string>? InvalidResultSetAccessCodes { get; set; }
    public IEnumerable<string>? DuplicateKeyCodes { get; set; }
    public IEnumerable<string>? DataIntegrityViolationCodes { get; set; }
    public IEnumerable<string>? PermissionDeniedCodes { get; set; }
    public IEnumerable<string>? DataAccessResourceFailureCodes { get; set; }
    public IEnumerable<string>? TransientDataAccessResourceFailureCodes { get; set; }
    public IEnumerable<string>? CannotAcquireLockCodes { get; set; }
    public IEnumerable<string>? CannotSerializeTransactionCodes { get; set; }
    public IEnumerable<string>? DeadlockLoserCodes { get; set; }
}

public static class SqlErrorCodesConfigurationExtensions
{
    public static ImmutableDictionary<string, SqlErrorCodes> ToSqlErrorCodesMap(this ConfigurationRoot root)
    {
        var errorCodesMap = new Dictionary<string, SqlErrorCodes>();

        root.Databases?.Select(configuration => configuration.ToSqlErrorCodes())
            .Select(code => new { code.DatabaseProductName`})
            .Where(code => code.DatabaseProductName is not null).ToImmutableDictionary(code =>
                new KeyValuePair<string, SqlErrorCodes>(code.DatabaseProductName, code));
    }

    public static SqlErrorCodes ToSqlErrorCodes(
        this SqlErrorCodesConfiguration configuration)
    {
        var sqlErrorCodes = new SqlErrorCodes()
        {
            DatabaseProductNames = configuration.DatabaseProductNames ?? Enumerable.Empty<string?>(),
            IsUseSqlStateForTranslatetion = configuration.UseSqlStateForTranslation,
            BadSqlGrammarCodes = configuration.BadSqlGrammarCodes ?? Enumerable.Empty<string>(),
            InvalidResultSetAccessCodes = configuration.InvalidResultSetAccessCodes ?? Enumerable.Empty<string>(),
            DuplicateKeyKeyCodes = configuration.DuplicateKeyCodes ?? Enumerable.Empty<string>(),
            DataIntegrityViolationCodes = configuration.DataIntegrityViolationCodes ?? Enumerable.Empty<string>(),
            PermissionDeniedCodes = configuration.PermissionDeniedCodes ?? Enumerable.Empty<string>(),
            DataAccessResourceFailureCodes = configuration.DataAccessResourceFailureCodes ?? Enumerable.Empty<string>(),
            TransientDataAccessResourceFailureCodes =
                configuration.TransientDataAccessResourceFailureCodes ?? Enumerable.Empty<string>(),
            CannotAcquireLockCodes = configuration.CannotAcquireLockCodes ?? Enumerable.Empty<string>(),
            CannotSerializeTransactionCodes =
                configuration.CannotSerializeTransactionCodes ?? Enumerable.Empty<string>(),
            DeadLockLoserCodes = configuration.DeadlockLoserCodes ?? Enumerable.Empty<string>(),
        };

        return sqlErrorCodes;
    }
}
