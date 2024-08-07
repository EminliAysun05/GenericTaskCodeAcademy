﻿

namespace GenericTaskCodeAcademy.Exceptions;

public abstract class Product
{
    private static int _id;
    public int Id { get;}

    public string Name { get; set; }
    public decimal Price { get; set; }

    public int Count { get; set; }

    public decimal TotalInCome { get; set; }

    protected Product(string name, decimal price)
    {
        Name = name;
        Price= price;
        Id = ++_id;
    }

    public abstract void Sell();

    public abstract void ShowInfo();

}
