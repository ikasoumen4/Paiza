using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaizaTest {
    public class Program {
        public static void Main(string[] args) {
            var arg = Console.ReadLine().Split(' ');
            var val = new int[] { int.Parse(arg[0]), int.Parse(arg[1]) };

            var r1 = Math.Pow(val[0], 3);
            var r2 = Math.Pow(val[1], 3);

            var result = r1 - r2;

            Console.WriteLine(result);
        }

        static System.IO.StreamWriter sw = new System.IO.StreamWriter("output.txt",false);

        static Program() {
            Console.SetIn(new System.IO.StreamReader("input.txt"));

            //var sw = new System.IO.StreamWriter("output.txt",false);
            //sw.AutoFlush = true;

            Console.SetOut(sw);
        }

        public static System.IO.StreamReader GetExpectedAnswerStreamReader() {
            return new System.IO.StreamReader("answer.txt");
        }

        public static System.IO.StreamReader GetFactAnswerStreamReader() {
            return new System.IO.StreamReader("output.txt");
        }

        public static void CloseStreamReader() {
            sw.Close();
        }

    }

}
