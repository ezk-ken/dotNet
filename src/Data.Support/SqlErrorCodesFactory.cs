using System.Collections.Immutable;
using System.Reflection;
using Data.Support.Configuration;
using Microsoft.Extensions.Configuration;
using ConfigurationRoot = Data.Support.Configuration.ConfigurationRoot;

namespace Data.Support;

public class SqlErrorCodesFactory
{
    public const string SqlErrorCodeDefaultPath = "sql-error-codes.json";

    public static SqlErrorCodesFactory Instance { get; private set; }

    static SqlErrorCodesFactory()
    {
        Instance = new SqlErrorCodesFactory();
    }

    protected SqlErrorCodesFactory()
    {
        var errorCodes = ImmutableDictionary<string, SqlErrorCodes>.Empty;

        // Load default SQL error codes
        var assembly = Assembly.GetExecutingAssembly();
        var assemblyName = Assembly.GetExecutingAssembly().GetName().FullName;

        using (var stream = assembly.GetManifestResourceStream($"{assemblyName}.{SqlErrorCodeDefaultPath}"))
        {
            if (stream is not null)
            {
                var configuration = new ConfigurationBuilder().AddJsonStream(stream).Build();
                var configurationRoot = configuration.Get<ConfigurationRoot>();
                errorCodes = configurationRoot.ToSqlErrorCodesMap();
            }
        }

        _errorCodesMap = errorCodes;
    }

    /// <summary>
    ///
    /// </summary>
    /// <param name="databaseName"></param>
    /// <returns></returns>
    public SqlErrorCodes GetErrorCodes(string databaseName)
    {
        return _errorCodesMap.TryGetValue(databaseName, out var errorCodes) ? errorCodes : new SqlErrorCodes();
    }

    private readonly ImmutableDictionary<string, SqlErrorCodes> _errorCodesMap;
}
