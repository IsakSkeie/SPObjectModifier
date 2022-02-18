using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPOT
{
    public class UserIO
    {
        public List<String> Objects = new List<String>();
        public string ObjectDisp;
        public List<String> MotorObj = new List<String>();
        public List<String> ValveObj = new List<String>();


        public string Display()
        {
            ObjectDisp = "";
            foreach(string Obj in Objects)
            {
                ObjectDisp += Obj + "\r\n";
            }
            return ObjectDisp;
        }

        public void ObjectInput(string Input)
        {
            if (Input.Contains("MO"))
            {
                MotorObj.Add(Input);
            }
            else
            {
                ValveObj.Add(Input);
            }

        }

    }
}

