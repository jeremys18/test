using System;

namespace Jermy_and_Jeremiah_app_1
{
    class Program
    {
        static int nummy2 = 0;
        public int nummy = 0;
        static void Main(string[] args)
        {
            var iin = new Input
            {
                input1 = 2,
                input2 = 3,
                input3 = 4,
                input4 = 5
            };
            Program P = new Program();
            var calResult = P.CalcBaby(iin);
            Console.WriteLine("Done!");
            Console.ReadLine();
            //var pp = new Program();
            //pp.Start();
            //var ppp = new Program();


            //Console.WriteLine($"p's nummy is {P.nummy}");
            //Console.WriteLine($"pp's nummy is {pp.nummy}");
            //Console.WriteLine($"ppp's nummy is {ppp.nummy}");
            //Program.gg();
            //Program.hh();
            //Program.gg();

            //Console.WriteLine($"All gg nummys are {Program.nummy2}");
            //Console.Read();
        }

        private output CalcBaby(Input input)
        {
            var result = new output
            {
                Out1 = input.input1 + input.input2,
                Out2 = input.input3 - (input.input4 * input.input2)
            };
            return result;
        }
        private void Start()
        {
            nummy++;
            Console.WriteLine($"Nummy is {nummy}");

            //// Hello world done right with Jeremy 4.24.2021
            //String output = "Hello World!! From:";
            //Console.WriteLineLine("What State do you Live in?");
            //String add = Console.ReadLine();
            //Console.WriteLineLine(output + add);
            //Console.Read();
        
        }
    } 
      
}
