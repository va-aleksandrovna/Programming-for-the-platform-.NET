using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛБ4
{
    class PhoneItem : ItemBase
    {

        public PhoneItem(string manufacturer, string model, int power, float weight) //конструктор
        {
            Manufacturer = manufacturer;
            Model = model;
            Weight = weight;
            Power = power;
        }

        protected override string GetDescription()
        {
            return $"{Manufacturer,-20} {Model,-30} {Power,-10} {Weight,-10}";
        }
    }
}
