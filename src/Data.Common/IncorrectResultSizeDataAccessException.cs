namespace Data.Common;

/// <summary>
/// 結果が予期したサイズではなかった場合、例えば1行を予期していたが、0行または1行以上の行を取得した場合にスローされるデータアクセス例外。
/// </summary>
public class IncorrectResultSizeDataAccessException : DataRetrievalFailureException
{
    /// <summary>
    /// 期待するサイズを返す。
    /// </summary>
    public int ExpectedSize { get; }

    /// <summary>
    /// 実際のサイズを返す。
    /// </summary>
    public int ActualSize { get; }

    /// <summary>
    /// 指定した期待サイズを使用して<see cref="IncorrectResultSizeDataAccessException"/>の新しいインスタンスを初期化する。
    /// </summary>
    /// <param name="expectedSize">期待するサイズ</param>
    public IncorrectResultSizeDataAccessException(int expectedSize)
        : base($"Incorrect result size: exptected {expectedSize}")
    {
        ExpectedSize = expectedSize;
        ActualSize = -1;
    }

    /// <summary>
    /// 指定した期待サイズおよび実際のサイズを使用して<see cref="IncorrectResultSizeDataAccessException"/>の新しいインスタンスを初期化する。
    /// </summary>
    /// <param name="expectedSize">期待するサイズ</param>
    /// <param name="actualSize">実際のサイズ</param>
    public IncorrectResultSizeDataAccessException(int expectedSize, int actualSize)
        : base($"Incorrect result size: expected {expectedSize}, actual {actualSize}")
    {
        ExpectedSize = expectedSize;
        ActualSize = actualSize;
    }

    /// <summary>
    /// 指定したエラーメッセージおよび期待サイズを使用して<see cref="IncorrectResultSizeDataAccessException"/>の新しいインスタンスを初期化する。
    /// </summary>
    /// <param name="message">エラーメッセージ</param>
    /// <param name="expectedSize">期待するサイズ</param>
    public IncorrectResultSizeDataAccessException(string? message, int expectedSize)
        : base(message)
    {
        ExpectedSize = expectedSize;
        ActualSize = -1;
    }

    /// <summary>
    /// 指定したエラーメッセージおよび期待サイズ、この例外の原因となった内部例外への参照を使用して、
    /// <see cref="IncorrectResultSizeDataAccessException"/>の新しいインスタンスを初期化する。
    /// </summary>
    /// <param name="message">エラーメッセージ</param>
    /// <param name="expectedSize">期待するサイズ</param>
    /// <param name="innerException">現在の例外の原因である例外。内部例外が指定されていない場合は null</param>
    public IncorrectResultSizeDataAccessException(string? message, int expectedSize, Exception? innerException)
        : base(message, innerException)
    {
        ExpectedSize = expectedSize;
        ActualSize = -1;
    }

    /// <summary>
    /// 指定したエラーメッセージおよび期待サイズ、実際のサイズを使用して、
    /// <see cref="IncorrectResultSizeDataAccessException"/>の新しいインスタンスを初期化する。
    /// </summary>
    /// <param name="message">エラーメッセージ</param>
    /// <param name="expectedSize">期待するサイズ</param>
    /// <param name="actualSize">実際のサイズ</param>
    public IncorrectResultSizeDataAccessException(string? message, int expectedSize, int actualSize)
        : base(message)
    {
        ExpectedSize = expectedSize;
        ActualSize = actualSize;
    }

    /// <summary>
    /// 指定したエラーメッセージおよび期待サイズ、実際のサイズ、この例外の原因となった内部例外への参照を使用して、
    /// <see cref="IncorrectResultSizeDataAccessException"/>の新しいインスタンスを初期化する。
    /// </summary>
    /// <param name="message">エラーメッセージ</param>
    /// <param name="expectedSize">期待するサイズ</param>
    /// <param name="actualSize">実際のサイズ</param>
    /// <param name="innerException">現在の例外の原因である例外。内部例外が指定されていない場合は null</param>
    public IncorrectResultSizeDataAccessException(string? message, int expectedSize, int actualSize,
        Exception? innerException)
        : base(message, innerException)
    {
        ExpectedSize = expectedSize;
        ActualSize = actualSize;
    }
}
