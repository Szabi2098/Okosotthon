using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Okosotthon.Models;

namespace Okosotthon
{
    internal class Program
    {
        private static List<Ertesites> ertesites = new List<Ertesites>();
        static void Main(string[] args)
        {
            ertesites.Add(new SMS());
            ertesites.Add(new Email());
            ertesites.Add(new Push());
            foreach (var item in ertesites)
            {
                item.Kuld("Mozgás érzékelve: Nappali Jobb sarok pókháló");
            }
        }
    }
}
