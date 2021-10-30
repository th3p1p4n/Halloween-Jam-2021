using System;
using System.Collections.Generic;
using System.Text;

namespace RGDC_Halloween_Jam_21
{
    class Item
    {
        bool obtained;
        string type;

        Item(string type)
        {
            this.type = type;
            obtained = false;
        }
    }
}
