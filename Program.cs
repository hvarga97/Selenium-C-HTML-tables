using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingTable
{
    class Program : Base
    {
        static void Main(string[] args)
        {
            Driver = new FirefoxDriver();
            //Driver.Navigate().GoToUrl("file://///Mac/Home/Documents/SimpleTable.html"); - when using SimpleTable.html
            
        //For complex tables
            Driver.Navigate().GoToUrl("file://///Mac/Home/Documents/ComplexTable.html");
        //..
        
            TablePage page = new TablePage();
            //Read the table
            Utilities.ReadTable(page.table);
            //Get the cell value from the table
            Console.WriteLine(Utilities.ReadCell("Email", 1));
            Console.WriteLine("The name {0} with Email {1} and Phone {2}",
                Utilities.ReadCell("Name",2), Utilities.ReadCell("Email", 2), Utilities.ReadCell("Phone", 2));
                
         //For complex tables
            //delete Marko row
            //Utilities.PerformActionOnCell("5", "Name", "Marko", "Delete"); //example of deleting a row
            //Utilities.PerformActionOnCell("5", "Name", "Marko", "Save"); //example of saving the row
            Utilities.PerformActionOnCell("Option", "Name", "Marko");
         //..
         
            Console.Read();
        }
    }
}
