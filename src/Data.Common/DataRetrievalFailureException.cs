namespace Data.Common;

/// <summary>
/// 特定の予期されたデータを取得できなかった場合にスローされる例外。
/// </summary>
public class DataRetrievalFailureException : NonTransientDataAccessException
{
    /// <summary>
    /// 指定したエラーメッセージを使用して<see cref="DataRetrievalFailureException"/>の新しいインスタンスを初期化する。
    /// </summary>
    /// <param name="message">エラーメッセージ</param>
    public DataRetrievalFailureException(string? message) : base(message)
    {
    }

    /// <summary>
    /// 指定したエラーメッセージおよびこの例外の原因となった内部例外への参照を使用して、
    /// <see cref="DataRetrievalFailureException"/>の新しいインスタンスを初期化する。
    /// </summary>
    /// <param name="message">エラーメッセージ</param>
    /// <param name="innerException">現在の例外の原因である例外。内部例外が指定されていない場合は null</param>
    public DataRetrievalFailureException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}
