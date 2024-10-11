using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛБ4
{
    abstract class ItemBase : IItem
    {
        protected abstract string GetDescription();
        public sealed override string ToString() { return GetDescription(); }

        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int Power { get; set; }
        public float Weight { get; set; }

    }
}
