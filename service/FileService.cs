using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking_system.service
{
    public class FileService
    {
        public static void SaveToCsv(String filePath, String row)
        {
            Console.WriteLine(filePath);
            Console.WriteLine(row);
            using (StreamWriter w = File.AppendText(filePath))
            {
                w.WriteLine(row);
            }
        }
    }
}
