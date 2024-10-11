using System;
using System.Collections.Generic;

namespace ЛБ4
{
    class Program
    {
        static void Main(string[] args)
        {
            ToasterItem[] toaster2 =
            {
                new ToasterItem("Китай", "ProfiCook PC-TA 1194", 1500, 2.17F, 4, TypeOfControl.Электронный),
                new ToasterItem("Россия", "Moulinex Soleil LT300A30", 850, 1.3F, 2, TypeOfControl.Механический),
                new ToasterItem("Китай", "Polaris PET 0812А", 800, 1.2F, 2, TypeOfControl.Механический),
                new ToasterItem("Россия", "Tefal TT520D10", 870, 1.29F, 2, TypeOfControl.Механический),
                new ToasterItem("Китай", "Hyundai HYT-8006", 500, 0.9F, 1, TypeOfControl.Электронный),
                new ToasterItem("Китай", "CASO Classico T2", 1050, 1.5F, 1, TypeOfControl.Электронный),
                new ToasterItem("Китай", "CASO Classico T2", 750, 0.89F, 2, TypeOfControl.Механический),
                new ToasterItem("Китай", "Viatto VST-4", 2300, 2.5F, 4, TypeOfControl.Механический),
                new ToasterItem("Россия", "Philips HD2583/90", 600, 1.5F, 2, TypeOfControl.Механический),
                new ToasterItem("Китай", "Bosch TAT3A016", 980, 1.6F, 2, TypeOfControl.Механический),
                new ToasterItem("Китай", "TESLER TT-445", 1500, 2.1F, 4, TypeOfControl.Механический),
                new ToasterItem("Китай", "Bosch DesignLine TAT5P425", 750, 1.81F, 2, TypeOfControl.Механический),
                new ToasterItem("Китай", "Kitfort КТ-2048", 850, 1.3F, 2, TypeOfControl.Электронный),
                new ToasterItem("Япония", "Bosch TAT3P424", 970, 1.66F, 2, TypeOfControl.Электронный),
                new ToasterItem("Россия", "Aceline TS-2000", 750, 0.89F, 2, TypeOfControl.Электронный),
                new ToasterItem("Китай", "CASO Classico T2", 1050, 1.5F, 1, TypeOfControl.Электронный),
                new ToasterItem("Россия", "CASO Classico T2", 750, 0.89F, 2, TypeOfControl.Электронный),
                new ToasterItem("Россия", "Viatto VST-4", 2300, 2.5F, 4, TypeOfControl.Механический),
                new ToasterItem("Китай", "Classico T2", 750, 0.89F, 2, TypeOfControl.Механический)
            };
            Console.WriteLine("Исходный массив:");
            Console.WriteLine();
            Console.WriteLine($"{"Производитель",-20} {"Тип управления",-20} {"Кол-во отделений",-20} {"Мощность",-10} {"Вес",-10} {"Модель",-30}");
            foreach (var i in toaster2)
            {
                Console.WriteLine(i.ToString());
            }
            Console.WriteLine();

            Console.WriteLine("Отсортированный массив:");
            Console.WriteLine();
            Array.Sort(toaster2);
            Console.WriteLine($"{"Производитель",-20} {"Тип управления",-20} {"Кол-во отделений",-20} {"Мощность",-10} {"Вес",-10} {"Модель",-30}");
            foreach (var i in toaster2)
            {
                Console.WriteLine(i.ToString());
            }


            //List<IItem> toaster = new List<IItem>()
            //{
            //    new PhoneItem("Samsung", "Samsung Galaxy A52", 750, 0.189F),
            //    new ToasterItem("Китай", "ProfiCook PC-TA 1194", 1500, 2.17F, 4, TypeOfControl.Электронный),
            //    new ToasterItem("Китай", "Moulinex Soleil LT300A30", 850, 1.3F, 2, TypeOfControl.Механический),
            //    new ToasterItem("Китай", "Polaris PET 0812А", 800, 1.2F, 2, TypeOfControl.Механический),
            //    new ToasterItem("Китай", "Tefal TT520D10", 870, 1.29F, 2, TypeOfControl.Механический),
            //    new ToasterItem("Китай", "Hyundai HYT-8006", 500, 0.9F, 1, TypeOfControl.Электронный),
            //    new ToasterItem("Китай", "CASO Classico T2", 1050, 1.5F, 1, TypeOfControl.Электронный),
            //    new ToasterItem("Китай", "Viatto VST-4", 2300, 2.5F, 4, TypeOfControl.Механический),
            //    new ToasterItem("Китай", "Philips HD2583/90", 600, 1.5F, 2, TypeOfControl.Механический),
            //    new ToasterItem("Китай", "Bosch TAT3A016", 980, 1.6F, 2, TypeOfControl.Механический),
            //    new ToasterItem("Китай", "TESLER TT-445", 1500, 2.1F, 4, TypeOfControl.Механический),
            //    new ToasterItem("Китай", "Bosch DesignLine TAT5P425", 970, 1.81F, 2, TypeOfControl.Механический),
            //    new ToasterItem("Китай", "Kitfort КТ-2048", 850, 1.3F, 2, TypeOfControl.Электронный),
            //    new ToasterItem("Китай", "Bosch TAT3P424", 970, 1.66F, 2, TypeOfControl.Механический),
            //    new ToasterItem("Китай", "Aceline TS-2000", 750, 0.89F, 2, TypeOfControl.Механический)
            //};

            //ItemBase a1 = new PhoneItem("Samsung", "Samsung Galaxy A52", 750, 0.189F);
            //Console.WriteLine($"{"Производитель",-20} {"Модель",-30} {"Мощность",-10} {"Вес",-10}");
            //Console.WriteLine(a1.ToString());

            //Console.WriteLine();
            //Console.WriteLine("/////////////////////////////////////");
            //Console.WriteLine();

            //ItemBase b1 = new ToasterItem("Китай", "Bosch TAT3A016", 980, 1.6F, 2, TypeOfControl.Механический);
            //Console.WriteLine($"{"Производитель",-20} {"Модель",-30} {"Мощность",-10} {"Вес",-10} {"Кол-во отделений",-20} {"Тип управления",-20}");
            //Console.WriteLine(b1.ToString());

            //Console.WriteLine();
            //Console.WriteLine("/////////////////////////////////////");
            //Console.WriteLine();

            ////IShop shop = new Shop(toaster);
            ////Console.WriteLine("Исходный список товаров в магазине:");
            ////Console.WriteLine();
            ////shop.ShowItems();

            ////Console.WriteLine();
            ////Console.WriteLine("/////////////////////////////////////");
            ////Console.WriteLine();

            //Shop shop2 = new Shop();
            //shop2.AddItem(toaster);

            //IWarehouse warehouse = new Warehouse();
            //Console.WriteLine("Исходный склад:");
            //Console.WriteLine();
            //warehouse.GetItems();
            //Console.WriteLine();
            //Console.WriteLine("Измененный склад (добавлено 2 товара):");
            //Console.WriteLine();
            //List<IItem> t = new List<IItem>()
            //{ (new ToasterItem("Китай", "Hyundai HYT-8006", 500, 0.9F, 1, TypeOfControl.Электронный))};
            //List<IItem> t2 = new List<IItem>()
            //{ (new PhoneItem("Samsung", "Samsung Galaxy A52", 750, 0.189F))};
            //warehouse.AddItem(t);
            //warehouse.AddItem(t2);
            //warehouse.GetItems();
            //Console.WriteLine();
            //Console.WriteLine("Измененный склад (удален товар с индексом 1):");
            //Console.WriteLine();
            //warehouse.RemoveItem(1);
            //warehouse.GetItems();
            //Console.WriteLine();
            //Console.WriteLine("Измененный склад (добавлен большой список товаров):");
            //Console.WriteLine();
            //warehouse.AddItem(toaster);
            //warehouse.GetItems();

            //Console.WriteLine();
            //Console.WriteLine("/////////////////////////////////////");
            //Console.WriteLine();

            //IShop shop1 = new Shop();
            //Console.WriteLine("Исходный магазин:");
            //Console.WriteLine();
            //shop1.GetItems();
            //Console.WriteLine();
            //Console.WriteLine("Измененный магазин (добавлено 2 товара):");
            //Console.WriteLine();
            //shop1.AddItem(t);
            //shop1.AddItem(t2);
            //shop1.GetItems();
            //Console.WriteLine();
            //Console.WriteLine("Измененный магазин (удален товар с индексом 2):");
            //Console.WriteLine();
            //shop1.RemoveItem(2);
            //shop1.GetItems();
            //Console.WriteLine();
            //Console.WriteLine("Измененный магазин (добавлен большой список товаров):");
            //Console.WriteLine();
            //shop1.AddItem(toaster);
            //shop1.GetItems();

            //Console.WriteLine();
            //Console.WriteLine("/////////////////////////////////////");
            //Console.WriteLine();

            //ToasterItem c1 = new ToasterItem("Китай", "Bosch TAT3A016", 980, 1.6F, 2, TypeOfControl.Механический);
            //ToasterItem c3 = c1;
            //Console.WriteLine("Проверка работы создания копии простым приравниванием:");
            //Console.WriteLine();
            //Console.WriteLine("Объект исходный:");
            //Console.WriteLine(c1.ToString());
            //Console.WriteLine("Копия объекта:");
            //Console.WriteLine(c3.ToString());
            //c3.Model = "Samsung";
            //Console.WriteLine("Объект исходный изменен?:");
            //Console.WriteLine(c1.ToString());
            //Console.WriteLine("Копия объекта изменен?:");
            //Console.WriteLine(c3.ToString());

            //Console.WriteLine();
            //Console.WriteLine("Проверка работы интерфейса ICloneable (создания копии):");
            //Console.WriteLine();
            //c1 = new ToasterItem("Китай", "Bosch TAT3A016", 980, 1.6F, 2, TypeOfControl.Механический);
            //ToasterItem c2 = c1.Clone() as ToasterItem;
            //Console.WriteLine("Объект исходный:");
            //Console.WriteLine(c1.ToString());
            //Console.WriteLine("Копия объекта:");
            //Console.WriteLine(c2.ToString());
            //c2.Model = "Samsung";
            //Console.WriteLine("Объект исходный изменен?:");
            //Console.WriteLine(c1.ToString());
            //Console.WriteLine("Копия объекта изменен?:");
            //Console.WriteLine(c2.ToString());

            //Console.WriteLine();
            //Console.WriteLine("/////////////////////////////////////");
            //Console.WriteLine();

            //ToasterItem[] toaster2 =
            //{
            //    new ToasterItem("Китай", "ProfiCook PC-TA 1194", 1500, 2.17F, 4, TypeOfControl.Электронный),
            //    new ToasterItem("Китай", "Moulinex Soleil LT300A30", 850, 1.3F, 2, TypeOfControl.Механический),
            //    new ToasterItem("Китай", "Polaris PET 0812А", 800, 1.2F, 2, TypeOfControl.Механический),
            //    new ToasterItem("Китай", "Tefal TT520D10", 870, 1.29F, 2, TypeOfControl.Механический),
            //    new ToasterItem("Китай", "Hyundai HYT-8006", 500, 0.9F, 1, TypeOfControl.Электронный),
            //    new ToasterItem("Китай", "CASO Classico T2", 1050, 1.5F, 1, TypeOfControl.Электронный),
            //    new ToasterItem("Китай", "Viatto VST-4", 2300, 2.5F, 4, TypeOfControl.Механический),
            //    new ToasterItem("Китай", "Philips HD2583/90", 600, 1.5F, 2, TypeOfControl.Механический),
            //    new ToasterItem("Китай", "Bosch TAT3A016", 980, 1.6F, 2, TypeOfControl.Механический),
            //    new ToasterItem("Китай", "TESLER TT-445", 1500, 2.1F, 4, TypeOfControl.Механический),
            //    new ToasterItem("Китай", "Bosch DesignLine TAT5P425", 970, 1.81F, 2, TypeOfControl.Механический),
            //    new ToasterItem("Китай", "Kitfort КТ-2048", 850, 1.3F, 2, TypeOfControl.Электронный),
            //    new ToasterItem("Китай", "Bosch TAT3P424", 970, 1.66F, 2, TypeOfControl.Механический),
            //    new ToasterItem("Китай", "Aceline TS-2000", 750, 0.89F, 2, TypeOfControl.Механический)
            //};
            //Console.WriteLine("Проверка работы интерфейса IComparable (сравнение по модели):");
            //Console.WriteLine();
            //Console.WriteLine($"{"Производитель",-20} {"Модель",-30} {"Мощность",-10} {"Вес",-10} {"Кол-во отделений",-20} {"Тип управления",-20}");
            //foreach (var i in toaster2)
            //{
            //    Console.WriteLine(i.ToString());
            //}
            //Console.WriteLine();

            ////использует встроенный метод сортировки, который использует интерфейс IComparable,
            ////сравнивающий объекты по определенным критериям
            ////Для реализации этого интерфейса в классе товара реализуется метод CompareTo() по Model
            //Array.Sort(toaster2);
            //Console.WriteLine($"{"Производитель",-20} {"Модель",-30} {"Мощность",-10} {"Вес",-10} {"Кол-во отделений",-20} {"Тип управления",-20}");
            //foreach (var i in toaster2)
            //{
            //    Console.WriteLine(i.ToString());
            //}

            //Console.WriteLine();
            //Console.WriteLine("/////////////////////////////////////");
            //Console.WriteLine();

            //Console.WriteLine("Проверка работы интерфейса IEnumerable<IItem>:");
            //// перебор элементов коллекции
            //foreach (var item in shop2)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine();
            //Console.WriteLine("/////////////////////////////////////");
            //Console.WriteLine();

            //Console.WriteLine("Проверка работы интерфейса IList(перебор списка):");

            //Warehouse warehouse1 = new Warehouse();
            //warehouse1.AddItem(toaster);

            //// перебор элементов коллекции
            //foreach (var item in warehouse1)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();

            //Console.WriteLine("размер коллекции:");
            //Console.WriteLine(warehouse1.Count);

            //IItem a11 = toaster[1];
            //Console.WriteLine("существует ли объект в коллекции и возвращает индекс:");
            //Console.WriteLine(warehouse1.IndexOf(a11));

            //Console.WriteLine("добавление нового элемента в коллекцию с указанием индекса - 0:");
            //warehouse1.Insert(0, new ToasterItem("Китай", "ProfiCook PC-TA 1194", 1500, 2.17F, 4, TypeOfControl.Электронный));
            //foreach (var item in warehouse1)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();

            //Console.WriteLine("удаление элемента из коллекции используя индекс - 0:");
            //warehouse1.RemoveAt(0);
            //foreach (var item in warehouse1)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();

            //Console.WriteLine("добаление нового объекта в коллекцию:");
            //warehouse1.Add(new ToasterItem("Китай", "ProfiCook PC-TA 1194", 1500, 2.17F, 4, TypeOfControl.Электронный));
            //foreach (var item in warehouse1)
            //{
            //    Console.WriteLine(item);
            //}

            //IItem a12 = toaster[5];
            //Console.WriteLine("существует ли объект в коллекции:");
            //Console.WriteLine(warehouse1.Contains(a12));

            //Console.WriteLine("доступна ли коллекция только для чтения:");
            //Console.WriteLine(warehouse1.IsReadOnly);

            //Console.WriteLine("удаляет объект из коллекции используя сам объект:");
            //warehouse1.Remove(toaster[0]);
            //foreach (var item in warehouse1)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();

            //Console.WriteLine("очистка коллекции:");
            //warehouse1.Clear();
            //foreach (var item in warehouse1)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();
            //Console.WriteLine("/////////////////////////////////////");
            //Console.WriteLine();

            ////Console.WriteLine();
            ////Console.WriteLine("Сортировка по весу:");
            ////Console.WriteLine();
            ////shop1.SortByWeight();
            ////shop1.ShowItems();
            ////Console.WriteLine();
            ////Console.WriteLine("Сортировка по мощности:");
            ////Console.WriteLine();
            ////shop1.SortByPower();
            ////shop1.ShowItems();
            ////Console.WriteLine();
            ////Console.WriteLine("Сортировка по модели:");
            ////Console.WriteLine();
            ////shop1.SortByModel();
            ////shop1.ShowItems();
            ////Console.WriteLine();
            ////Console.WriteLine("Сортировка по производителю:");
            ////Console.WriteLine();
            ////shop1.SortByManufacturer();
            ////shop1.ShowItems();
        }
    }
}
