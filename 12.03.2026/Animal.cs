
using System.Data.Common;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace Class
{
    public abstract class Animal
    {
        private int _id;

        public int Id => _id;
        public abstract string Type {get;}
        public Animal(int id)
        {
            _id = id;
        }

        public abstract void Voice();

        public virtual void Print()
        {
            System.Console.Write("Animal ID " + _id);
        }
    }

    public class Cat : Animal
    {
        public override string Type => "Кошка";
        public Cat(int id) : base(id) { }
        public override void Voice() => System.Console.WriteLine("meow");
        public void Idol()
        {
            System.Console.WriteLine(Id);
        }
        public override void Print()
        {
            Console.WriteLine("кошка");
        }
    }
}
