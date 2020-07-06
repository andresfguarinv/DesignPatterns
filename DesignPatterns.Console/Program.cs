using static System.Console;
using DesignPatterns.Library.FactoryMethod;

namespace DesignPatterns.Console
{
    class Program
    {
        public const string FactoryMethod = "1";
        static void Main(string[] args)
        {
            WriteLine("1. Factory Method");

            string pattern = ReadLine();
            switch (pattern)
            {
                case FactoryMethod:
                    Connection connection1 = FactoryConnection.GetConnection("ORACLE");
                    WriteLine(connection1.Connect());
                    WriteLine(connection1.Disconnect());

                    Connection connection2 = FactoryConnection.GetConnection("SQL");
                    WriteLine(connection2.Connect());
                    WriteLine(connection2.Disconnect());
                    
                    break;
                default:
                    WriteLine("Pattern not implemented");
                    return;
            }
        }
    }
}
