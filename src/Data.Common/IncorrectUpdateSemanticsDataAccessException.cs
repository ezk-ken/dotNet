namespace Data.Common;

/// <summary>
/// 更新で意図しない何かが発生したと思われるが、トランザクションがまだロールバックされていない場合にスローされるデータアクセス例外。
/// </summary>
public class IncorrectUpdateSemanticsDataAccessException : InvalidDataAccessResourceUsageException
{
    /// <summary>
    /// データが更新されたがどうかを返す。<br/>
    ///
    /// デフォルトの実装では常にtrueを返す。これはサブクラスでオーバーライドできる。
    /// </summary>
    public virtual bool WasDataUpdated => true;

    /// <summary>
    /// 指定したエラーメッセージを使用して<see cref="IncorrectUpdateSemanticsDataAccessException"/>の新しいインスタンスを初期化する。
    /// </summary>
    /// <param name="message">エラーメッセージ</param>
    public IncorrectUpdateSemanticsDataAccessException(string? message) : base(message)
    {
    }

    /// <summary>
    /// 指定したエラーメッセージおよびこの例外の原因となった内部例外への参照を使用して、
    /// <see cref="IncorrectUpdateSemanticsDataAccessException"/>の新しいインスタンスを初期化する。
    /// </summary>
    /// <param name="message">エラーメッセージ</param>
    /// <param name="innerException">現在の例外の原因である例外。内部例外が指定されていない場合は null</param>
    public IncorrectUpdateSemanticsDataAccessException(string? message, Exception? innerException) : base(message,
        innerException)
    {
    }
}
