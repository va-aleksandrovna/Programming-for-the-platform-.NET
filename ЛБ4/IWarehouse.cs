using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛБ4
{
    interface IWarehouse
    {
        void AddItem(List<IItem> item);
        void GetItems();
        void RemoveItem(int itemId);
    }
}
