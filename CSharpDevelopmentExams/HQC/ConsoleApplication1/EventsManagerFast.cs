namespace CalendarSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Wintellect.PowerCollections;
    using MultiDictionary = Wintellect.PowerCollections.MultiDictionary<string, CalendarSystem.Event>;

    public class EventsManagerFast : IEventsManager
    {
        private readonly MultiDictionary timeTableByTitle = new MultiDictionary(true);
        private readonly OrderedMultiDictionary<DateTime, Event> timeTableByEventDate = new OrderedMultiDictionary<DateTime, Event>(true);

        public void AddEvent(Event newEvent)
        {
            string eventTitleLowerCase = newEvent.EventTitle.ToLowerInvariant();
            this.timeTableByTitle.Add(eventTitleLowerCase, newEvent);
            this.timeTableByEventDate.Add(newEvent.EventDate, newEvent);
        }

        public int DeleteEventsByTitle(string eventTitle)
        {
            string eventTitleLower = eventTitle.ToLowerInvariant();
            var deletedEvents = this.timeTableByTitle[eventTitleLower];
            int numberOfDeletedEvents = deletedEvents.Count;

            foreach (var eventEvent in deletedEvents)
            {
                this.timeTableByEventDate.Remove(eventEvent.EventDate, eventEvent);
            }

            this.timeTableByTitle.Remove(eventTitleLower);

            return numberOfDeletedEvents;
        }

        public IEnumerable<Event> ListEvents(DateTime date, int numberOfListedEvents)
        {
            var listOfSelectedEvents =
                from e in this.timeTableByEventDate.RangeFrom(date, true).Values
                select e;
            var sortEvents = (from e in listOfSelectedEvents
                         where e.EventDate >= date
                         orderby e.EventDate, e.EventTitle, e.EventLocation
                         select e);
            var events = sortEvents.Take(numberOfListedEvents);

            return events;
        }

        public int NumberOfEventsInList
        {
            get 
            {
                return this.timeTableByEventDate.Count; 
            }
        }
    }
}
