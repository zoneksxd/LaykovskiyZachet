using System;
using System.Collections.Generic;

public class Address
{
    public string Index { get; set; }    
    public string City { get; set; }     
    public string Street { get; set; }   
    public string House { get; set; }    
    public string Building { get; set; } 
    public string Apartment { get; set; }

    
    public Address(string index, string city, string street, string house, string building, string apartment)
    {
        Index = index;
        City = city;
        Street = street;
        House = house;
        Building = building;
        Apartment = apartment;
    }

    public override string ToString()
    {
        return $"{City}, {Street}, {House}, {Building} {Apartment}, {Index}";
    }

    public string GetAddressString()
    {
        return $"{City}, {Street}, {House}, {Building} {Apartment}, {Index}";
    }
}

public class PostOffice
{
    public string Name { get; set; }    
    public Address RecipientAddress { get; set; } 
    public string Message { get; set; }

    public PostOffice(string name, Address recipientAddress, string message)
    {
        Name = name;
        RecipientAddress = recipientAddress;
        Message = message;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Почтовое отделение: {Name}");
        Console.WriteLine($"Адрес получателя: {RecipientAddress.GetAddressString()}");
        Console.WriteLine($"Сообщение: {Message}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<PostOffice> postOffices = new List<PostOffice>();
        
        //Это выводиться как пример если что
        Address recipientAddress = new Address("123456", "Москва", "Тверская", "15", "1", "23");

        PostOffice postOffice = new PostOffice("Центральное отделение", recipientAddress, "Здравствуйте, это ваше уведомление!");

        postOffices.Add(postOffice);

        postOffice.DisplayInfo();

        Console.WriteLine("\nВведите данные для почтового отделения:");

        Console.Write("Название почтового отделения: ");
        string name = Console.ReadLine();

        Console.Write("Почтовый индекс: ");
        string index = Console.ReadLine();

        Console.Write("Город: ");
        string city = Console.ReadLine();

        Console.Write("Улица: ");
        string street = Console.ReadLine();

        Console.Write("Дом: ");
        string house = Console.ReadLine();

        Console.Write("Корпус: ");
        string building = Console.ReadLine();

        Console.Write("Квартира: ");
        string apartment = Console.ReadLine();

        Console.Write("Сообщение: ");
        string message = Console.ReadLine();

        Address userAddress = new Address(index, city, street, house, building, apartment);
        PostOffice userPostOffice = new PostOffice(name, userAddress, message);

        postOffices.Add(userPostOffice);

        Console.WriteLine("\nИнформация о всех почтовых отделениях:");

        foreach (var office in postOffices)
        {
            office.DisplayInfo();
            Console.WriteLine();
        }

    }
}
