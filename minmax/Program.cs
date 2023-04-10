using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace void_overload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            number numbers = new number();
            numbers.NilaiMin(95, 90);
            numbers.NilaiMin(95, 90, 100);
            numbers.NilaiMax(95, 90);
            numbers.NilaiMax(95, 90, 100);
        }
    }
}