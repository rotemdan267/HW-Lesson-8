using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Lesson_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = new int[3] { 1, 2, 3 };
            //int[] arr1 = new int[3];
            //int[] arr2 = arr;
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    arr1[i] = arr[i];
            //}

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine("arr[{0}] = {1},            {1}, {0}", i, arr[i]);
            //    Console.WriteLine("arr1[{0}] = {1}", i, arr1[i]);
            //    Console.WriteLine("arr2[{0}] = {1}", i, arr2[i]);
            //    Console.WriteLine();
            //}

            //arr[0] = 10;
            //arr1[1] = 20;
            //arr2[2] = 30;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine("arr[{0}] = {1},            {1}, {0}", i, arr[i]);
            //    Console.WriteLine("arr1[{0}] = {1}", i, arr1[i]);
            //    Console.WriteLine("arr2[{0}] = {1}", i, arr2[i]);
            //    Console.WriteLine();
            //}

            //Vehicle onlyBase = new Vehicle();
            //Vehicle baseWithCar = new Car();
            //Vehicle baseWithMotor = new Motorcycle();
            //Car onlyCar = new Car();
            //Motorcycle onlyMotor = new Motorcycle();

            //Console.WriteLine("Only Base");
            //onlyBase.OpenOrCloseRoof();
            //onlyBase.AddWheel();
            //Console.WriteLine(onlyBase.isRoofOpen);
            //Console.WriteLine();

            //Console.WriteLine("Base With car");
            //baseWithCar.AddWheel();
            //baseWithCar.OpenOrCloseRoof();
            //Console.WriteLine(baseWithCar.isRoofOpen);
            //Console.WriteLine();

            //Console.WriteLine("Only car");
            //onlyCar.OpenOrCloseRoof();
            //onlyCar.AddWheel();
            //Console.WriteLine(onlyCar.isRoofOpen);
            //Console.WriteLine();

            //Console.WriteLine("Base With motor");
            //baseWithMotor.AddWheel();
            //baseWithMotor.OpenOrCloseRoof();
            //Console.WriteLine(baseWithMotor.isRoofOpen);
            //Console.WriteLine();

            //Console.WriteLine("Only motor");
            //onlyMotor.OpenOrCloseRoof();
            //onlyMotor.AddWheel();
            //Console.WriteLine(onlyMotor.isRoofOpen);
            //Console.WriteLine();

            Person p = new Person()
            {
                id = 123,
                lastName = "cohen",
                firstName = "yossi"
            };
            Person p1 = new Person()
            {
                id = 1243,
                lastName = "cohen",
                firstName = "yossi"
            };
            Person p2 = new Person()
            {
                id = 123,
                lastName = "cohn",
                firstName = "yossi"
            };

            Kid k = new Kid()
            {
                id = 123,
                lastName = "cohen",
                firstName = "yossi"
            };
            Kid k1 = new Kid()
            {
                id = 1243,
                lastName = "cohen",
                firstName = "yossi"
            };
            Kid k2 = new Kid()
            {
                id = 123,
                lastName = "cohn",
                firstName = "yossi"
            };

            Person pk = new Kid()
            {
                id = 123,
                lastName = "cohen",
                firstName = "yossi"
            };

            Console.WriteLine("false " + p.IsEqual(p1));
            Console.WriteLine("true " + p.IsEqual(p2));
            Console.WriteLine();
            Console.WriteLine("true " + k.IsEqual(k1));
            Console.WriteLine("false " + k.IsEqual(k2));
            Console.WriteLine();
            Console.WriteLine("true " + k.IsEqual(p1));
            Console.WriteLine("false " + p.IsEqual(k1));
            Console.WriteLine();
            Console.WriteLine("true " + pk.IsEqual(k1));







            Console.ReadLine();
        }
    }

    class Clock
    {
        public int minutes;
        public int hours;
        public int seconds;
        public int day;
        public int temp;
        public Clock(int min, int hou, int sec, int da, int tem)
        {
            minutes = min;
            hours = hou;
            seconds = sec;
            day = da;
            temp = tem;
        }
        public void PrintDetails(int min, int hou)
        {
            Console.WriteLine("minutes=" + minutes);
            Console.WriteLine("hours=" + hours);
        }
        public void PrintDetails(int min, int hou, int sec)
        {
            Console.WriteLine("minutes=" + minutes);
            Console.WriteLine("hours=" + hours);
            Console.WriteLine("seconds=" + seconds);
        }
        public void PrintDetails(int min, int hou, int sec, int da, int tem)
        {
            Console.WriteLine("minutes=" + minutes);
            Console.WriteLine("hours=" + hours);
            Console.WriteLine("seconds=" + seconds);
            Console.WriteLine("days=" + day);
            Console.WriteLine("temperature=" + temp);
        }
    }
    class Computer
    {
        public string[] allOpenFiles;
        public bool isOn;
        public Computer(string[] files)
        {
            isOn = true;
            allOpenFiles = files;
        }
        public Computer()
        {

        }
        public void TurnOff()
        {
            for (int i = 0; i < allOpenFiles.Length; i++)
            {
                allOpenFiles[i] = null;
            }
        }
        public void TurnOff(bool turn)
        {
            bool turn2 = true;
            for (int i = 0; i < allOpenFiles.Length; i++)
            {
                if (allOpenFiles[i] == null)
                {
                    turn2 = false;
                }
            }
            if (turn || turn2)
            {
                isOn = false;
            }
        }
    }
    class SmartComp : Computer
    {
        public string[] filesInCache;

        public void TurnOff(bool turn, bool save, Computer c)
        {
            if (turn && save)
            {
                bool turn2 = true;
                for (int i = 0; i < c.allOpenFiles.Length; i++)
                {
                    if (c.allOpenFiles[i] == null)
                    {
                        turn2 = false;
                    }
                }
                if (!turn2)
                {
                    filesInCache = c.allOpenFiles;
                    c.TurnOff();
                }
            }
        }
    }
    class Vehicle
    {
        public int wheels;
        public string color;
        public bool isRoofOpen;

        public virtual void AddWheel()
        {
            if (wheels < 4)
            {
                wheels++;
            }
            Console.WriteLine("Wheels: " + wheels);
        }
        public void OpenOrCloseRoof()
        {
            isRoofOpen = !isRoofOpen;
        }
    }

    class Car : Vehicle
    {

    }
    class Motorcycle : Vehicle
    {
        public override void AddWheel()
        {
            if (wheels < 2)
            {
                wheels++;
            }
            Console.WriteLine("Wheels: " + wheels);
        }
        new public void OpenOrCloseRoof()
        {
            Console.WriteLine("Motorcycle's roof is always open");
        }
    }

    class Person
    {
        public double id;
        public string firstName, lastName;
        public virtual bool IsEqual(Person p)
        {
            if (this.id == p.id)
            {
                return true;
            }
            else return false;
        }
    }

    class Kid : Person
    {

        public override bool IsEqual(Person p)
        {
            if (this.firstName == p.firstName && this.lastName == p.lastName)
            {
                return true;
            }
            else return false;
        }
    }
}
