using System;
using System.Collections.Generic;
using System.Text;

namespace ЛБ4
{
    public enum TypeOfControl //тип управления
    { Механический, Электронный }

    class ToasterItem : ItemBase, ICloneable, IComparable
    {
        private int _NumberOfSections; //количество отделений
        private TypeOfControl _type;

        public int NumberOfSections
        {
            get { return _NumberOfSections; }
            set { _NumberOfSections = value; }
        }

        public TypeOfControl Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public ToasterItem(string manufacturer, string model, int power, float weight, int numberOfSections, TypeOfControl type) //конструктор
        {
            Manufacturer = manufacturer;
            Model = model;
            Weight = weight;
            NumberOfSections = numberOfSections;
            Power = power;
            Type = type;
        }

        protected override string GetDescription() //метод ToString() для вывода на экран
        {
            return $"{Manufacturer,-20} {Type,-20} {NumberOfSections,-20} {Power,-10} {Weight,-10} {Model,-30}";
        }

        //Интерфейс ICloneable служит для создания копии объекта
        //Для реализации этого интерфейса в классе товара необходимо определить метод Clone(), который будет возвращать копию объекта
        public object Clone()
        {
            return new ToasterItem(Manufacturer, Model, Power, Weight, NumberOfSections, Type);
        }

        //Интерфейс IComparable позволяет сравнивать объекты по определенным критериям
        //Для реализации этого интерфейса в классе товара реализуется метод CompareTo() по Model
        public int CompareTo(object obj)
        {
            //if (obj is ToasterItem toasteritem) return Model.CompareTo(toasteritem.Model);
            //else throw new ArgumentException("Некорректное значение параметра");

            if (obj is ToasterItem toasteritem)
            {
                int retval = Manufacturer.CompareTo(toasteritem.Manufacturer);
                
                if (retval != 0)
                {
                    return retval;
                }
                else
                {
                    int retval2 = Type.CompareTo(toasteritem.Type);

                    if (retval2 != 0)
                    {
                        return retval2;
                    }
                    else
                    {
                        int retval3 = NumberOfSections.CompareTo(toasteritem.NumberOfSections);

                        if (retval3 != 0)
                        {
                            return retval3;
                        }
                        else
                        {
                            int retval4 = Power.CompareTo(toasteritem.Power);

                            if (retval4 != 0)
                            {
                                return retval4;
                            }
                            else
                            {
                                int retval5 = Weight.CompareTo(toasteritem.Weight);

                                if (retval5 != 0)
                                {
                                    return retval5;
                                }
                                else
                                {
                                    return Model.CompareTo(toasteritem.Model);
                                }
                            }
                        }
                    }
                }
            }
            else throw new ArgumentException("Некорректное значение параметра");
        }
    }
}
