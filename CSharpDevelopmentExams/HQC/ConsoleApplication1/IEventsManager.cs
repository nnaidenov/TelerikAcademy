namespace CalendarSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public interface IEventsManager
    {
        /// <summary>
        /// This method add event in EventList
        /// </summary>
        /// <param name="eventToAdd">This parameter is Event object.</param>
        void AddEvent(Event eventToAdd);

        /// <summary>
        /// This method delete event from EventList
        /// </summary>
        /// <param name="eventTitle">Parameter is the Event title who you want to delete</param>
        /// <returns>Return number of deleted events.</returns>
        int DeleteEventsByTitle(string eventTitle);

        /// <summary>
        /// This method show some events who you want to see
        /// </summary>
        /// <param name="date">By data parameters sort events who must display.</param>
        /// <param name="numberOfEvents">The numbers of the listed events should be the given numberOfEvents or less.</param>
        /// <returns>Return list of selected events from given parameters.</returns>
        IEnumerable<Event> ListEvents(DateTime date, int numberOfEvents);
    }
}
