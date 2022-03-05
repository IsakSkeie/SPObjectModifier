using SPIT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPOT
{
    public class CSVModel
    {
        public string type = "";
        public List<string> Headers = new List<String>();
    }
    public class Object
    {
        public List<string> Attributes = new List<string>();

        public Object(int type, string name)
        {
            Attributes.Add(name);
            for(int i = 0; i < initVar.template[type].Headers.Count(); i++)
            {
                Attributes.Add("");
            }
        }
    }

}
