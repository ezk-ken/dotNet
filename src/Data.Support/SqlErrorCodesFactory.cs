namespace Data.Support;

public class SqlErrorCodesFactory
{
    public const string SqlErrorCodeOverridePath = "sql-error-codes.xml";

    public static SqlErrorCodesFactory Instance { get; private set; }

    static SqlErrorCodesFactory()
    {
        Instance = new SqlErrorCodesFactory();
    }

    protected SqlErrorCodesFactory()
    {

    }

    public SqlErrorCodes GetErrorCodes(string databaseName)
    {
        return null;
    }
}
