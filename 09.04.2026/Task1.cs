using System.Runtime.CompilerServices;

namespace ClassWork
{
    public class Task1 : White
    {
        private int _output;


        public int Output => _output;


        public Task1 (string text) : base(text)
        {
            _output = Helper() * 2;// или review
        }


        private int Helper()
        {
            return 1;
            //...
        }
        public override void Review()
        {
            _output += Helper();
        }

        public override string ToString()
        {
            return $"{_input}{Environment.NewLine}{_output}";
        }
    }
}