using System;
using System.Collections.Generic;
using System.Text;

namespace ЛБ2
{
    class Shop
    {
        private List<Item> _ArrayOfProducts;
        public List<Item> ArrayOfProducts
        {
            get { return _ArrayOfProducts; }
            set { _ArrayOfProducts = value; }
        }

        public Shop(List<Item> arrayOfProducts)
        {
            ArrayOfProducts = arrayOfProducts;
        }

        public void ShowItems() //метод ShowItems() для вывода списка всех товаров на экран
        {
            Console.WriteLine($"{"Производитель",-20} {"Модель",-30} {"Кол-во отделений",-20} {"Мощность",-10} {"Тип управления",-20} {"Вес",-10}");
            foreach (var i in ArrayOfProducts)
            {
                Console.WriteLine(i.ToString());
            }
        }

        public abstract class Sorter
        {
            //0: равны, -1: X меньше Y, 1: X болше Y
            public abstract int Compare(Item X, Item Y);
            public virtual void Sort(List<Item> list)
            {
                list.Sort(Compare);
            }
        }

        public class ManufacturerSorter : Sorter
        {
            public override int Compare(Item X, Item Y)
            {
                return String.Compare(X.Manufacturer, Y.Manufacturer);
            }
        }

        public class ModelSorter : Sorter
        {
            public override int Compare(Item X, Item Y)
            {
                return String.Compare(X.Model, Y.Model);
            }
        }

        public class NumberOfSectionsSorter : Sorter
        {
            public override int Compare(Item X, Item Y) //переопределение 
            {
                if (X.NumberOfSections == Y.NumberOfSections)
                {
                    return 0;
                }
                else
                {
                    if (X.NumberOfSections > Y.NumberOfSections)
                    {
                        return 1;
                    }
                    else
                    {
                        return -1;
                    }
                }
            }

            public override void Sort(List<Item> list)  //сортировка вставками
            {
                for (int i = 1; i < list.Count; i++)
                {
                    Item item = list[i];
                    int j = i;
                    while ((j > 0) && (Compare(item, list[j - 1]) == -1))
                    {
                        list[j] = list[j - 1];
                        j--;
                    }
                    list[j] = item;
                }
            }
        }

        public class PowerSorter : Sorter
        {
            public override int Compare(Item X, Item Y)
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
            public override void Sort(List<Item> list) //сортировка перемешиванием
            {
                int left = 0,
                right = list.Count - 1;
                while (left < right)
                {
                    for (int i = left; i < right; i++)
                    {
                        if (Compare(list[i], list[i + 1]) == 1)
                        {
                            Item temp = list[i];
                            list[i] = list[i + 1];
                            list[i + 1] = temp;
                        }
                    }
                    right--;
                    for (int i = right; i > left; i--)
                    {
                        if (Compare(list[i - 1], list[i]) == 1)
                        {
                            Item temp = list[i - 1];
                            list[i - 1] = list[i];
                            list[i] = temp;
                        }
                    }
                    left++;
                }
            }
        }

        public class TypeOfControlSorter : Sorter
        {
            public override int Compare(Item X, Item Y)
            {
                if (X.Type == Y.Type)
                {
                    return 0;
                }
                else
                {
                    if (X.Type > Y.Type)
                    {
                        return 1;
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
        }

        public class WeightSorter : Sorter
        {
            public override int Compare(Item X, Item Y) //переопределение свойства
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

            public override void Sort(List<Item> list)  // сортировка метод пузырька
            {
                Item temp;
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

        public void SortByNumberOfSections()
        {
            NumberOfSectionsSorter MemorySorter = new NumberOfSectionsSorter();
            MemorySorter.Sort(ArrayOfProducts);
        }

        public void SortByPower()
        {
            PowerSorter DisplayDiagonalSorter = new PowerSorter();
            DisplayDiagonalSorter.Sort(ArrayOfProducts);
        }

        public void SortByTypeOfControl()
        {
            TypeOfControlSorter ColorSorter = new TypeOfControlSorter();
            ColorSorter.Sort(ArrayOfProducts);
        }

        public void SortByWeight()
        {
            WeightSorter WeightSorter = new WeightSorter();
            WeightSorter.Sort(ArrayOfProducts);
        }
    }
}
