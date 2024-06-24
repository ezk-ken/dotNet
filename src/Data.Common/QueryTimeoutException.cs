namespace Data.Common;

/// <summary>
/// クエリタイムアウト時にスローされる例外。<br/>
///
/// これは使用しているデータベースAPIによって原因が異なるが、ほとんどの場合、データベースがクエリの処理を中断したり、
/// クエリが完了する前に処理を停止した後にスローされる。<br/>
///
/// この例外は、ネイティブなデータベース例外をトラップするユーザーコードや、例外変換によってスローされる可能性がある。
/// </summary>
public class QueryTimeoutException : TransientDataAccessException
{
    /// <summary>
    /// 指定したエラーメッセージを使用して<see cref="QueryTimeoutException"/>の新しいインスタンスを初期化する。
    /// </summary>
    /// <param name="message">エラーメッセージ</param>
    public QueryTimeoutException(string? message) : base(message)
    {
    }

    /// <summary>
    /// 指定したエラーメッセージおよびこの例外の原因となった内部例外への参照を使用して、
    /// <see cref="QueryTimeoutException"/>の新しいインスタンスを初期化する。
    /// </summary>
    /// <param name="message">エラーメッセージ</param>
    /// <param name="innerException">現在の例外の原因である例外。内部例外が指定されていない場合は null</param>
    public QueryTimeoutException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}
