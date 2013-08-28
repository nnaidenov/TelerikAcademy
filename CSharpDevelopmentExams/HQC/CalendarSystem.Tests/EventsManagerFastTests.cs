using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;
using System.Text;
using System.Linq;

namespace CalendarSystem.Tests
{
    [TestClass]
    public class EventsManagerFastTests
    {
        [TestMethod]
        public void AddEventWhitTwoParametersTest()
        {
            var eventManager = new EventsManagerFast();

            string[] eventParameters = { "2010-01-01T00:00:00", "party Viki 2010" };
            var command = new Command { CommandName = "AddEvent", Parameters = eventParameters };
            var date = DateTime.ParseExact(command.Parameters[0], "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);

            var theEvent = new Event
            {
                EventDate = date,
                EventTitle = command.Parameters[1],
                EventLocation = null,
            };

            eventManager.AddEvent(theEvent);

            int actual = eventManager.NumberOfEventsInList;
            int expexted = 1;

            Assert.AreEqual(expexted, actual);
        }

        [TestMethod]
        public void AddSameEventsTest()
        {
            var eventManager = new EventsManagerFast();

            string[] eventParameters = { "2010-01-01T00:00:00", "party Viki 2010" };
            var command = new Command { CommandName = "AddEvent", Parameters = eventParameters };
            var date = DateTime.ParseExact(command.Parameters[0], "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);

            string[] eventParametersTwo = { "2010-01-01T00:00:00", "party Viki 2010" };
            var commandTwo = new Command { CommandName = "AddEvent", Parameters = eventParameters };
            var dateTwo = DateTime.ParseExact(command.Parameters[0], "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);

            var theEvent = new Event
            {
                EventDate = date,
                EventTitle = command.Parameters[1],
                EventLocation = null,
            };

            var theEvent2 = new Event
            {
                EventDate = dateTwo,
                EventTitle = commandTwo.Parameters[1],
                EventLocation = null,
            };

            eventManager.AddEvent(theEvent);
            eventManager.AddEvent(theEvent2);

            var actual = eventManager.ListEvents(date, 5).Count();
            int expexted = 2;

            Assert.AreEqual(expexted, actual);
        }

        [TestMethod]
        public void DeleteOneEventTest()
        {
            var eventManager = new EventsManagerFast();

            string[] eventParameters = { "2010-01-01T00:00:00", "party Viki 2010" };
            var command = new Command { CommandName = "DeleteEvents", Parameters = eventParameters };
            var date = DateTime.ParseExact(command.Parameters[0], "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);

            var theEvent = new Event
            {
                EventDate = date,
                EventTitle = command.Parameters[1],
                EventLocation = null,
            };

            eventManager.AddEvent(theEvent);

            string expected;
            string actual;

            int numberOfDeletedEvents = eventManager.DeleteEventsByTitle("party Viki 2010");
            expected = "1 events deleted";

            if (numberOfDeletedEvents == 0)
            {
                actual = "No events found";
            }
            else
	        {
                actual = numberOfDeletedEvents + " events deleted";
	        }

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteFiveEventTest()
        {
            var eventManager = new EventsManagerFast();

            string[] eventParameters = { "2010-01-01T00:00:00", "party Viki 2010" };
            var command = new Command { CommandName = "DeleteEvents", Parameters = eventParameters };
            var date = DateTime.ParseExact(command.Parameters[0], "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);

            var theEvent = new Event
            {
                EventDate = date,
                EventTitle = command.Parameters[1],
                EventLocation = null,
            };

            eventManager.AddEvent(theEvent);
            eventManager.AddEvent(theEvent);
            eventManager.AddEvent(theEvent);
            eventManager.AddEvent(theEvent);
            eventManager.AddEvent(theEvent);

            string expected;
            string actual;

            int numberOfDeletedEvents = eventManager.DeleteEventsByTitle("party Viki 2010");
            expected = "5 events deleted";

            if (numberOfDeletedEvents == 0)
            {
                actual = "No events found";
            }
            else
            {
                actual = numberOfDeletedEvents + " events deleted";
            }

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ListEventOneEventTest()
        {
            var eventManager = new EventsManagerFast();

            string[] eventParameters = { "2010-01-01T00:00:00", "party Viki 2010" };
            var command = new Command { CommandName = "AddEvent", Parameters = eventParameters };
            var date = DateTime.ParseExact(command.Parameters[0], "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);

            var theEvent = new Event
            {
                EventDate = date,
                EventTitle = command.Parameters[1],
                EventLocation = null,
            };

            eventManager.AddEvent(theEvent);


            int expected = 1;
            int actual = 0;

            var currentCommand = 5;
            var events = eventManager.ListEvents(date, currentCommand).ToList();

            foreach (var e in events)
            {
                actual++;
            }

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ListEventThreeEventTest()
        {
            var eventManager = new EventsManagerFast();

            string[] eventParameters = { "2010-01-01T00:00:00", "party Viki 2010" };
            var command = new Command { CommandName = "AddEvent", Parameters = eventParameters };
            var date = DateTime.ParseExact(command.Parameters[0], "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);

            var theEvent = new Event
            {
                EventDate = date,
                EventTitle = command.Parameters[1],
                EventLocation = null,
            };

            eventManager.AddEvent(theEvent);
            eventManager.AddEvent(theEvent);
            eventManager.AddEvent(theEvent);


            int expected = 3;
            int actual = 0;

            var currentCommand = 5;
            var events = eventManager.ListEvents(date, currentCommand).ToList();

            foreach (var e in events)
            {
                actual++;
            }

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ListEventTwoEventTest()
        {
            var eventManager = new EventsManagerFast();

            string[] eventParameters = { "2010-01-01T00:00:00", "party Viki 2010" };
            var command = new Command { CommandName = "AddEvent", Parameters = eventParameters };
            var date = DateTime.ParseExact(command.Parameters[0], "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);

            var theEvent = new Event
            {
                EventDate = date,
                EventTitle = command.Parameters[1],
                EventLocation = null,
            };

            eventManager.AddEvent(theEvent);
            eventManager.AddEvent(theEvent);
            eventManager.AddEvent(theEvent);

            int expected = 2;
            int actual = 0;

            var currentCommand = 2;
            var events = eventManager.ListEvents(date, currentCommand).ToList();

            foreach (var e in events)
            {
                actual++;
            }

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ListEventFourEventDisplayTest()
        {
            var eventManager = new EventsManagerFast();

            string[] eventParameters = { "2012-01-21T20:00:00", "party Viki", "home" };
            var command = new Command { CommandName = "AddEvent", Parameters = eventParameters };
            var date = DateTime.ParseExact(command.Parameters[0], "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);

            string[] eventParametersOne = { "2012-01-21T20:00:00", "C# exam" };
            var commandOne = new Command { CommandName = "AddEvent", Parameters = eventParametersOne };
            var dateOne = DateTime.ParseExact(command.Parameters[0], "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);

            string[] eventParametersTwo = { "2012-01-21T20:00:00", "C# exam" };
            var commandTwo = new Command { CommandName = "AddEvent", Parameters = eventParametersTwo };
            var dateTwo = DateTime.ParseExact(command.Parameters[0], "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);

            string[] eventParametersThree = { "2012-01-21T20:00:00", "C# exam" };
            var commandThree = new Command { CommandName = "AddEvent", Parameters = eventParametersThree };
            var dateThree = DateTime.ParseExact(command.Parameters[0], "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);

            var theEvent = new Event
            {
                EventDate = date,
                EventTitle = command.Parameters[1],
                EventLocation = command.Parameters[2],
            };

            var theEventOne = new Event
            {
                EventDate = dateOne,
                EventTitle = commandOne.Parameters[1],
                EventLocation = null
            };

            var theEventTwo = new Event
            {
                EventDate = dateTwo,
                EventTitle = commandTwo.Parameters[1],
                EventLocation = null,
            };

            var theEventThree = new Event
            {
                EventDate = dateThree,
                EventTitle = commandThree.Parameters[1],
                EventLocation = null,
            };

            eventManager.AddEvent(theEvent);
            eventManager.AddEvent(theEventOne);
            eventManager.AddEvent(theEventTwo);
            eventManager.AddEvent(theEventThree);

            StringBuilder expected = new StringBuilder();

            expected.AppendLine("2012-01-21T20:00:00 | C# exam");
            expected.AppendLine("2012-01-21T20:00:00 | C# exam");
            expected.AppendLine("2012-01-21T20:00:00 | C# exam");
            expected.AppendLine("2012-01-21T20:00:00 | party Viki | home");

            string expectedToString = expected.ToString();
            StringBuilder actual = new StringBuilder();

            var currentCommand = 5;
            var events = eventManager.ListEvents(date, currentCommand).ToList();

            foreach (var e in events)
            {
                actual.AppendLine(e.ToString());
            }

            string actualToString = actual.ToString();

            Assert.AreEqual(expectedToString, actualToString);
        }

        [TestMethod]
        public void ListEventFourEventDisplayTwoTest()
        {
            var eventManager = new EventsManagerFast();

            string[] eventParameters = { "2012-01-21T20:00:00", "party Viki", "home" };
            var command = new Command { CommandName = "AddEvent", Parameters = eventParameters };
            var date = DateTime.ParseExact(command.Parameters[0], "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);

            string[] eventParametersOne = { "2012-01-21T20:00:00", "C# exam" };
            var commandOne = new Command { CommandName = "AddEvent", Parameters = eventParametersOne };
            var dateOne = DateTime.ParseExact(command.Parameters[0], "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);

            string[] eventParametersTwo = { "2012-01-21T20:00:00", "C# exam" };
            var commandTwo = new Command { CommandName = "AddEvent", Parameters = eventParametersTwo };
            var dateTwo = DateTime.ParseExact(command.Parameters[0], "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);

            string[] eventParametersThree = { "2012-01-21T20:00:00", "C# exam" };
            var commandThree = new Command { CommandName = "AddEvent", Parameters = eventParametersThree };
            var dateThree = DateTime.ParseExact(command.Parameters[0], "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);

            var theEvent = new Event
            {
                EventDate = date,
                EventTitle = command.Parameters[1],
                EventLocation = command.Parameters[2],
            };

            var theEventOne = new Event
            {
                EventDate = dateOne,
                EventTitle = commandOne.Parameters[1],
                EventLocation = null
            };

            var theEventTwo = new Event
            {
                EventDate = dateTwo,
                EventTitle = commandTwo.Parameters[1],
                EventLocation = null,
            };

            var theEventThree = new Event
            {
                EventDate = dateThree,
                EventTitle = commandThree.Parameters[1],
                EventLocation = null,
            };

            eventManager.AddEvent(theEvent);
            eventManager.AddEvent(theEventOne);
            eventManager.AddEvent(theEventTwo);
            eventManager.AddEvent(theEventThree);

            StringBuilder expected = new StringBuilder();

            expected.AppendLine("2012-01-21T20:00:00 | C# exam");
            expected.AppendLine("2012-01-21T20:00:00 | C# exam");

            string expectedToString = expected.ToString();
            StringBuilder actual = new StringBuilder();

            var currentCommand = 2;
            var events = eventManager.ListEvents(date, currentCommand).ToList();

            foreach (var e in events)
            {
                actual.AppendLine(e.ToString());
            }

            string actualToString = actual.ToString();

            Assert.AreEqual(expectedToString, actualToString);
        }

        [TestMethod]
        public void AddHundredSameEventTest()
        {
            var eventManager = new EventsManagerFast();

            string[] eventParameters = { "2012-01-21T20:00:00", "party Viki", "home" };
            var command = new Command { CommandName = "AddEvent", Parameters = eventParameters };
            var date = DateTime.ParseExact(command.Parameters[0], "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);

            var theEvent = new Event
            {
                EventDate = date,
                EventTitle = command.Parameters[1],
                EventLocation = command.Parameters[2],
            };

            for (int i = 0; i < 100; i++)
            {
                eventManager.AddEvent(theEvent);
            }

            int actual = eventManager.ListEvents(date, 100).Count();
            Console.WriteLine(eventManager.NumberOfEventsInList);

            Assert.AreEqual(100, actual);
        }
    }
}
