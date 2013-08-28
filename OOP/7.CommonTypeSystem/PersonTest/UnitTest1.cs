using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonTask;

namespace PersonTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Person anastas = new Person();
            anastas.name = "Anastas Ivanov";
            //"Name: {0} \n\rAge is not specified.", name
            StringBuilder a = new StringBuilder();
            a.AppendFormat("Name: {0}", anastas.name);
            string output = a.ToString();

            Assert.AreEqual(1, anastas.ToString());
        }
    }
}
