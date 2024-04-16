using System.Runtime.InteropServices;

namespace SingleResponsibilty
{
    public class Journal
    {
        private readonly List<String> entries = new List<string>();
        private static int count = 0;

        public int AddEntry(String entry)
        {
            entries.Add($"{++count}:{entry}");
            return count;
        }

        public void RemoveEntry(int index)
        {
            entries.RemoveAt( index );
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, entries);
        }
    }

    public class Demo
    {
        static void Main(string[] args)
        { 
            var j = new Journal();
            j.AddEntry("First line");
            j.AddEntry("Second line");

            Console.WriteLine(j);

        }
    }
}