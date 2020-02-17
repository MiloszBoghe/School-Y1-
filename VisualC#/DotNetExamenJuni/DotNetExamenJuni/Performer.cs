using System;
using System.Collections.Generic;

namespace DotNetExamenJuni
{
    public abstract class Performer
    {
        public Performer(string name, int reservation, string start, string end, int[] techSupplies, IList<string> rider)
        {
            Name = name;
            ReservationNumber = reservation;

            //Zet de hh:mm format van de start en eindtijden om in een int array 
            int[] startArray = Array.ConvertAll(start.Trim().Split(':'), Int32.Parse);
            int[] endArray = Array.ConvertAll(end.Trim().Split(':'), Int32.Parse);

            //en daarna in een TimeSpan Object voor in de constructor mee te geven.
            TimeSpan startTime = new TimeSpan(startArray[0], startArray[1], 0);
            TimeSpan endTime = new TimeSpan(endArray[0], endArray[1], 0);

            StartTime = startTime;
            EndTime = endTime;
            TechnicalSupplies = techSupplies;
            Rider = rider;
        }


        public override string ToString()
        {
            return $"{StartTime.ToString(@"hh\:mm")}-{EndTime.ToString(@"hh\:mm")} {Name}";
        }

        public IList<string> Rider { get; set; }

        public int[] TechnicalSupplies { get; set; }

        public TimeSpan EndTime { get; set; }

        public TimeSpan StartTime { get; set; }

        public int ReservationNumber { get; set; }

        public string Name { get; set; }


    }
}
