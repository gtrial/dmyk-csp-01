namespace task2
{
    public class Element
    {
        public string Name { get; }
        public int Number { get; }
        public int DaysCount { get; }

        public Element(string name, int number, int daysCount)
        {
            Name = name;
            Number = number;
            DaysCount = daysCount;
        }
    }
}