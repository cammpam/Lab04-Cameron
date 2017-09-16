using System;

namespace Zoo
{
    abstract class ZooLand
    {
        public string Animal { get; set; }
        public int TicketPrice { get; set; }
        public string Parking { get; set; } 


        public void Zoo(string Animal)
        {

        }

        public int Zoo(int TicketPrice)
        {
            TicketPrice = ticketPrice;
        }

        public void Zoo(string Parking)
        {
            Parking = parking;
        }
    }



}

