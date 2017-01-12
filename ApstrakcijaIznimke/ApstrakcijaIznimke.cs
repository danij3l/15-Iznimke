using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.CSharp
{
    class ApstrakcijaIznimke
    {
        static void Main(string[] args)
        {
            // TODO: Provjeriti koju iznimku će baciti metoda Faktorjel u donjem kodu.

            // TODO: Promijeniti implementaciju metode Faktorjel tako da za slučaj preljeva baca iznimku tipa ArgumentOutOfRangeException s imenom parametra i vrijednošću argumenta.
            try
            {
                Math.Faktorjel(30);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Parametar {0} ima nedozvoljenu vrijednost {1}", e.ParamName, e.ActualValue);
            }
        }
    }
}
