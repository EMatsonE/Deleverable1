using System;

namespace Deleverable_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            do
            {

                //ask person to input a measurement type
                Console.WriteLine("Hey you! Yes you, gimme one of these 4 measurement types:" +
                    " I'll need inches, fidget spinners, memes, or feet. Don't ask me why we " +
                    "measure stuff in fidget spinners and memes now, " +
                    "that was just what Broestotol said we should call it...");
                string unit = Console.ReadLine();
                //then ask for a number
                Console.WriteLine("Ok ok ok! For once I don't have to deal with a brain melted human! " +
                    "Now write a number you beautiful expendable flesh bag you!");
                string amount = Console.ReadLine();
                double amountConverted = double.Parse(amount);
                //store and convert the answer as a double so that it can handle decimals

                // 1 inch = 3.5 fidgit spinners / if unit = inch mulyiply by 3.5 / 
                if (unit == "inches" || unit == "inch" || unit == "Inch" || unit == "Inches")
                {
                    double sum = amountConverted * 3.5;
                    Console.WriteLine("So from what you gave me the convesion should be " + sum + " fidget spinners.");
                }

                // 1 foot = 5 memes / if unit = foot multiply by 5
                if (unit == "feet" || unit == "Feet" || unit == "foot" || unit == "Foot")
                {
                    double sum = amountConverted * 5;
                    Console.WriteLine("So from what you gave me the convesion should be " + sum + " memes.");
                }
                // 5 memes = 1 foot / if unit = memes divide by 5
                if (unit == "memes" || unit == "Memes" || unit == "Meme" || unit == "meme")
                {
                    double sum = amountConverted / 5;
                    Console.WriteLine("So from what you gave me the convesion should be " + sum + " feet.");
                }
                // 3.5 Fidget Spinners = 1 inch / if unit = Fidgit Spinners divide by 3.5
                if (unit == "fidget spinners" || unit == "Fidget Spinners" || unit == "Fidget spinners"
                     || unit == "fidget Spinners" || unit == "fidget spinner" || unit == "Fidget Spinner"
                      || unit == "fidget Spinner" || unit == "Fidget spinner")
                {
                    double sum = amountConverted / 3.5;
                    Console.WriteLine("So from what you gave me the convesion should be " + sum + " inches.");
                }
                // output the calculation

                //make sure output is correct with corosponding unit of messurement

                // ask the person if they wanna do another calculation, yes = loop
                // no = later my guy
                Console.WriteLine("Sweet! Wanna redo the simulation?");
                
                string redo = Console.ReadLine();
                
                if (redo == "yes")
                {
                    repeat = true;
                }
                else
                {
                    repeat = false;
                }

            } while (repeat == true); 
            

        }
    }
}
