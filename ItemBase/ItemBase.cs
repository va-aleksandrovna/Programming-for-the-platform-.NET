using System;

namespace MyLibrary
{
    public class ItemBase
    {
        private string _Manufacturer; //производитель
        private int _NumberOfSections; //количество отделений
        private float _Weight; //вес

        public enum TypeOfControl //тип управления
        { Механический, Электронный }

        private TypeOfControl _type;

        public string Manufacturer
        {
            get { return _Manufacturer; }
            set { _Manufacturer = value; }
        }

        public int NumberOfSections
        {
            get { return _NumberOfSections; }
            set { _NumberOfSections = value; }
        }

        public float Weight
        {
            get { return _Weight; }
            set { _Weight = value; }
        }
     
        public TypeOfControl Type 
        {
            get { return _type; }
            set { _type = value; }
        }
    }
}
