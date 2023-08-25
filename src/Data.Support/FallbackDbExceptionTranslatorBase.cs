using System.Data.Common;
using Data.Common;
using Microsoft.Extensions.Logging;

namespace Data.Support;

/// <summary>
/// 他の<see cref="IDbExceptionTranslator"/>へのフォールバックを可能にする<see cref="IDbExceptionTranslator"/>の実装基本クラス。
/// </summary>
public abstract class FallbackDbExceptionTranslatorBase : IDbExceptionTranslator
{
    /// <summary>
    /// インスタンスを初期化する。
    /// </summary>
    /// <param name="logger"></param>
    public FallbackDbExceptionTranslatorBase(ILogger logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// 引数を事前にチェックし、<see cref="DoTranslate"/>を呼び刺し、必要に応じて<see cref="IDbExceptionTranslator"/>を呼び出す。
    /// </summary>
    /// <param name="task"></param>
    /// <param name="sql"></param>
    /// <param name="exception"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public virtual DataAccessException? Translate(string task, string? sql, DbException exception)
    {
        throw new NotImplementedException();
    }

    public virtual IDbExceptionTranslator GetFallbackTranslator()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// 指定された<see cref="DbException"/>のメッセージ文字列を作成する。
    ///
    /// <see cref="DataAccessException"/>クラスのインスタンスを作成するときに、トランスレータサブクラスによって呼び出される。
    /// </summary>
    /// <param name="task">試行され散るタスクを説明する読み取り可能なテキスト</param>
    /// <param name="sql">問題の原因となったSQLステートメント</param>
    /// <param name="exception">問題のあるDbException</param>
    /// <returns>使用するメッセージ文字列</returns>
    protected virtual string BuildMessage(string task, string? sql, DbException exception)
    {
        throw new NotImplementedException();
    }

    public virtual void SetFallbackTranslator(IDbExceptionTranslator? fallback)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// 指定された例外を実際に変換するためのテンプレートメソッド。
    ///
    /// 渡された引数は事前にチェックされている。さらに、このメソッドはnullを返し、例外の一致が見つからなかったこと、およびフォールバック変換が開始されることを示すことができる。
    /// </summary>
    /// <param name="task">試行され散るタスクを説明する読み取り可能なテキスト</param>
    /// <param name="sql">問題を引き起こしたSQLクエリまたは更新（既知の場合）</param>
    /// <param name="exception">問題のあるDbException</param>
    /// <returns>DbExceptionをラップするDataAccessException。例外一致が見つからなかった場合はnull</returns>
    protected abstract DataAccessException? DoTranslate(string task, string? sql, DbException exception);

    protected readonly ILogger _logger;
}
