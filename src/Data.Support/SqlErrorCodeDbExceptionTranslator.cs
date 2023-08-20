using System.Data;
using System.Data.Common;
using Data.Coomon;
using Microsoft.Extensions.Logging;

namespace Data.Support;

/// <summary>
/// ベンダー固有のエラーコードを分析する<see cref="IDbExceptionTranslator"/>の実装。SQL状態に基づいた実装よりも正確だが、ベンダー固有のもである。
///
/// このクラスは次の一致ルールを適用する。
///  - サブクラスで実装されたカスタム変換を試行する。このクラスは具象であり、通常それ自体が使用されることに注意すること。この場合、この規則は適用されない。
///  - エラーコードの一致を適用する。エラーコードは、デフォルトではSqlErrorCodesFacgtoryから取得される。このファクトリーは、クラスパスから"sql-error-codes.xml"ファイルをロードし、データベースメタデータからデータベース名のエラーコードマッピングを定義する。
///
/// "sql-error-codes.xml"という名前の構成ファイルは、デフォルトではこのパッケージから読み取られる。
/// </summary>
public class SqlErrorCodeDbExceptionTranslator : FallbackDbExceptionTranslatorBase
{
    /// <summary>
    /// インスタンスを初期化する。
    ///
    /// <see cref="SqlErrorCodes"/>または<see cref="IDbConnection"/>プロパティを設定する必要がある。
    /// </summary>
    /// <param name="logger">ロガー</param>
    public SqlErrorCodeDbExceptionTranslator(ILogger logger) : base(logger)
    {
    }

    /// <summary>
    /// 指定されたデータベース製品名のSQLエラーコードトランスレータを作成する。
    ///
    /// このコンストラクタを呼び出すと、IDbConnectionプロパティから説族を取得してメタデータを取得することが回避できる。
    /// </summary>
    /// <param name="dbName">エラーコードエントリを識別するデータベース製品名</param>
    /// <param name="logger">ロガー</param>
    public SqlErrorCodeDbExceptionTranslator(string dbName, ILogger logger) : base(logger)
    {
    }

    /// <summary>
    /// 指定されたIDbConnectionのSQLエラーコードトランスレータを作成する。このコンストラクタを呼び出すと、IDbConnectionから接続が取得され、メタデータが取得される。
    /// </summary>
    /// <param name="connection">メタデータを検索し、使用可能なエラーコードを確立するために使用するIDbConnection</param>
    /// <param name="logger">ロガー</param>
    public SqlErrorCodeDbExceptionTranslator(IDbConnection connection, ILogger logger) : base(logger)
    {
    }

    /// <summary>
    /// これらのエラーコードを指定して、SqlErrorCodeトランスレータを作成する。説族を使用してデータベースのメタデータ検索を実行する必要はない。
    /// </summary>
    /// <param name="sec">エラーコード</param>
    /// <param name="logger">ロガー</param>
    public SqlErrorCodeDbExceptionTranslator(SqlErrorCodes sec, ILogger logger) : base(logger)
    {
    }

    protected override DataAccessException? DoTranslate(string task, string? sql, DbException exception)
    {
        throw new NotImplementedException();
    }
}
