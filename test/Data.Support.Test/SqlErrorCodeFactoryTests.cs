namespace Data.Support.Test;

public class SqlErrorCodeFactoryTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestDefaultInstanceWithNoSuchDatabase()
    {
        var codes = SqlErrorCodesFactory.Instance.GetErrorCodes("xx");
        Assert.IsEmpty(codes.BadSqlGrammarCodes);
        Assert.IsEmpty(codes.DataIntegrityViolationCodes);
    }

    [Test]
    public void TestDefaultInstanceWithPgSql()
    {
        var codes = SqlErrorCodesFactory.Instance.GetErrorCodes("PgSql");
        AssertIsPgSql(codes);
    }

    private void AssertIsPgSql(SqlErrorCodes codes)
    {
    }
}
