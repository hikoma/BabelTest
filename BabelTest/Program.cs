using System;
using System.Reflection;

namespace BabelTest {
    class Program {
        static void Main(string[] args) {
            Console.ReadLine();
        }
    }

    public interface ITest1 {
        void SameMethod();
    }

    [Obfuscation(Feature = "renaming")]
    public interface ITest2 {
        void SameMethod();
        void OriginalMethod();
    }
}
