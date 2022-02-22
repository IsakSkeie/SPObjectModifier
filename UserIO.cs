using SPIT;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPOT
{
    public class UserIO
    {
        public List<String> Objects = new List<String>();
        public string ObjectDisp;
        public List<String> DOL = new List<String>();
        public List<String> VFD = new List<String>();
        public List<String> ValveObj = new List<String>();
        public List<String> MotorObj = new List<String>();
        public List<String> CSV = new List<String>();
        


        public string Display()
        {
            ObjectDisp = "";
            foreach(string Obj in Objects)
            {
                ObjectDisp += Obj + "\r\n";
            }
            return ObjectDisp;
        }

        public void ObjectInput(string obj, int atrb, string update)
        {
            if (obj.Contains("MO"))
            {
                MotorData input = new MotorData();
                input.atributes[0] = obj;
                
                input.atributes[atrb] = update;
                Console.WriteLine(input.atributes[0]);
                Console.WriteLine(input.atributes[atrb]);
                MotorObj.Add(input.StringCreate());
            }
            else if ( atrb == 3)
            {
                
            }
                    

            
          
        }

        public void CSVCreate()
        {
            CSV.Add(initVar.DOL);
            foreach(var entry in MotorObj)
            {
                CSV.Add(entry);
            }

            CSV.Add(initVar.VFD);
            foreach(var entry in MotorObj)
            {
                CSV.Add(entry);
            }
            foreach(string line in CSV)
            {
                //fix filepath
                File.AppendAllText(@"C:\EU.csv", line + Environment.NewLine);
            }
            

        }

    }
}

