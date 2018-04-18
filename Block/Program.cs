using System;
using static System.Console;
namespace Block
{
    class Program
    {
        static void Main(string[] args)
        {
            var genesisBlock = new Chain.Block("Hi I'm first", "0");
            WriteLine($"Block One: {genesisBlock.Hash}"); 
            
            var secondBlock = new Chain.Block("I'm second block", genesisBlock.Hash);
            WriteLine($"Block Two: {genesisBlock.Hash}");
            
            var thirdBlock = new Chain.Block("I'm third block", secondBlock.Hash);
            WriteLine($"Block Three: {thirdBlock.Hash}");

            ReadKey(true);

        }
    }
}