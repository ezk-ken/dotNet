namespace Data.Common;

/// <summary>
/// データを挿入または更新しようとした結果、主キーまたはいちい制約に違反した場合にスローされる例外。<br/>
///
/// 一意な主キーはほとんどのデータベース型で要求される。<br/>
/// 代わりに一般的な<see cref="DataIntegrityViolationException"/>を扱うことを検討すること。
/// </summary>
public class DuplicateKeyException : DataIntegrityViolationException
{
    /// <summary>
    /// 指定したエラーメッセージを使用して<see cref="DuplicateKeyException"/>の新しいインスタンスを初期化する。
    /// </summary>
    /// <param name="message">エラーメッセージ</param>
    public DuplicateKeyException(string? message) : base(message)
    {
    }

    /// <summary>
    /// 指定したエラーメッセージおよびこの例外の原因となった内部例外への参照を使用して、
    /// <see cref="DuplicateKeyException"/>の新しいインスタンスを初期化する。
    /// </summary>
    /// <param name="message">エラーメッセージ</param>
    /// <param name="innerException">現在の例外の原因である例外。内部例外が指定されていない場合は null</param>
    public DuplicateKeyException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}
