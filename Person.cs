using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Policy;

namespace lesson13
{
    public class Person
    {
        //private string _name;
        //private int _age;

        //public void setName(string name)
        //{
        //    _name = name;
        //}

        //public string getName()
        //{
        //    return _name;
        //}

        private int _age;
        public string Name { get; set; }
        public bool Ismmaarid { get; set; }
        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 0)
                {
                    _age = value;
                }
                else
                {
                    _age = (-1) * value;
                }
            }
        }


        //public void setAge(int age)
        //{
        //    if (age > 0)
        //    {
        //        _age = age;
        //    }
        //    else
        //    {
        //        _age = age * (-1);
        //    }

        //}
        //public int getAge()
        //{
        //    return _age;
        //}

        //public int add(int x, int y)
        //{
        //    return x + y;
        //}
        //public int add(int x, int y, int z)
        //{
        //    return x + y + z;
        //}

        //public int add(params int[] numbers)
        //{
        //    var sum = 0;
        //    foreach (var item in numbers)
        //    {
        //        sum += item;
        //    }
        //    return sum;
        //}

        //public void caculate(int x, int y, out int sum, out int sub)
        //{
        //    sum = x + y;
        //    sub = x - y;
        //}

        //public int calculateAge(ref int age)
        //{
        //    age = age + 5;
        //    return age;
        //}


        //public void GetInfo()
        //{
        //    Console.WriteLine($"name is {Name} and your age : {Age}");
        //}

        public decimal decimalGetSalary2020()
        {
            return GetSalary() - 10000;
        }

        private decimal GetSalary()
        {
            return 50000;
        }
    }
}
