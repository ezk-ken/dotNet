using System.Data.Common;
using Data.Common;

namespace Data.Support;

/// <summary>
/// <see cref="DbException"/>と<see cref="DataAccessException"/>階層間の変換のためのインターフェース。
/// </summary>
public interface IDbExceptionTranslator
{
    /// <summary>
    /// 指定された<see cref="DbException"/>を汎用<see cref="DataAccessException"/>に変換する。
    ///
    /// 返された<see cref="DataAccessException"/>には、根本原因として元のDbExceptionが含まれているはず。
    /// ただし、DataAccessExceptionは他のリソースAPIが原因である可能性があるため、クライアントコードは通常これに依存しない場合がある。
    /// とはいえ、ADO.Netの悪雪が発生することを期待している場合、GetRootCause() instanceof DbExceptionチェック（およびその後のキャスト）は信頼できると見なされる。
    /// </summary>
    /// <param name="task">試行され散るタスクを説明する読み取り可能なテキスト</param>
    /// <param name="sql">問題を引き起こしたSQLクエリまたは更新（既知の場合）</param>
    /// <param name="exception">問題のあるDbException</param>
    /// <returns>DbExceptionをラップするDataAccessException、または特定の変換を適用できない場合はnull</returns>
    public DataAccessException? Translate(string task, string? sql, DbException exception);
}
