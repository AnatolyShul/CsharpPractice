using System.Runtime.CompilerServices;

namespace ClassWork
{
    public class Example{
        private int _number;
        private string _word;

        public int Number => _number;
        public string Word => _word;

        public Example(int number = -100, string word = "unknown", int number2 = 0)
        {
            _number = number;
            _word = word;
        }
    }

    
    public class Program
    {
        static void Main()
        {
            // Example ex1 = new Example(10, "Hello, world");
            // Example ex2 = new Example(10);
            // Example ex3 = new Example(10, "Hello, world", 16);
            // Example ex4 = new Example();
            // System.Console.WriteLine(ex.Number);
            Task1 task = new Task1("привет");
            task.ChangeText("пока");
            System.Console.WriteLine(task.ToString());
        }
    }
}


