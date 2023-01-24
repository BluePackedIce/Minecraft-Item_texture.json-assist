using System.IO;
using System.Drawing;
using System;
using System.Collections.Generic;
namespace FileRead;
internal class FileImporter
{
    public static void FileReader(ref List<string> result)
    {
      //ファイルNO
      int i = 0;

      var listBox = new List<string>();
      //"C:\test"以下のファイルをすべて取得する
      System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(@"ここに書き込むテクスチャを入れておくフォルダの絶対パスを貼る");
      //System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(@"C:\Users\user\Desktop\Texture\File");
      IEnumerable<System.IO.FileInfo> files =
      di.EnumerateFiles("*", System.IO.SearchOption.AllDirectories);
      string fileName = "";


        
        //ファイルを列挙する
        foreach (System.IO.FileInfo f in files)
        {
            //リストにファイル名を追加
            result.Add(f.FullName);

            //テクスチャを入れているフォルダ名を書く
            fileName = result[i].Substring(result[i].IndexOf("File"));

            //先頭5文字(File\)以降を切り取り = ファイル名.png
            //ファイル名+1の数値にする
            fileName =  fileName.Substring(5);

            //末端4文字(.png)を削除 = ファイル名
            fileName = fileName.Substring(0, fileName.Length - 4);

            result.Remove(f.FullName);

            result.Add(fileName);
         //Console.WriteLine(fileName);
         //Console.WriteLine(listBox[i]);
            i++;
           
        }
        
    }

    public static void FilePassMaker(ref List<string> listbox)
    {
        int i = 0;

        foreach (string list in listbox)
        {
            //ここで出力されるファイルパスを指定する
            /*{listbox[i]が出力されるファイル名*/
            Console.WriteLine($"        \"{listbox[i]}\":{{\"textures\":\"textures/items/{listbox[i]}\"}},");
            i++;
        }
    }
}
