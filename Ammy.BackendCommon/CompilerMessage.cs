namespace Ammy.BackendCommon
{
    public class CompilerMessage
    {
        public CompilerMessageType Type { get; }
        public string Message { get; }

        public CompilerMessage(CompilerMessageType type, string message)
        {
            Type = type;
            Message = message;
        }
    }
}