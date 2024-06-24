namespace Data.Common;

/// <summary>
/// 重複キー例外。<br/>
/// データを挿入または更新しようとした結果、主キーまたは一意制約に違反した場合にスローされる例外。
/// </summary>
public class CannotAcquireLockException : PessimisticLockingFailureException
{
    /// <summary>
    /// 指定したエラーメッセージを使用して<see cref="CannotAcquireLockException"/>の新しいインスタンスを初期化する。
    /// </summary>
    /// <param name="message">エラーメッセージ</param>
    public CannotAcquireLockException(string? message) : base(message)
    {
    }

    /// <summary>
    /// 指定したエラーメッセージおよびこの例外の原因となった内部例外への参照を使用して、
    /// <see cref="CannotAcquireLockException"/>の新しいインスタンスを初期化する。
    /// </summary>
    /// <param name="message">エラーメッセージ</param>
    /// <param name="innerException">現在の例外の原因である例外。内部例外が指定されていない場合は null</param>
    public CannotAcquireLockException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}
