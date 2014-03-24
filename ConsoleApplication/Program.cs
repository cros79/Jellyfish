namespace ConsoleApplication {
    using System;
    using InvativaNet.Core.Utilities;

    public class Program {
        private static void Main(string[] args) {
            Console.WriteLine(General.JsonSerialize(new {Hejkon = "Bacon"}));
            Console.ReadLine();
        }
    }
}