using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ЛБ3
{
    class Program
    {
        static void SortComplete(Shop sender) // функция обратного вызова
        {
            Console.WriteLine();
            Console.WriteLine("Sorting is complete.");
            Console.WriteLine();
            sender.ShowItems();
            Console.WriteLine();
        }


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

            //обычный метод сравнения для сортировки
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Сортировка по модели:");
            Console.WriteLine();
            shop.Sort(shop.CompareByModel);
            shop.ShowItems();

            //обычный метод плюс указатель на него
            Func<Item, Item, int> compareByWeight = shop.CompareByWeight;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Сортировка по весу:");
            Console.WriteLine();
            shop.Sort(compareByWeight.Invoke);
            shop.ShowItems();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Сортировка по весу(убывание):");
            Console.WriteLine();
            shop.Sort(compareByWeight.Invoke, true);
            shop.ShowItems();

            //анонимный метод
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Сортировка по количеству отделений:");
            Console.WriteLine();
            shop.Sort(delegate (Item a, Item b) { return a.NumberOfSections - b.NumberOfSections; });
            shop.ShowItems();

            //Лямбда-выражение
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Сортировка по мощности:");
            Console.WriteLine();
            shop.Sort((a, b) => (a.Power - b.Power));
            shop.ShowItems();

            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("Сортировка по производителю:");
            //Console.WriteLine();
            //shop.Sort(shop.CompareByManufacturer);
            //shop.ShowItems();

            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("Сортировка по типу управления:");
            //Console.WriteLine();
            //shop.Sort(shop.CompareByType);
            //shop.ShowItems();
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Сортировка по мощности(убывание):");
            Console.WriteLine();
            shop.FinishedEvent += SortComplete;
            shop.SortAsync(shop.CompareByPower, true);

            //эмуляция работы в цикле пока массив сортируется
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Working... " + i);
                Thread.Sleep(200);
            }
        }
    }
}
