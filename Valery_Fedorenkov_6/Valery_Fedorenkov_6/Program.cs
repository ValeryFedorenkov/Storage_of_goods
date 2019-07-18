using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace Valery_Fedorenkov_6
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    public class Goods
    {
        public string Type { get; set; }   
        public int Cost { get; set; }
        public int Quantity { get; set; }
        public Goods(string ProdName, int cost, int quantity)
        {
            Type = ProdName;
            Cost = cost;
            Quantity = quantity;
        }
    }
    public class GoodsList : ArrayList, ITypedList
    {
        public PropertyDescriptorCollection
            GetItemProperties(PropertyDescriptor[] listAccessors)
        {
            return TypeDescriptor.GetProperties(typeof(Goods));
        }

        public string GetListName(PropertyDescriptor[] listAccessors)
        {
            return "GoodsList";
        }
    }
}
