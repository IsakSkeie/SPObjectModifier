using SPOT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPIT
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Need to add generic name with datetime
            string path = "B8238_DF01.csv";

            


            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Area());
        }
    }

    static public class initVar
    {
        //Need to add these to XML config file
        static private string Interlock = "Interlock#Masked.Description";
        static private string extFault = "ExternalFault#.Description";
        static public List<CSVModel> template = new List<CSVModel>();
        static initVar()
        {
           
            CSVReadWrite CSVInitRead = new CSVReadWrite();

            CSVInitRead.ReadHeader();
            template = CSVInitRead.objectTemplates;

        }
        //Need to add to XML config file
        static public List<String> GeneralArea = new List<String>()
        {
            "Name",
            "ToolTip",
            "InterLock",
            "EU",
        };

        static public List<string> InterAndExt()
        {
        
        }

        

    }

    static public class CsvData
    {

        static public void Data()
        {
            
        }
        
    }



}