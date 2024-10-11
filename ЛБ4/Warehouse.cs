using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛБ4
{
    class Warehouse : IWarehouse, IList<IItem>
    {
        private List<IItem> items = new List<IItem>();

        private Dictionary<int, IItem> tems = new Dictionary<int, IItem>(); //словарь для хранения товаров
        private int nextItemId = 1; //уникальный идентификатор

        public Warehouse()
        {

        }


        //Интерфейс IList позволяет получать элементы коллекции по порядку
        //и определяет ряд методов для манипуляции данными


        //определяет существует ли объект в коллекции и возвращает индекс
        public int IndexOf(IItem item)
        {
            return items.IndexOf(item);
        }

        //добавление нового элемента в коллекцию с укказанием индекса
        public void Insert(int index, IItem item)
        {
            items.Insert(index, item);
        }

        //удаление элемента из коллекции используя индекс
        public void RemoveAt(int index)
        {
            items.RemoveAt(index);
        }

        public IItem this[int index]
        {
            get { return items[index]; }
            set { items[index] = value; }
        }

        //добаление нового объекта в коллекцию
        public void Add(IItem item)
        {
            items.Add(item);
        }

        //удаляет все элементы из коллекции
        public void Clear()
        {
            items.Clear();
        }

        //определяет существует ли объект в коллекции и возвращает true or false
        public bool Contains(IItem item)
        {
            return items.Contains(item);
        }


        public void CopyTo(IItem[] array, int arrayIndex)
        {
            items.CopyTo(array, arrayIndex);
        }

        //возвращает размер коллекции
        public int Count
        {
            get { return items.Count; }
        }

        //проверка доступна ли коллекция только для чтения и возвращает true or false
        public bool IsReadOnly
        {
            get { return false; }
        }

        //удаляет объект из коллекции используя сам объект
        public bool Remove(IItem item)
        {
            return items.Remove(item);
        }

        public IEnumerator<IItem> GetEnumerator()
        {
            return items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        //добавление товара на склад
        public void AddItem(List<IItem> item)
        {
            foreach (var i in item)
            {
                items.Add(i);
                int itemId = nextItemId;
                tems.Add(itemId, i);
                nextItemId++;
            }
        }

        //получение списка товаров на складе
        public void GetItems()
        {
            if (tems.Count == 0)
            {
                Console.WriteLine("Нет товаров на складе!!!");
            }
            else
            {
                Console.WriteLine($"{"ID",-5} {"Производитель",-20} {"Модель",-30} {"Мощность",-10} {"Вес",-10}");
                foreach (var pair in tems)
                {
                    Console.WriteLine("{0}     {1}", pair.Key, pair.Value);
                }
            }
        }

        //удаление товара на складе
        public void RemoveItem(int itemId)
        {
            IItem a = tems[itemId];
            tems.Remove(itemId);
            items.Remove(a);
        }
    }
}
