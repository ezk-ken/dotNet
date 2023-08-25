namespace Data.Common;

/// <summary>
/// 基になるリソースで問題が発生した以外に具体的なものを区別できない場合の通常のスーパークラス。
/// </summary>
public class UncategorizedDataAccessException : NonTransientDataAccessException
{
    /// <summary>
    /// 指定したエラーメッセージおよびこの例外の原因となった内部例外への参照を使用して、
    /// <see cref="UncategorizedDataAccessException"/>の新しいインスタンスを初期化する。
    /// </summary>
    /// <param name="message">エラーメッセージ</param>
    /// <param name="innerException">現在の例外の原因である例外。内部例外が指定されていない場合は null</param>
    public UncategorizedDataAccessException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}
