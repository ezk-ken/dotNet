namespace Data.Common;

/// <summary>
/// 楽観的ロック違反でスローされる例外。<br/>
///
/// この例外はO/RマッピングツールやDAOのカスタム委実装によってスローされる。<br/>
/// 楽観的ロックの失敗は、通常データベース自身では検出されない。
/// </summary>
public class OptimisticLockingFailureException : ConcurrencyFailureException
{
    /// <summary>
    /// 指定したエラーメッセージを使用して<see cref="OptimisticLockingFailureException"/>の新しいインスタンスを初期化する。
    /// </summary>
    /// <param name="message">エラーメッセージ</param>
    public OptimisticLockingFailureException(string? message) : base(message)
    {
    }

    /// <summary>
    /// 指定したエラーメッセージおよびこの例外の原因となった内部例外への参照を使用して、
    /// <see cref="OptimisticLockingFailureException"/>の新しいインスタンスを初期化する。
    /// </summary>
    /// <param name="message">エラーメッセージ</param>
    /// <param name="innerException">現在の例外の原因である例外。内部例外が指定されていない場合は null</param>
    public OptimisticLockingFailureException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}
