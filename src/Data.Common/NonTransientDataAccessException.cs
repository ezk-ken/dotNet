namespace Data.Common;

/// <summary>
/// 非一時的であるとみなされるデータアクセス例外の階層のルート。
/// <br/>
/// 例外の原因が修正されない限り、同じ操作の再試行は失敗する。
/// </summary>
public class NonTransientDataAccessException : DataAccessException
{
    /// <summary>
    /// 指定したエラーメッセージを使用して<see cref="NonTransientDataAccessException"/>の新しいインスタンスを初期化する。
    /// </summary>
    /// <param name="message">エラーメッセージ</param>
    public NonTransientDataAccessException(string? message) : base(message)
    {
    }

    /// <summary>
    /// 指定したエラーメッセージおよびこの例外の原因となった内部例外への参照を使用して、
    /// <see cref="NonTransientDataAccessException"/>の新しいインスタンスを初期化する。
    /// </summary>
    /// <param name="message">エラーメッセージ</param>
    /// <param name="innerException">現在の例外の原因である例外。内部例外が指定されていない場合は null</param>
    public NonTransientDataAccessException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}
