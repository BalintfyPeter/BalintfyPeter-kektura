using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Kektura
{
    internal class Szakasz
    {
        static string NehezE(hossz)
        {
            if (hossz <= 5)
            {
                MessageBox.Show("Ez a túra könnyű.");
            }

            else if (hossz > 5 && hossz > 10)
            {
                MessageBox.Show("Ez a túra közepes.");
            }

            else
            {
                MessageBox.Show("Ez a túra nehéz.");
            }
        }
    }
}
