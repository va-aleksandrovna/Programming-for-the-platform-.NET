using System;
using System.Collections.Generic;
using System.Text;

namespace ЛБ1
{
    class Item : MyLibrary.ItemBase
    {
        private string _Model; //модель
        public string Model
        {
            get { return _Model; }
            set { _Model = value; }
        }

        private int _Power; //Мощность
        public int Power
        {
            get { return _Power; }
            set { _Power = value; }
        }

        public Item(string manufacturer, string model, int numberOfSections, int power, TypeOfControl type, float weight) //конструктор
        {
            Manufacturer = manufacturer;
            Model = model;
            Weight = weight;
            NumberOfSections = numberOfSections;
            Power = power;
            Type = type;
        }

        public override string ToString() //метод ToString() для вывода на экран
        {
            return $"{Manufacturer,-20} {Model,-30} {NumberOfSections,-20} {Power,-10} {Type,-20} {Weight,-10}";
        }
    }

}
