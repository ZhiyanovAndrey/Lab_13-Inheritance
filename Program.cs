using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13_Inheritance
{
    /*Задан класс Building, который описывает здание. Класс содержит следующие элементы:

     адрес здания;
     длина здания;
     ширина здания;
     высота здания.

 В классе Building нужно реализовать следующие методы:

 конструктор с 4 параметрами;
 свойства get/set для доступа к полям класса;
 метод Print(), который выводит информацию о здании.

 Разработать класс MultiBuilding, который наследует возможности класса Building и добавляет поле этажность. 
 В классе MultiBuilding реализовать следующие элементы:

 конструктор с 5 параметрами – реализует вызов конструктора базового класса;
 свойство get/set доступа к внутреннему полю класса;
 метод Print(), который обращается к методу Print() базового класса Building для вывода информации 
 о всех полях класса.

 Класс MultiBuilding сделать таким, что не может быть унаследован.*/
 
    class Building
    {

        string Adress { get; set; }
        int length;
        int width;
        int height;

        public int Length
        {
            set
            {
                if (value > 0 && value < 1000) length = value;
                else Console.WriteLine("Высота здания вне диапазона от 0 до 1000 м");
            }
            get { return length; }
        }
        public int Width
        {
            set
            {
                if (value > 0 && value < 1000) width = value;
                else Console.WriteLine("Ширина здания вне диапазона от 0 до 1000 м");
            }
            get { return width; }
        }
        public int Heigth
        {
            set
            {
                if (value > 0 && value < 1000) height = value;
                else Console.WriteLine("Высота здания вне диапазона от 0 до 1000 м");
            }
            get { return height; }
        }
        public void Print()
        {
            Console.WriteLine("Здание по адресу {0} имеет:\nдлину {1} м. \nширину {2} м. \nвысоту {3} м.", Adress, Length, Width, Heigth);
        }

        
        public Building(int length, int width, int heigth, string adress) //Параметризированный конструктор для классса.
        {
            Adress = adress;
            Length = length;
            Width = width;
            Heigth = heigth;
        }
        sealed class MultiBuilding : Building
        {
            int floor; //Дополнительные поля для дочернего классса.

            public MultiBuilding(int length, int width, int heigth, string adress, int floor) //Параметризированный конструктор для дочернего классса.
              : base(length, width, heigth, adress)
            {
                Floor = floor;
            }
            public int Floor
            {
                get { return floor; }
                set
                {
                    if (value > 0 && value < 100) floor = value;
                    else Console.WriteLine("Число этажей вне диапазона от 0 до 100");
                }
            }

            public void Print()
            {
                base.Print();
                Console.Write("число этажей {0}", Floor);
            }
              

        }

        class Program
        {
            static void Main(string[] args)
            {

                Console.WriteLine("Введите дллину здания");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите ширину здания");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите высоту здания");
                int c = Convert.ToInt32(Console.ReadLine());
                string d = "175212, Пензенская область, город Подольск, пер. Косиора, 28";
                Console.WriteLine("Введите количество этажей");
                int e = Convert.ToInt32(Console.ReadLine());
                MultiBuilding building = new MultiBuilding(a, b, c, d, e);
                building.Print();


                Console.ReadKey();
            }
        }
    }
}
