using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    public class A
    {

        //поля

        protected string _name;
        protected string _surname;
        protected int _age;
        protected int _iq;

        //свойства

        public string Name => _name;
        public string Surname => _surname;
        public int Age => _age;
        public int Iq => _iq;

        //конструктор

        public A(string name, string surname, int age, int iq)
        {
            _name = name;
            _surname = surname;
            _age = age;
            _iq = iq;
        }

        //методы

        public virtual void Method()
        {
            System.Console.WriteLine("Method in Class A");
        }

        public void Print()
        {
            System.Console.WriteLine($"Name: {_name}, Surname: {_surname}, Age: {_age}, Iq: {_iq}");
        }


    }

    public class B : A
    {

        //поля

        private int _mark;
        private bool _test;

        //свойства
        
        public int Mark => _mark;
        public bool Test => _test;

        //конструкторы

        public B(string name, string surname, int age, int iq, int mark) : base(name, surname, age, iq)
        {
            _mark = mark;
            _test = true;
        }

        public B(string name, string surname, int age, int iq, int mark, bool test) : this(name, surname, age, iq, mark)
        {
            _test = test;
        }

        //методы

        public override void Method()
        {
            System.Console.WriteLine("Method in Class B");
        }

        public new void Print()
        {
            System.Console.WriteLine($"Name: {_name}, Surname: {_surname}, Age: {_age}, Iq: {_iq}, Mark: {_mark}, TestWasPassed: {_test}");
        }
    }
}
