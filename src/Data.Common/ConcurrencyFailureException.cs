namespace Data.Common;

/// <summary>
/// さまざまなデータアクセスの同時実行に失敗したときにスローされる例外。<br/>
///
/// 子の例外は、特に楽観的ロックと悲観的ロックのような、特定のタイプの失敗のためのサブクラスを提供する。
/// </summary>
public class ConcurrencyFailureException : TransientDataAccessException
{
    /// <summary>
    /// 指定したエラーメッセージを使用して<see cref="ConcurrencyFailureException"/>の新しいインスタンスを初期化する。
    /// </summary>
    /// <param name="message">エラーメッセージ</param>
    public ConcurrencyFailureException(string? message) : base(message)
    {
    }

    /// <summary>
    /// 指定したエラーメッセージおよびこの例外の原因となった内部例外への参照を使用して、
    /// <see cref="ConcurrencyFailureException"/>の新しいインスタンスを初期化する。
    /// </summary>
    /// <param name="message">エラーメッセージ</param>
    /// <param name="innerException">現在の例外の原因である例外。内部例外が指定されていない場合は null</param>
    public ConcurrencyFailureException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}
