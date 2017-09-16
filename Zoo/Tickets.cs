 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Tickets : ZooLand
    {
        public int KidsTicket { get; set; }
        public int AdultsTicket { get; set; }
        public int SeniorTicket { get; set; }

        public Tickets(int kidsTicket, int adultsTicket, int seniorTicket)
        {
            kidsTicket = KidsTicket;
            adultsTicket = AdultsTicket;
            seniorTicket = SeniorTicket;
        }

        public void PayHere()
        {
            Console.WriteLine("Welcome to the Zoo. You can pay here");
        }

        
    }




}
