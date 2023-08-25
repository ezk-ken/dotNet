namespace Data.Common;

/// <summary>
/// 以前に失敗した操作の際にスローされたデータアクセス例外はアプリケーションが何らかの回復手順を実行し、
/// トランザクション全体、あるいは分散トランザクションの倍はトランザクション分岐を再試行すれば、成功する可能性がある。
/// 少なくとも、回復操作には現在の接続を閉じて新しい接続を取得することが含まれなければならない。
/// </summary>
public class RecoverableDataAccessException : DataAccessException
{
    /// <summary>
    /// 指定したエラーメッセージを使用して<see cref="RecoverableDataAccessException"/>の新しいインスタンスを初期化する。
    /// </summary>
    /// <param name="message">エラーメッセージ</param>
    public RecoverableDataAccessException(string? message) : base(message)
    {
    }

    /// <summary>
    /// 指定したエラーメッセージおよびこの例外の原因となった内部例外への参照を使用して、
    /// <see cref="RecoverableDataAccessException"/>の新しいインスタンスを初期化する。
    /// </summary>
    /// <param name="message">エラーメッセージ</param>
    /// <param name="innerException">現在の例外の原因である例外。内部例外が指定されていない場合は null</param>
    public RecoverableDataAccessException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}
