namespace Data.Common;

/// <summary>
/// 基礎となるリソースが特定の要素（特定のデータベーステーブルなど）へのアクセス許可を拒否した場合にスローされる例外。
/// </summary>
public class PermissionDeniedDataAccessException : NonTransientDataAccessException
{
    /// <summary>
    /// 指定したエラーメッセージを使用して<see cref="PermissionDeniedDataAccessException"/>の新しいインスタンスを初期化する。
    /// </summary>
    /// <param name="message">エラーメッセージ</param>
    public PermissionDeniedDataAccessException(string? message) : base(message)
    {
    }
}
