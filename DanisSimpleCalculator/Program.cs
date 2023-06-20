using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanisSimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Calculator();

            double sum = c.Add(4, 5);
            string html = c.ToHtml(85);
            string json = c.Jsonify(9);
            double mul = c.Multiply(4, 5);

        }

    }
}
