using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ЛБ4
{
    class Shop: IShop, IEnumerable<IItem>
    {
        private List<IItem> _ArrayOfProducts = new List<IItem>();

        private Dictionary<int, IItem> items = new Dictionary<int, IItem>(); //словарь для хранения товаров
        private int nextItemId = 1; //уникальный идентификатор

        public List<IItem> ArrayOfProducts
        {
            get { return _ArrayOfProducts; }
            set { _ArrayOfProducts = value; }
        }

        public Shop()
        {

        }

        public Shop(List<IItem> arrayOfProducts)
        {
            ArrayOfProducts = arrayOfProducts;
        }

        public void ShowItems() //метод ShowItems() для вывода списка всех товаров на экран
        {
            Console.WriteLine($"{"Производитель",-20} {"Модель",-30} {"Мощность",-10} {"Вес",-10} {"Кол-во отделений",-20} {"Тип управления",-20}");
            foreach (var i in ArrayOfProducts)
            {
                Console.WriteLine(i.ToString());
            }
        }

        //поступление товара
        public void AddItem(List<IItem> item)
        {
            foreach (var i in item)
            {
                _ArrayOfProducts.Add(i);
                int itemId = nextItemId;
                items.Add(itemId, i);
                nextItemId++;
            }
        }

        //получение списка товаров в магазине
        public void GetItems()
        {
            if (items.Count == 0)
            {
                Console.WriteLine("Нет товаров в магазине!!!");
            }
            else
            {
                Console.WriteLine($"{"ID",-5} {"Производитель",-20} {"Модель",-30} {"Мощность",-10} {"Вес",-10}");
                foreach (var pair in items)
                {
                    Console.WriteLine("{0}     {1}", pair.Key, pair.Value);
                }
            }
        }

        //удаление товара
        public void RemoveItem(int itemId)
        {
            IItem a = items[itemId];
            items.Remove(itemId);
            _ArrayOfProducts.Remove(a);
        }

        public abstract class Sorter
        {
            //0: равны, -1: X меньше Y, 1: X болше Y
            public abstract int Compare(IItem X, IItem Y);
            public virtual void Sort(List<IItem> list)
            {
                list.Sort(Compare);
            }
        }

        public class ManufacturerSorter : Sorter
        {
            public override int Compare(IItem X, IItem Y)
            {
                return String.Compare(X.Manufacturer, Y.Manufacturer);
            }
        }

        public class ModelSorter : Sorter
        {
            public override int Compare(IItem X, IItem Y)
            {
                return String.Compare(X.Model, Y.Model);
            }
        }

        //public class NumberOfSectionsSorter : Sorter
        //{
        //    public override int Compare(IItem X, IItem Y) //переопределение 
        //    {
        //        if (X.NumberOfSections == Y.NumberOfSections)
        //        {
        //            return 0;
        //        }
        //        else
        //        {
        //            if (X.NumberOfSections > Y.NumberOfSections)
        //            {
        //                return 1;
        //            }
        //            else
        //            {
        //                return -1;
        //            }
        //        }
        //    }

        //    public override void Sort(List<Item> list)  //сортировка вставками
        //    {
        //        for (int i = 1; i < list.Count; i++)
        //        {
        //            Item item = list[i];
        //            int j = i;
        //            while ((j > 0) && (Compare(item, list[j - 1]) == -1))
        //            {
        //                list[j] = list[j - 1];
        //                j--;
        //            }
        //            list[j] = item;
        //        }
        //    }
        //}

        public class PowerSorter : Sorter
        {
            public override int Compare(IItem X, IItem Y)
            {
                if (X.Power == Y.Power)
                {
                    return 0;
                }
                else
                {
                    if (X.Power > Y.Power)
                    {
                        return 1;
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
            public override void Sort(List<IItem> list) //сортировка перемешиванием
            {
                int left = 0,
                right = list.Count - 1;
                while (left < right)
                {
                    for (int i = left; i < right; i++)
                    {
                        if (Compare(list[i], list[i + 1]) == 1)
                        {
                            IItem temp = list[i];
                            list[i] = list[i + 1];
                            list[i + 1] = temp;
                        }
                    }
                    right--;
                    for (int i = right; i > left; i--)
                    {
                        if (Compare(list[i - 1], list[i]) == 1)
                        {
                            IItem temp = list[i - 1];
                            list[i - 1] = list[i];
                            list[i] = temp;
                        }
                    }
                    left++;
                }
            }
        }

        //public class TypeOfControlSorter : Sorter
        //{
        //    public override int Compare(IItem X, IItem Y)
        //    {
        //        if (X.Type == Y.Type)
        //        {
        //            return 0;
        //        }
        //        else
        //        {
        //            if (X.Type > Y.Type)
        //            {
        //                return 1;
        //            }
        //            else
        //            {
        //                return -1;
        //            }
        //        }
        //    }
        //}

        public class WeightSorter : Sorter
        {
            public override int Compare(IItem X, IItem Y) //переопределение свойства
            {
                if (X.Weight == Y.Weight)
                {
                    return 0;
                }
                else
                {
                    if (X.Weight > Y.Weight)
                    {
                        return 1;
                    }
                    else
                    {
                        return -1;
                    }
                }
            }

            public override void Sort(List<IItem> list)  // сортировка метод пузырька
            {
                IItem temp;
                for (int i = 0; i < list.Count; i++)
                {
                    for (int j = i + 1; j < list.Count; j++)
                    {
                        int k = Compare(list[i], list[j]);
                        if (k == 1)
                        {
                            temp = list[i];
                            list[i] = list[j];
                            list[j] = temp;
                        }
                    }
                }
            }
        }


        public void SortByManufacturer()
        {
            ManufacturerSorter ManufacturerSorter = new ManufacturerSorter();
            ManufacturerSorter.Sort(ArrayOfProducts);
        }

        public void SortByModel()
        {
            ModelSorter ModelSorter = new ModelSorter();
            ModelSorter.Sort(ArrayOfProducts);
        }

        //public void SortByNumberOfSections()
        //{
        //    NumberOfSectionsSorter MemorySorter = new NumberOfSectionsSorter();
        //    MemorySorter.Sort(ArrayOfProducts);
        //}

        public void SortByPower()
        {
            PowerSorter DisplayDiagonalSorter = new PowerSorter();
            DisplayDiagonalSorter.Sort(ArrayOfProducts);
        }

        //public void SortByTypeOfControl()
        //{
        //    TypeOfControlSorter ColorSorter = new TypeOfControlSorter();
        //    ColorSorter.Sort(ArrayOfProducts);
        //}

        public void SortByWeight()
        {
            WeightSorter WeightSorter = new WeightSorter();
            WeightSorter.Sort(ArrayOfProducts);
        }


        //Интерфейс IEnumerable определяет
        //метод GetEnumerator, который будет возвращать объект типа IEnumerator
        //для перебора элементов коллекции
        //интерфейс IEnumerator позволяет перебирать элементы коллекции с помощью цикла foreach
        public IEnumerator<IItem> GetEnumerator()
        {
            return ArrayOfProducts.GetEnumerator();
        }
                    
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

