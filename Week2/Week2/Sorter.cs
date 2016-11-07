using Week2.Contracts;

namespace Week2
{
    public abstract class Sorter
    {
        public Sorter(int[] array, ILogger logger)
        {
            this.Logger = logger;
        }

        public ILogger Logger { get; set; }

        public abstract int[] Sort(int[] array);
    }
}