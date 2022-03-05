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

        List<CSVModel> objectTemplates = new List<CSVModel>();
        
        public List<string[]> Objects = new List<string[]>();

        public CSVReadWrite(string _FilePath)
        {
            FilePath = _FilePath;
            
        }


        public void ReadHeader()
        {
            string path = @"objectTypes\";
            string[] fileEntries = Directory.GetFiles(path);
            
            foreach (string filename in fileEntries)
            {
                CSVModel obj = new CSVModel();
                objectTemplates.Add(obj);
                using (var reader = new StreamReader(filename))
                {
                    List<String> Headers = new List<String>();
                    while (!reader.EndOfStream)
                    {

                        var line = reader.ReadLine();
                        var values = line.Split(',');
                        if (values[0] == ":Tagname")
                        {
                            var _headers = values;
                            
                            foreach (string head in _headers)
                            {
                                objectTemplates[objectTemplates.Count - 1].Headers.Add(head);

                            }
                        }
                        else if (values[0].Contains('='))
                        {

                            objectTemplates[objectTemplates.Count-1].type = values[0];
                        }
                    }

    
                    
                }
             }
        }
        

    }
}
