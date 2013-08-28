namespace CalendarSystem
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Text;

    public class EventExecutor
    {
        private readonly IEventsManager eventManager;

        public EventExecutor(IEventsManager eventManager)
        {
            this.eventManager = eventManager;
        }

        public IEventsManager EventsProcessor
        {
            get
            {
                return this.eventManager;
            }
        }

        public string ProcessCommand(Command command)
        {
            string commandResultMessage = string.Empty; 
            switch (command.CommandName)
            {
                case "AddEvent":
                    {
                        if (command.Parameters.Length == 2)
                        {
                            var date = DateTime.ParseExact(command.Parameters[0], "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
                            var theEvent = new Event
                            {
                                EventDate = date,
                                EventTitle = command.Parameters[1],
                                EventLocation = null,
                            };

                            this.eventManager.AddEvent(theEvent);

                            commandResultMessage = "Event added";
                        }
                        else
                        {
                            var date = DateTime.ParseExact(command.Parameters[0], "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
                            var theEvent = new Event
                            {
                                EventDate = date,
                                EventTitle = command.Parameters[1],
                                EventLocation = command.Parameters[2],
                            };

                            this.eventManager.AddEvent(theEvent);

                            commandResultMessage = "Event added";
                        }

                        break;
                    }

                case "DeleteEvents":
                    {
                        if (command.Parameters.Length == 1)
                        {
                            int numberOfDeletedEvents = this.eventManager.DeleteEventsByTitle(command.Parameters[0]);

                            if (numberOfDeletedEvents == 0)
                            {
                                return "No events found";
                            }

                            commandResultMessage = numberOfDeletedEvents + " events deleted";
                        }

                        break;
                    }

                case "ListEvents":
                    {
                        if (command.Parameters.Length == 2)
                        {
                            var date = DateTime.ParseExact(command.Parameters[0], "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
                            var currentCommand = int.Parse(command.Parameters[1]);
                            var events = this.eventManager.ListEvents(date, currentCommand).ToList();
                            var listOfEvents = new StringBuilder();

                            if (!events.Any())
                            {
                                commandResultMessage = "No events found";
                                break;
                            }

                            foreach (var e in events)
                            {
                                listOfEvents.AppendLine(e.ToString());
                            }

                            return listOfEvents.ToString().Trim();
                        }

                        break;
                    }

                default:
                    {
                        string unknownCommand = string.Format("Unknown command: {0}", command.CommandName);
                        throw new Exception(unknownCommand);
                    }
            }

            return commandResultMessage;
        }
    }
}
