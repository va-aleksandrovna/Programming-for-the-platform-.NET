using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ЛБ3
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

        public delegate void Finished(Shop sender); //делегат для функции обратного вызова

        public event Finished FinishedEvent; //событие

        public delegate int Compare(Item a, Item b); //делегат для функций сравнения

        public delegate void SortDelegate(Compare compare, bool Descending = false); // делегат для метода Sort

        public void Sort(Compare compare, bool Descending = false) //метод сортировки
        {
            Thread.Sleep(500);
            int left = 0;
            int right = ArrayOfProducts.Count - 1;
            QuickSort(left, right, compare);

            if (Descending)
            {
                ArrayOfProducts.Reverse();
            }
            
            if (FinishedEvent != null) // проверяем, что подписчики имеются
            {
                FinishedEvent(this); // вызываем событие
            }
        }

        public void SortAsync(Compare compare, bool Descending = false)
        {
            SortDelegate sort = new SortDelegate(Sort);

            //sortMethod.BeginInvoke(compare, Descending, SortComplete, null); // вызываем основной метод с помощью делегата
            Task task = Task.Run(() => sort(compare, Descending));
        }

        private void QuickSort(int left, int right, Compare compare)//быстрая сортировка
        {
            if (left >= right)
            {
                return;
            }

            Item pivot = ArrayOfProducts[(left + right) / 2];

            int i = left;
            int j = right;

            while (i <= j)
            {
                while (compare(ArrayOfProducts[i], pivot) < 0)
                {
                    i++;
                }

                while (compare(ArrayOfProducts[j], pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    Item tmp = ArrayOfProducts[i];
                    ArrayOfProducts[i] = ArrayOfProducts[j];
                    ArrayOfProducts[j] = tmp;

                    i++;
                    j--;
                }
            }

            if (left < j)
            {
                QuickSort(left, j, compare);
            }

            if (right > i)
            {
                QuickSort(i, right, compare);
            }
        }

        public int CompareByManufacturer(Item X, Item Y)
        {
            return String.Compare(X.Manufacturer, Y.Manufacturer);
        }

        public int CompareByModel(Item X, Item Y)
        {
            return String.Compare(X.Model, Y.Model);
        }

        public int CompareByNumberOfSections(Item X, Item Y) 
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

        public int CompareByPower(Item X, Item Y)
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

        public int CompareByType(Item X, Item Y)
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

        public int CompareByWeight(Item X, Item Y)
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
    }
}
