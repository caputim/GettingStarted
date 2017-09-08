using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarter
{
    class Program
    {
        static void Main(string[] args)
        {

            String word = "";
            word = Console.ReadLine();
            int numberone = int.Parse(word.Substring(0, 1));
            String operation = word.Substring(2, 3);
            int numbertwo = int.Parse(word.Substring(4));

            int sum = 0;

            if(operation == "+")
                sum = numberone + numbertwo;
            if(operation == "*")
                sum = numberone * numbertwo;
            if(operation == "/")
                sum = numberone / numbertwo;
            if(operation == "-")
                sum = numberone - numbertwo;

            Console.WriteLine(numberone + " " + operation + " " + numbertwo + " = " + sum);



        }
    }
}
