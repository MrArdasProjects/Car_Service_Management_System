using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArunaCarServices
{
    public class ComboboxItem
    {
        public string Text { get; set; }
        public int ID { get; set; }

        public ComboboxItem(string text, int id)
        {
            Text = text;
            ID = id;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
