using System;

namespace ComputerAverageApp
{
    class ComputerAverageProgram
    {
        static void Main (string[] args) {
            Console.WriteLine("Enter 5 grades seperated by new line: ");
            int sum = 0;
            int x = 1;
            while (x<=5) {
                int gradenum = Convert.ToInt32(Console.ReadLine());
                sum += gradenum;
                x++;
            }
            double computation = (double)sum / 5;

            Console.WriteLine("The average is " + (double)computation + " and round off to " + Math.Round(computation));
            Console.WriteLine("Press any ket to exit");
            Console.ReadKey();
        }
    }
}
