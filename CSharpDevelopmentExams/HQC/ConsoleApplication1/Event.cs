namespace CalendarSystem
{
    using System;
    using System.Linq;

    public class Event : IComparable<Event>
    {
        public DateTime EventDate { get; set; }

        public string EventTitle { get; set; }

        public string EventLocation { get; set; }

        public override string ToString()
        {
            string dateFormat = "{0:yyyy-MM-ddTHH:mm:ss} | {1}";

            if (this.EventLocation != null)
            {
                dateFormat += " | {2}";
            }

            string eventAsString = string.Format(dateFormat, this.EventDate, this.EventTitle, this.EventLocation);

            return eventAsString;
        }

        public int CompareTo(Event eventWithCompare)
        {
            int result = DateTime.Compare(this.EventDate, eventWithCompare.EventDate);
  
                if (result == 0)
                {
                    result = string.Compare(this.EventTitle, eventWithCompare.EventTitle, StringComparison.Ordinal);
                }

                if (result == 0)
                {
                    result = string.Compare(this.EventLocation, eventWithCompare.EventLocation, StringComparison.Ordinal);
                }

            return result;
        }
    }
}
