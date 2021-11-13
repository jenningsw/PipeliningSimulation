using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeliningSimulation
{
    public class ReservationStation
    {
        public int Capacity { get; set; }                               //Capacity of reservation station
        public List<ReservationStationItem> Buffer { get; set; }        //Buffer of items waiting for execution

        public ReservationStation()
        {
            Capacity = 1;
            Buffer = new List<ReservationStationItem>();
        }

        public ReservationStation(int capacity)
        {
            Capacity = capacity;
            Buffer = new List<ReservationStationItem>();
        }

        /// <summary>
        /// Method returning if the reservation station is full
        /// </summary>
        /// <returns>true if full, false if has space</returns>
        public bool IsFull()
        {
            if (Capacity == Buffer.Count)
                return true;
            else
                return false;
        }
    }
}
