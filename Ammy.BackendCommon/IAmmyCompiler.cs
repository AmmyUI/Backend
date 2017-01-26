namespace Ammy.BackendCommon
{
    public interface IAmmyCompiler
    {
        CompilationResult Compile(CompilationRequest request);
    }
}