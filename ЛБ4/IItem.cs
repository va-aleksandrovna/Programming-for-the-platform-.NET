using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛБ4
{
    interface IItem
    {
        string Manufacturer { get; set; }
        string Model { get; set; }
        int Power { get; set; }
        float Weight { get; set; }
    }
}
