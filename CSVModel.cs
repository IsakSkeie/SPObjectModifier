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
    public class ObjectUpdate
    {
        public string template;
        public List<string> header;
        public List<string> Attributes = new List<string>();

        public void Interlock(int type, string name, int N)
        {
            template = initVar.template[type].type;
            header = initVar.template[type].Headers;
            Attributes.Add(name + ',');
            //Fix this hardcoded number
            for(int i = 0; i < 8; i++)
                if(i == N)
                {
                    Attributes.Add(initVar.AtrbInterlock()[N]);
                }
            foreach(var atrb in Attributes)
            {
            Console.WriteLine(atrb);
            }
            

        }
    }

    

}
