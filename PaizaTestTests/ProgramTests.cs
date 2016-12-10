using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaizaTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaizaTest.Tests {
    [TestClass()]
    public class ProgramTests {
        [TestMethod()]
        public void TestTest() {
            PaizaTest.Program.Main(null);
            PaizaTest.Program.Main(null);
            PaizaTest.Program.Main(null);

            PaizaTest.Program.CloseStreamReader();

            var stream_expected = PaizaTest.Program.GetExpectedAnswerStreamReader();
            var stream_fact = PaizaTest.Program.GetFactAnswerStreamReader();

            string expected;
            string fact;
            int no = 1;
            while((expected = stream_expected.ReadLine()) != null) {
                fact = stream_fact.ReadLine();
                Assert.AreEqual(expected, fact, String.Format("No.{0}", no, expected, fact));
                no++;
            }

        }
    }
}