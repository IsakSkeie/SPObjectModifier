using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPOT
{
    public class CSVReadWrite
    {
        private string FilePath = "";
        private int Line;
        public List<String> Headers = new List<String>();


        public CSVReadWrite(string _FilePath)
        {
            FilePath = _FilePath;
            Line = -1;
        }


        public void Read()
        {
            using (var reader = new StreamReader(@"C:\Users\isak.skeie\source\repos\SPOT\B8238_DF01.csv"))
            {
                List<string[]> Objects = new List<string[]>();
                
                while (!reader.EndOfStream)
                {

                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    if (values[0] == ":Tagname")
                    {
                        var _headers = values;
                        Line = 0;
                        foreach(string head in _headers)
                        {
                            Headers.Add(head);

                        }
                    }
                    else if(Line > -1)
                    {
                        Objects.Add(values);
                    }
                }
                

            }
        }
        

    }
}
