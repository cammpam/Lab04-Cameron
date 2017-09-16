using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Animal : ZooLand
    {
        public string Safari { get; set; }
        public string Jungle { get; set; }
        public string Water { get; set; }

        public Animal(string safari, string jungle, string water)
        {
            Safari = safari;
            Jungle = jungle;
            Water = water;
        }

        public void LookOnly()
        {
            Console.WriteLine("If you touch animals, it's at your on risk!");
        }
    }




}
