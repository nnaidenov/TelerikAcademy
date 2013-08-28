namespace CalendarSystem
{
    using System;
    using System.Linq;

    public struct Command
    {
        public string CommandName;

        public string[] Parameters { get; set; }

        public static Command Parse(string currontCommand)
        {
            int indexOfWhiteSpace = currontCommand.IndexOf(' ');
            if (indexOfWhiteSpace == -1)
            {
                throw new FormatException("Invalid command format: " + currontCommand);
            }

            string eventCommand = currontCommand.Substring(0, indexOfWhiteSpace);
            string eventArguments = currontCommand.Substring(indexOfWhiteSpace + 1);

            var commandArguments = eventArguments.Split('|');

            for (int i = 0; i < commandArguments.Length; i++)
            {
                eventArguments = commandArguments[i];
                commandArguments[i] = eventArguments.Trim();
            }

            var command = new Command { CommandName = eventCommand, Parameters = commandArguments };

            return command;
        }
    }
}
