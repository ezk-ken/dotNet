namespace Data.Common;

/// <summary>
/// リソースが一時的に失敗し、操作を再試行できる場合にスローされるデータアクセス例外。
/// </summary>
public class TransientDataAccessResourceException : TransientDataAccessException
{
    /// <summary>
    /// 指定したエラーメッセージを使用して<see cref="TransientDataAccessResourceException"/>の新しいインスタンスを初期化する。
    /// </summary>
    /// <param name="message">エラーメッセージ</param>
    public TransientDataAccessResourceException(string? message) : base(message)
    {
    }

    /// <summary>
    /// 指定したエラーメッセージおよびこの例外の原因となった内部例外への参照を使用して、
    /// <see cref="TransientDataAccessResourceException"/>の新しいインスタンスを初期化する。
    /// </summary>
    /// <param name="message">エラーメッセージ</param>
    /// <param name="innerException">現在の例外の原因である例外。内部例外が指定されていない場合は null</param>
    public TransientDataAccessResourceException(string? message, Exception? innerException) : base(message,
        innerException)
    {
    }
}
