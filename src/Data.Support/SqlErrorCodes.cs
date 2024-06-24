namespace Data.Support;

/// <summary>
/// 特定のデータベースのADO.NETエラーコードを保持するためのクラス。このクラスのインスタンスは通常ファクトリークラスを通じて作成されます。
///
/// <see cref="SqlErrorCodeDbExceptionTranslator"/>によって使用される。ファイル"sql-error-codes.xml"には、さまざまなデータベースのデフォルトSqlErrorCodesインスタンが含まれる。
/// </summary>
public class SqlErrorCodes
{
    /// <summary>
    /// データベース名を取得または設定する。
    /// </summary>
    public string? DatabaseProductName
    {
        get => DatabaseProductNames.FirstOrDefault((string)null!);
        set => DatabaseProductNames = new[] { value }.AsEnumerable() ?? Enumerable.Empty<string>();
    }

    /// <summary>
    /// 複数のデータベース名を取得または設定する。
    /// </summary>
    public IEnumerable<string?> DatabaseProductNames { get; set; }

    /// <summary>
    /// エラーコードを提供しないがSQL状態を提供するデータベース（PostgreSQLを含む）に対して、このプロパティを取得または設定する。
    /// </summary>
    public bool IsUseSqlStateForTranslatetion { get; set; }

    public IEnumerable<string> BadSqlGrammarCodes { get; set; }

    public IEnumerable<string> InvalidResultSetAccessCodes { get; set; }

    public IEnumerable<string> DuplicateKeyKeyCodes { get; set; }

    public IEnumerable<string> DataIntegrityViolationCodes { get; set; }

    public IEnumerable<string> PermissionDeniedCodes { get; set; }

    public IEnumerable<string> DataAccessResourceFailureCodes { get; set; }

    public IEnumerable<string> TransientDataAccessResourceFailureCodes { get; set; }

    public IEnumerable<string> CannotAcquireLockCodes { get; set; }

    public IEnumerable<string> DeadLockLoserCodes { get; set; }

    public IEnumerable<string> CannotSerializeTransactionCodes { get; set; }

    public SqlErrorCodes()
    {
        DatabaseProductNames = Enumerable.Empty<string>();
        BadSqlGrammarCodes= Enumerable.Empty<string>();
        InvalidResultSetAccessCodes= Enumerable.Empty<string>();
        DuplicateKeyKeyCodes= Enumerable.Empty<string>();
        DataIntegrityViolationCodes= Enumerable.Empty<string>();
        PermissionDeniedCodes= Enumerable.Empty<string>();
        DataAccessResourceFailureCodes= Enumerable.Empty<string>();
        TransientDataAccessResourceFailureCodes= Enumerable.Empty<string>();
        CannotAcquireLockCodes= Enumerable.Empty<string>();
        DeadLockLoserCodes= Enumerable.Empty<string>();
        CannotSerializeTransactionCodes= Enumerable.Empty<string>();
    }
}
