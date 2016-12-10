using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaizaTest {
    public class Program {
        public static void Main(string[] args) {
            // 自分の得意な言語で
            // Let's チャレンジ！！
            var line = System.Console.ReadLine();
            System.Console.WriteLine("XXXXXX");
        }

        static System.IO.StreamWriter sw = new System.IO.StreamWriter("output.txt",false);

        static Program() {
            System.Console.SetIn(new System.IO.StreamReader("input.txt"));

            //var sw = new System.IO.StreamWriter("output.txt",false);
            //sw.AutoFlush = true;

            System.Console.SetOut(sw);
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
