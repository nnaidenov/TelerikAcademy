namespace CalendarSystem
{
    using System;
    using System.Linq;
    using System.Text;

    public class CalendarSystemEnter
    {
        public static void Main()
        {
            //Use EventManagerFast because bottleneck is in EventManager
            var eventManager = new EventsManagerFast();
            var eventExecutor = new EventExecutor(eventManager);
            StringBuilder result = new StringBuilder();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End" || command == null)
                {
                    Console.WriteLine(result.ToString());
                    break;
                }

                try
                {
                    var parsedCommand = Command.Parse(command);
                    var resultOfCommand = eventExecutor.ProcessCommand(parsedCommand);
                    result.AppendLine(resultOfCommand);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}