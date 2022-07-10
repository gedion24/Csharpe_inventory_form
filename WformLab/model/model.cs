using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WformLab.model
{
    class Item
    {
        public string number { get; set; }
        public string date { get; set; }
        public string inventorynumber { get; set; }
        public string objectname { get; set; }
        public int count { get; set; }
        public string price { get; set; }

        public void save()
        {
            Console.WriteLine("save");
        }

    }
}
