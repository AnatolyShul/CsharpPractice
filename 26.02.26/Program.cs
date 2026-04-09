using System;
using System.Runtime.Intrinsics.Arm;

namespace ClassWork
{
    public class Program
    {
        static void Main()
        {
            A a = new A("Роберт", "Пренко", 18, 150);

            B b = new ("Тимоха", "Сагидуллин", 18, -20, 2, false);
            b.Print();
        }
    }
}