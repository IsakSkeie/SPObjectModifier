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
        public static int nAtrb = 2;

        static public List<String> GeneralArea = new List<String>()
        {
            "Name",
            "ToolTip",
            "InterLock",
            "EU",
        };


        static public List<String> ObjectType = new List<String>()
        {
           "Motor",
           "Valve"
        };

        static public string DOL = ":TEMPLATE=$WV_Motor_DOL,ShortDesc";
        static public string VFD = ":TEMPLATE=$WV_Motor_VFD,ShortDesc";
   
        static public string Valve2Pos = ":TEMPLATE=$WV_Valve_2Pos";
        static public string ValveControl = ":TEMPLATE=$WV_Valve_Control";
        static public string ValveDiverter = ":TEMPLATE=$WV_Valve_Diverter";
        static public string ValveGate = ":TEMPLATE=$WV_Valve_Gate";

        static public string atrb_m = ":Tagname,ShortDesc";

    }

    public class MotorData
    {
       public string[] atributes = new string[initVar.nAtrb];
       
       public string StringCreate()
        {
            return String.Join(",", atributes);    
        }
        
    }

    public class ValveData
    {
        public string[] atributes = new string[initVar.nAtrb];

        public string StringCreate()
        {
            return String.Join(",", atributes);
        }

    }


}