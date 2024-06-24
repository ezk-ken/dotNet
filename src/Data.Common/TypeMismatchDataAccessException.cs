namespace Data.Common;

/// <summary>
/// .Netの型とデータベースの型が一致しない場合にスローされる例外。
/// </summary>
public class TypeMismatchDataAccessException : InvalidDataAccessResourceUsageException
{
    /// <summary>
    /// 指定したエラーメッセージを使用して<see cref="TypeMismatchDataAccessException"/>の新しいインスタンスを初期化する。
    /// </summary>
    /// <param name="message">エラーメッセージ</param>
    public TypeMismatchDataAccessException(string? message) : base(message)
    {
    }

    /// <summary>
    /// 指定したエラーメッセージおよびこの例外の原因となった内部例外への参照を使用して、
    /// <see cref="TypeMismatchDataAccessException"/>の新しいインスタンスを初期化する。
    /// </summary>
    /// <param name="message">エラーメッセージ</param>
    /// <param name="innerException">現在の例外の原因である例外。内部例外が指定されていない場合は null</param>
    public TypeMismatchDataAccessException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}
