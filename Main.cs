using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FileRead.FileImporter;
namespace FileRead
{
    class Program
    {
        static void Main(string[] args)
        {
            var texture_file = new List<string>();

            //ファイル読み込み
            FileImporter.FileReader(ref texture_file);
            FileImporter.FilePassMaker(ref texture_file);
        }
    }
}
