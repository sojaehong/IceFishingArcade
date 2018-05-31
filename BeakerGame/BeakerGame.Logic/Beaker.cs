namespace BeakerGame.Logic
{
    public class Beaker
    {
        public Beaker(int capacity, int liter)
        {
            Capacity = capacity;
            Liter = liter;
        }

        public int Capacity { get; private set; }

        public int Liter { get; set; }
    }
}