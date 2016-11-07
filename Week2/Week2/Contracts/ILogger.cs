namespace Week2.Contracts
{
    public interface ILogger
    {
        void Write(string text);

        void WriteLine(string text);
    }
}