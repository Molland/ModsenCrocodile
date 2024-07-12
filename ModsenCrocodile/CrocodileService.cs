using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ModsenCrocodile
{
    internal class CrocodileService
    {
        private List<Crocodile> crocodiles = new List<Crocodile>();
        public void AddCrocodile(Crocodile crocodile)
        {
            crocodiles.Add(crocodile);
        }
        public void DisplayAllCrocodiles()
        {
            foreach (var crocodile in crocodiles)
            {
                Console.WriteLine(crocodile);
            }
        }
        public void DisplayCrocodilesLongerThan(double length)
        {
            var longCrocodiles = crocodiles.Where(c => c.Length > length);

            foreach (var crocodile in longCrocodiles)
            {
                Console.WriteLine(crocodile);
            }
        }
        public void DisplayOldestCrocodile()
        {
            var oldestCrocodile = crocodiles.OrderByDescending(c => c.Age).FirstOrDefault();

            if (oldestCrocodile != null)
            {
                Console.WriteLine("Самый старый крокодил: " + oldestCrocodile);
            }
        }

        public void DisplayHeaviestCrocodile()
        {
            var heaviestCrocodile = crocodiles.OrderByDescending(c => c.Weight).FirstOrDefault();

            if (heaviestCrocodile != null)
            {
                Console.WriteLine("Самый тяжелый крокодил: " + heaviestCrocodile);
            }
        }
    }
}

