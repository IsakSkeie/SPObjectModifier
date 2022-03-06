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
        static private string Interlock = "Interlock0#Masked.Description";
        static private string extFault = "ExternalFault0#.Description";
        static private int InterN = 8;
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
            "Ext Fault",
            "Flush InterL.&Ext.",
            "EU",
        };

        static public List<string> AtrbInterlock()
        {
            
            List<string> InterlockList = new List<string>();
            
            for(int i = 0; i < InterN; i++)
            {
                string InterlockN = Interlock.Replace("#", i.ToString());
                //need to fix hardcoded 0
                for(int n = 0; n < initVar.template[0].Headers.Count; n++)
                {
                    if (initVar.template[0].Headers[n] == InterlockN)
                    { InterlockList.Add(InterlockN);}
                }
            }
            return InterlockList;
        }
        static public List<string> AtrbExtFault()
        {
            List<string> ExtFaultList = new List<string>();
            
            for (int i = 0; i < InterN; i++)
            {
                string ExtFaultN = extFault.Replace("#", i.ToString());
                //need to fix hardcoded 0
                for (int n = 0; n < initVar.template[0].Headers.Count; n++)
                {
                    if (initVar.template[0].Headers[n] == ExtFaultN)
                    { ExtFaultList.Add(ExtFaultN); }
                }

            }
            return ExtFaultList;
        }


    }

    static public class CsvData
    {

        static public void Data()
        {
            
        }
        
    }



}