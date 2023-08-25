namespace Data.Common;

/// <summary>
/// リソースに完全な障害が発生し、その霜害が永続的な場合にスローされるデータアクセス例外。
/// </summary>
public class NonTransientDataAccessResourceException : NonTransientDataAccessException
{
    /// <summary>
    /// 指定したエラーメッセージを使用して<see cref="NonTransientDataAccessResourceException"/>の新しいインスタンスを初期化する。
    /// </summary>
    /// <param name="message">エラーメッセージ</param>
    public NonTransientDataAccessResourceException(string? message) : base(message)
    {
    }

    /// <summary>
    /// 指定したエラーメッセージおよびこの例外の原因となった内部例外への参照を使用して、
    /// <see cref="NonTransientDataAccessResourceException"/>の新しいインスタンスを初期化する。
    /// </summary>
    /// <param name="message">エラーメッセージ</param>
    /// <param name="innerException">現在の例外の原因である例外。内部例外が指定されていない場合は null</param>
    public NonTransientDataAccessResourceException(string? message, Exception? innerException) : base(message,
        innerException)
    {
    }
}
