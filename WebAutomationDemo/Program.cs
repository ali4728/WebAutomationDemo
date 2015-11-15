using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAutomationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Automate auto = new Automate();
            //auto.Execute();

            //AutomateWebDriver wd = new AutomateWebDriver();
            //wd.Execute();

            Upload up = new Upload();
            up.Execute();
            Console.WriteLine("It is completed! Press enter to exit.");
            Console.ReadLine();
        }
    }
}
