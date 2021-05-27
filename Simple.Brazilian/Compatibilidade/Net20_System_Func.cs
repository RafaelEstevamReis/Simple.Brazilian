#if NET20
namespace System
{
    /// <summary>
    /// Delegate de compatibilidade para NET20
    /// </summary>
    public delegate TResult Func<in T, out TResult>(T arg);
    /// <summary>
    /// Delegate de compatibilidade para NET20
    /// </summary>
    public delegate TResult Func<in T1, in T2, out TResult>(T1 arg1, T2 arg2);
    /// <summary>
    /// Delegate de compatibilidade para NET20
    /// </summary>
    public delegate TResult Func<in T1, in T2, in T3, out TResult>(T1 arg1, T2 arg2, T3 arg3);
}
#endif