using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork4
{
    /*
    Реализовать не менее пяти закрытых полей (различных типов), 
    представляющих основные характеристики рассматриваемого класса*/
    public partial class Characteristic
    {
        public string CharacteresticInfo()
        {
            return String.Format("View: {0}\nWeight: {1}\nHeight: {2}\nWidth: {3}\nType: {4}\nCaliber: {5}");
        }
        public void CharacteresticInfo(out string[] info)
        {
            int size = 6;
            info = new string[size];
            info[1] = "View: ";
            info[2] = "Weight: ";
            info[3] = "Height: ";
            info[4] = "Width: ";
            info[5] = "Type: ";
            info[6] = "Caliber: ";
        }
    }
    /* Создать не менее трех методов управления классом и методы доступа к его закрытым полям*/
    static void Main(string[] args)
    {
        Caliber[] calibers = new Caliber[5];

        calibers[0] = new Caliber(45, "20 K");
        calibers[1] = new Caliber(76, "L 11");
        calibers[2] = new Caliber(122, "D-25T");
        calibers[3] = new Caliber(152, "M-10T");
        calibers[4] = new Caliber(57, "Zis-4M");

        for (int i = 0; i < calibers.Length; i++)
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("[" + i + "]\n" + calibers[i].PaperInfo());
            Console.WriteLine("-----------------------------------");
        }
        Console.ReadLine();
    }
    /*Создать метод, в который передаются аргументы по ссылке*/
    static void Main(string[] args)
    {
        int result = Size(3, 2,5);
        Console.WriteLine(result);  

        Console.ReadKey();
    }
    static int Size(int x, int y)
    {
        return x + y;
    }
}
/*
 Создать не менее двух статических полей (различных типов), 
 представляющих общие характеристики объектов данного класса*/
class Account
{
    public static decimal penetration = 115;
    public decimal totalRange;
    public Account(decimal range)
    {
        totalRange = range + penetration;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Account.penetration);      
        Account.penetration += 125;

        Account account1 = new Account(107);
        Console.WriteLine(account1.totalRange);   


        Account account2 = new Account(1000);
        Console.WriteLine(account2.totalRange);   

        Console.ReadKey();
    }
}
/*
 Обязательным требованием является реализация нескольких перегруженных конструкторов, 
 аргументы которых определяются студентом, 
 исходя из специфики реализуемого класса, а так же реализация конструктора по умолчанию*/
class Size
{
    public string height; 
    public int width;     

    public void GetInfo()
    {
        Console.WriteLine($"Высота: {height}  ширина: {width}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Size meter = new Size();
        meter.GetInfo();     

        meter.height = "3";
        meter.width = 2,5;
        meter.GetInfo(); 
        Console.ReadKey();
    }
}
class Size
{
    public string height;
    public int width;

    public Size() { height = "3"; width = 2,5; }    

    public Size(string n) { height = n; width = 2,5; }         

    public Size(string n, int a) { height = n; width = a; }   

    public void GetInfo()
    {
        Console.WriteLine($"Высота: {height}  ширина: {width}");
    }
}
/*Создать статический конструктор*/
class Type
{
    static Type()
    {
        Console.WriteLine("Создан первый тип");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Type type1 = new Type(); 
        Type type2 = new Type();
        Console.Read();
    }
}
/*Создать массив (не менее 5 элементов) объектов созданного класса*/
class Program
{
    static void Main(string[] args)
    {
        int[] myArr = new int[5];
                
        myArr[0] = 4;
        myArr[1] = 56;
        myArr[2] = 3;
        myArr[3] = 2;
        myArr[4] = 128;

        foreach (int i in myArr)
            Console.WriteLine(i);
        Console.ReadLine();
    }
}
/*Создать дополнительный метод для данного класса в другом файле, используя ключевое слово partial*/
partial class Plane
{
    public Plane(int civilian, int military)
    {
        Plane = civilian;
        Plane = military;
    }
    partial void Show();
}
partial class Plane
{
    public int Plane { get; set; }
    partial void Show()
    {
        Console.WriteLine("{0}, {1}", Plane);
    }
}
partial class Plane
{
    public int Plane { get; set; }
    public void ShowPlane()
    {
        Show();
    }
}
class Appointment
{
    static void Main()
    {
        Plane plane = new Plane(1, 2);
        plane.ShowPlane();
    }
}
