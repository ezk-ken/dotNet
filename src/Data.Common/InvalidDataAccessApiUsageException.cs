namespace Data.Common;

/// <summary>
/// 実行前にコンパイルが必要なクエリオブジェクトのコンパイルに失敗したなど、APIが正しく使用されなかった場合にスローされるデータアクセス例外。
/// </summary>
public class InvalidDataAccessApiUsageException : NonTransientDataAccessException
{
    /// <summary>
    /// 指定したエラーメッセージを使用して<see cref="InvalidDataAccessApiUsageException"/>の新しいインスタンスを初期化する。
    /// </summary>
    /// <param name="message">エラーメッセージ</param>
    public InvalidDataAccessApiUsageException(string? message) : base(message)
    {
    }

    /// <summary>
    /// 指定したエラーメッセージおよびこの例外の原因となった内部例外への参照を使用して、
    /// <see cref="InvalidDataAccessApiUsageException"/>の新しいインスタンスを初期化する。
    /// </summary>
    /// <param name="message">エラーメッセージ</param>
    /// <param name="innerException">現在の例外の原因である例外。内部例外が指定されていない場合は null</param>
    public InvalidDataAccessApiUsageException(string? message, Exception? innerException) : base(message,
        innerException)
    {
    }
}
