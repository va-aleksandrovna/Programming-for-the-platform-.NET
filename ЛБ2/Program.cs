using System;
using System.Collections.Generic;

namespace ЛБ2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> toaster = new List<Item>()
            {
                new Item("Китай", "Redmond RT-437", 2, 750, Item.TypeOfControl.Механический, 1.5F),
                new Item("Китай", "ProfiCook PC-TA 1194", 4, 1500, Item.TypeOfControl.Электронный, 2.17F),
                new Item("Китай", "Moulinex Soleil LT300A30", 2, 850, Item.TypeOfControl.Механический, 1.3F),
                new Item("Китай", "Polaris PET 0812А", 2, 800, Item.TypeOfControl.Механический, 1.2F),
                new Item("Китай", "Tefal TT520D10", 2, 870, Item.TypeOfControl.Механический, 1.29F),
                new Item("Китай", "Hyundai HYT-8006", 1, 500, Item.TypeOfControl.Электронный, 0.9F),
                new Item("Китай", "CASO Classico T2", 1, 1050, Item.TypeOfControl.Электронный, 1.5F),
                new Item("Китай", "Viatto VST-4", 4, 2300, Item.TypeOfControl.Механический, 2.5F),
                new Item("Китай", "Philips HD2583/90", 2, 600, Item.TypeOfControl.Механический, 1.5F),
                new Item("Китай", "Bosch TAT3A016", 2, 980, Item.TypeOfControl.Механический, 1.6F),
                new Item("Китай", "TESLER TT-445", 4, 1500, Item.TypeOfControl.Механический, 2.1F),
                new Item("Китай", "Bosch DesignLine TAT5P425", 2, 970, Item.TypeOfControl.Механический, 1.81F),
                new Item("Китай", "Kitfort КТ-2048", 2, 850, Item.TypeOfControl.Электронный, 1.3F),
                new Item("Китай", "Bosch TAT3P424", 2, 970, Item.TypeOfControl.Механический, 1.66F),
                new Item("Китай", "Aceline TS-2000", 2, 750, Item.TypeOfControl.Механический, 0.89F)
            };

            Shop shop = new Shop(toaster);
            Console.WriteLine("Исходный список:");
            Console.WriteLine();
            shop.ShowItems();
            Console.WriteLine();
            Console.WriteLine("Сортировка по весу:");
            Console.WriteLine();
            shop.SortByWeight();
            shop.ShowItems();
            Console.WriteLine();
            Console.WriteLine("Сортировка по количеству отделений:");
            Console.WriteLine();
            shop.SortByNumberOfSections();
            shop.ShowItems();
            Console.WriteLine();
            Console.WriteLine("Сортировка по мощности:");
            Console.WriteLine();
            shop.SortByPower();
            shop.ShowItems();
            Console.WriteLine();
            Console.WriteLine("Сортировка по модели:");
            Console.WriteLine();
            shop.SortByModel();
            shop.ShowItems();
            Console.WriteLine();
            Console.WriteLine("Сортировка по производителю:");
            Console.WriteLine();
            shop.SortByManufacturer();
            shop.ShowItems();
            Console.WriteLine();
            Console.WriteLine("Сортировка по типу управления:");
            Console.WriteLine();
            shop.SortByTypeOfControl();
            shop.ShowItems();
        }
    }
}
