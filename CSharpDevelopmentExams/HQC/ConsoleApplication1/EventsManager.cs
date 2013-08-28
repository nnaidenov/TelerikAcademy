namespace CalendarSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class EventsManager : IEventsManager
    {
        private readonly List<Event> list = new List<Event>();

        public void AddEvent(Event theEvent)
        {
            this.list.Add(theEvent);
        }

        //Delete is very slow -> use EventsManagerFast
        public int DeleteEventsByTitle(string eventTitle)
        {
            return this.list.RemoveAll(
                e => e.EventTitle.ToLowerInvariant() == eventTitle.ToLowerInvariant());
        }

        //List is very slow -> use EventsManagerFast
        public IEnumerable<Event> ListEvents(DateTime date, int numberOfEvents)
        {
            var eventList = (from e in this.list
                    where e.EventDate >= date
                    orderby e.EventDate, e.EventTitle, e.EventLocation
                    select e).Take(numberOfEvents);

            return eventList;
        }
    }
}
