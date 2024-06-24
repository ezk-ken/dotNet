namespace Data.Common;

/// <summary>
/// データアクセスリソースを誤って使用した場合にスローされる例外のルート。<br/>
///
/// 例えば、RDBMSを使用する際に不正なSQLを指定するとスローされる。
/// </summary>
public class InvalidDataAccessResourceUsageException : NonTransientDataAccessException
{
    /// <summary>
    /// 指定したエラーメッセージを使用して<see cref="InvalidDataAccessResourceUsageException"/>の新しいインスタンスを初期化する。
    /// </summary>
    /// <param name="message">エラーメッセージ</param>
    public InvalidDataAccessResourceUsageException(string? message) : base(message)
    {
    }

    /// <summary>
    /// 指定したエラーメッセージおよびこの例外の原因となった内部例外への参照を使用して、
    /// <see cref="InvalidDataAccessResourceUsageException"/>の新しいインスタンスを初期化する。
    /// </summary>
    /// <param name="message">エラーメッセージ</param>
    /// <param name="innerException">現在の例外の原因である例外。内部例外が指定されていない場合は null</param>
    public InvalidDataAccessResourceUsageException(string? message, Exception? innerException) : base(message,
        innerException)
    {
    }
}
