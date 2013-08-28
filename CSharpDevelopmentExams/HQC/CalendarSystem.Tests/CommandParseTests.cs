using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;

namespace CalendarSystem.Tests
{
    [TestClass]
    public class CommandParseTests
    {
        [TestMethod]
        public void AddCommandNameTest()
        {
            string command = "AddEvent 2000-01-01T01:00:00 | party Viki | home";

            var actual = Command.Parse(command).CommandName;
            string expected = "AddEvent";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddCommandWithThreeParametersTest()
        {
            string command = "AddEvent 2000-01-01T01:00:00 | party Viki | home";

            var actual = Command.Parse(command).Parameters;
            string[] expected = 
            {
                "2000-01-01T01:00:00",
                "party Viki",
                "home"
            };

            for (int i = 0; i < actual.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod]
        public void AddCommandWithTwoParametersTest()
        {
            string command = "AddEvent 2000-01-01T01:00:00 | party Viki";

            var actual = Command.Parse(command).Parameters;
            string[] expected = 
            {
                "2000-01-01T01:00:00",
                "party Viki",
            };

            for (int i = 0; i < actual.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void NoWhiteSpaceAddCommandTest()
        {
            string command = "AddEvent2000-01-01T01:00:00|partyViki|home";

            var actual = Command.Parse(command).CommandName;
        }


        [TestMethod]
        public void DeleteCommandNameTest()
        {
            string command = "DeleteEvent C# exam";

            var actual = Command.Parse(command).CommandName;
            string expected = "DeleteEvent";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteCommandParametersTest()
        {
            string command = "DeleteEvent C# exam";

            var actual = Command.Parse(command).Parameters;
            string[] expected = 
            {
                "C# exam"
            };

            for (int i = 0; i < actual.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}
