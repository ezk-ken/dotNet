namespace Data.Common;

/// <summary>
/// リソースが完全に失敗した場合、例えばデータベースに接続できない場合にスローされるデータアクセス例外。
/// </summary>
public class DataAccessResourceFailureException : NonTransientDataAccessResourceException
{
    /// <summary>
    /// 指定したエラーメッセージを使用して<see cref="DataAccessResourceFailureException"/>の新しいインスタンスを初期化する。
    /// </summary>
    /// <param name="message">エラーメッセージ</param>
    public DataAccessResourceFailureException(string? message) : base(message)
    {
    }

    /// <summary>
    /// 指定したエラーメッセージおよびこの例外の原因となった内部例外への参照を使用して、
    /// <see cref="DataAccessResourceFailureException"/>の新しいインスタンスを初期化する。
    /// </summary>
    /// <param name="message">エラーメッセージ</param>
    /// <param name="innerException">現在の例外の原因である例外。内部例外が指定されていない場合は null</param>
    public DataAccessResourceFailureException(string? message, Exception? innerException) : base(message,
        innerException)
    {
    }
}
