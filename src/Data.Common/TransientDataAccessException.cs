namespace Data.Common;

/// <summary>
/// 一時的とみなされるデータアクセス例外。<br/>
///
/// アプリケーションレベルの機能による介入なしに、以前に失敗した操作が再試行されたときに成功する可能性がある。
/// </summary>
public class TransientDataAccessException : DataAccessException
{
    /// <summary>
    /// 指定したエラーメッセージを使用して<see cref="TransientDataAccessException"/>の新しいインスタンスを初期化する。
    /// </summary>
    /// <param name="message">エラーメッセージ</param>
    public TransientDataAccessException(string? message) : base(message)
    {
    }

    /// <summary>
    /// 指定したエラーメッセージおよびこの例外の原因となった内部例外への参照を使用して、
    /// <see cref="TransientDataAccessException"/>の新しいインスタンスを初期化する。
    /// </summary>
    /// <param name="message">エラーメッセージ</param>
    /// <param name="innerException">現在の例外の原因である例外。内部例外が指定されていない場合は null</param>
    public TransientDataAccessException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}
