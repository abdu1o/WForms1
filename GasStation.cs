using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class GasStation
    {
        public string? Model { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }
        public string? Type { get; set; }

        public override string ToString()
        {
            return $"Model: {Model} Year: {Year} Price: {Price} Type: {Type}";
        }
    }
}
