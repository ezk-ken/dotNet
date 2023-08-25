namespace Data.Common;

/// <summary>
/// 悲観的なロック違反時にスローされる例外。
/// <br/>
/// <see cref="CannotAcquireLockException"/>などの、より特殊な例外のスーパークラスとして機能する。<br/>
/// しかし、一般的には、特定の例外のサブクラスに依存するのではなく、このクラス自身を処理することを推奨する。
/// </summary>
public class PessimisticLockingFailureException : ConcurrencyFailureException
{
    /// <summary>
    /// 指定したエラーメッセージを使用して<see cref="PessimisticLockingFailureException"/>の新しいインスタンスを初期化する。
    /// </summary>
    /// <param name="message">エラーメッセージ</param>
    public PessimisticLockingFailureException(string? message) : base(message)
    {
    }

    /// <summary>
    /// 指定したエラーメッセージおよびこの例外の原因となった内部例外への参照を使用して、
    /// <see cref="PessimisticLockingFailureException"/>の新しいインスタンスを初期化する。
    /// </summary>
    /// <param name="message">エラーメッセージ</param>
    /// <param name="innerException">現在の例外の原因である例外。内部例外が指定されていない場合は null</param>
    public PessimisticLockingFailureException(string? message, Exception? innerException) : base(message,
        innerException)
    {
    }
}
