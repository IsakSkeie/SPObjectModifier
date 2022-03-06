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
        public List<string> Values = new List<string>();
    }
    public class ObjectUpdate
    {
        public string template;
        public List<string> header;
        public List<string> Attributes = new List<string>();

        public void Interlock(int type, string name, int N)
        {
            Attributes.Add(name + ',');
            //Fix this hardcoded number
            Attributes.Add(initVar.AtrbInterlock()[N]);
                
            foreach(var atrb in Attributes)
            {
            Console.WriteLine(atrb);
            }
        }
    }

    public static class CSVData
    {
        public static List<CSVModel> Data = new List<CSVModel>(); 
        
        public static void ObjAdd(int type, List<string> Headers, List<string> Atrb)
        {
            CSVModel Instance = new CSVModel();
            Instance.type = initVar.template[type].type;
            Instance.Headers = Headers;
            Instance.Values = Atrb;

            Data.Add(Instance);
        }
    }

    

}
