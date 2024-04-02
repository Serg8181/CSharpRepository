using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7._7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Curier[] curiers = new Curier[2];
            curiers[0] = new Curier("Сергей", " Иванов", "+79654322122");
            curiers[1] = new Curier("Алексей","Сидоров","+79654378753");

            CurierCompany company = new CurierCompany("СДЕК","455-76-12",curiers);
            CurierCompany company2 = new CurierCompany("ДАЙМАКС", "481-22-39", curiers);

            Product[] products = new Product[3];
            products[0] = new Computer("HP", "intel i5");
            products[1] = new Smartphone("Sumsung", "Galaxy S24");
            products[2] = new TV("Haier", 54);

            

            curiers[0].DisplayCurier();



           

            Console.ReadKey();
        }
    }

   
}

#region Curier
class Curier
{
    public string Firstname  { get; private set; }
    public string SecondName { get; private set; }
    public string PhoneNumber { get; private set; }

    public Curier(string firstname, string secondName, string phoneNumber)
    {
        Firstname = firstname;
        SecondName = secondName;
        PhoneNumber = phoneNumber;
    }
    public void DisplayCurier()
    {
        Console.WriteLine($"Курьер.\nИмя: {Firstname}\nФамилия: {SecondName}\nНомер телефона: {PhoneNumber}");
    }

}

class CurierCompany // агрегация
{
    public Curier[] couriers { get; private set; }
    public string NameCompany { get; private set; }
    public string PhoneCompany {  get; private set; }
   

    public CurierCompany(string name, string number, Curier[] courier)
    {
        NameCompany = name;
        this.couriers = courier;
        PhoneCompany = number;
    }

}
#endregion

#region Product

abstract class Product
{
    public string name;
    public abstract void ProductInfo();
    
}

class Computer : Product
{
    public string Processor { get; private set; }

    public Computer(string name , string proc) 
    {
        this.name = name;
        Processor = proc;
    }

    public override void ProductInfo()
    {
        Console.WriteLine($"Компьютер {name} с процессором {Processor}");
    }
}
class Smartphone : Product
{

   public  string NumberSeries {  get; private set; }

    public Smartphone(string name , string numberSeries)
    {
        this.name = name;
        NumberSeries = numberSeries;
    }

    public override void ProductInfo()
    {
        Console.WriteLine($"Смартфон {name} серии {NumberSeries}");
    }
}

class TV : Product
{

    public int DiagonalMonitor { get; private set; }

    public TV(string name, int diaganal)
    {
        this.name = name;
        DiagonalMonitor = diaganal;
    }
    public override void ProductInfo()
    {
        Console.WriteLine($"Телевизор {name} с диаганалью {DiagonalMonitor}");
    }
}



#endregion

#region Delivery
abstract class Delivery
{
    public string Address;
    public Product Prod;
}

class HomeDelivery : Delivery
{
    /* ... */
}

class PickPointDelivery : Delivery
{
    /* ... */
}

class ShopDelivery : Delivery
{
    /* ... */
}
#endregion

#region Order
class Order<TDelivery,TStruct> where TDelivery : Delivery
{
    public TDelivery Delivery;

    public int Number;

    public string Description;

    public void DisplayAddress()
    {
        Console.WriteLine(Delivery.Address);
    }

    // ... Другие поля
}

class OrderService
{



}
#endregion