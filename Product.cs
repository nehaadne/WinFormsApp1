using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    [Serializable]  //attribute in C#
    public class Product
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public int Price { get; set; }
    }
}
