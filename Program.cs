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
            string path = "B8238_DF01.csv";


            CSVReadWrite CSVTest = new CSVReadWrite(path);

            CSVTest.Read();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Area());
        }
    }

    static public class initVar
    {
        static public List<String> GeneralArea = new List<String>()
        {
            "Name",
            "Adress",
            "ShortDescription",
            "InterLock",
            "EngineeringUnit",
            "PLC",
            "ToolTip"
        };


        static public List<String> ObjectType = new List<String>()
        {
            "Valve_2Pos",
            "Valve_Control",
            "Valve_Diverter",
            "Motor_DOL",
            "Motor_VFD"
        };
    }
}