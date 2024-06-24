namespace Data.Common;

/// <summary>
/// データを挿入または更新しようとした結果、整合性制約に違反した場合にスローされる例外。
/// </summary>
public class DataIntegrityViolationException : NonTransientDataAccessException
{
    /// <summary>
    /// 指定したエラーメッセージを使用して<see cref="DataIntegrityViolationException"/>の新しいインスタンスを初期化する。
    /// </summary>
    /// <param name="message">エラーメッセージ</param>
    public DataIntegrityViolationException(string? message) : base(message)
    {
    }

    /// <summary>
    /// 指定したエラーメッセージおよびこの例外の原因となった内部例外への参照を使用して、
    /// <see cref="DataIntegrityViolationException"/>の新しいインスタンスを初期化する。
    /// </summary>
    /// <param name="message">エラーメッセージ</param>
    /// <param name="innerException">現在の例外の原因である例外。内部例外が指定されていない場合は null</param>
    public DataIntegrityViolationException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}
