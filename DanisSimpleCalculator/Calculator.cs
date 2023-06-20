using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanisSimpleCalculator
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public string Jsonify(double a)
        {
            return "{\"a\": " + a.ToString() + "}");
        }

        public string ToHtml(double a)
        {
            return $"<h5>{a}</h5>";
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }
    }
}
