using System;

namespace lesson13
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //var obj1 = new Person { Name = "roay", Age = 31 };
            //var obj2 = new Person { Name = "saeed", Age = 300 };

            var obj1 = new Person();
            //Console.WriteLine(obj1.add(new int[] { 2, 3 }));
            //Console.WriteLine(obj1.add(2, 3));
            //int x;
            //int y;
            //obj1.caculate(1, 2, out x, out y);
            //Console.WriteLine($"sum:{x}");
            //Console.WriteLine($"sub:{y}");


            //var age = 10;

            //obj1.calculateAge(ref age);
            //Console.WriteLine(age);

            Console.WriteLine(obj1.decimalGetSalary2020());
            Console.ReadKey();
        }
    }


}
