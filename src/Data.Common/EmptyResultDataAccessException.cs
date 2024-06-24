namespace Data.Common;

/// <summary>
/// 結果に少なくとも1つの行（または要素）が含まれると予想されていたが、実際には0行（または要素）が返された場合にスローされる例外。
/// </summary>
public class EmptyResultDataAccessException : IncorrectResultSizeDataAccessException
{
    /// <summary>
    /// 指定した期待サイズを使用して<see cref="EmptyResultDataAccessException"/>の新しいインスタンスを初期化する。
    /// </summary>
    /// <param name="expectedSize">期待するサイズ</param>
    public EmptyResultDataAccessException(int expectedSize) : base(expectedSize)
    {
    }

    /// <summary>
    /// 指定したエラーメッセージおよび期待サイズを使用して<see cref="EmptyResultDataAccessException"/>の新しいインスタンスを初期化する。
    /// </summary>
    /// <param name="message">エラーメッセージ</param>
    /// <param name="expectedSize">期待するサイズ</param>
    public EmptyResultDataAccessException(string? message, int expectedSize) : base(message, expectedSize)
    {
    }

    /// <summary>
    /// 指定したエラーメッセージおよび期待サイズ、この例外の原因となった内部例外への参照を使用して、
    /// <see cref="EmptyResultDataAccessException"/>の新しいインスタンスを初期化する。
    /// </summary>
    /// <param name="message">エラーメッセージ</param>
    /// <param name="expectedSize">期待するサイズ</param>
    /// <param name="innerException">現在の例外の原因である例外。内部例外が指定されていない場合は null</param>
    public EmptyResultDataAccessException(string? message, int expectedSize, Exception? innerException) : base(message,
        expectedSize, 0, innerException)
    {
    }
}
