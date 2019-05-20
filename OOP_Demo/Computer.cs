using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Demo
{
    public class Computer
    {
        //fields - gemmer værdier om objektets 'state'
        public double price;
        public string manufacturer;
        public string color;
        public string serialNumber;

        //Constructor
        public Computer(double price, string manufacturer, string color, string serialNumber)
        {
            this.price = price;
            this.manufacturer = manufacturer;
            this.color = color;
            this.serialNumber = serialNumber;
        }

        public void WriteInfo()
        {
            Console.WriteLine($"Computeren koster {price} kroner, den er lavet af {manufacturer}, har farven {color} og serienummeret {serialNumber}");
        }

        public void GoOnSale()
        {
            price = price * 0.9;
        }
    }
}
