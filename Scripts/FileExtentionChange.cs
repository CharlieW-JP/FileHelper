using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHelper.Scripts
{
    class FileExtentionChange
    {
        //private const string DirPath = "F:/BaiduNetdiskDownload/temptest";

        // 拡張子を指定する
        //private const string extentionName = "*.tul"; 

        public void Process(string pathValue, string originEx, string newEx)
        {
            // 取得したファイル名を格納するためのリスト
            List<string> lstStr = new();

            // ファイル名取得
            string[] strBuff;

            strBuff = Directory.GetFiles(pathValue, "*." + originEx);

            foreach (string file in strBuff)
            {
                lstStr.Add(file);
            }

            foreach (string file in lstStr)
            {
                string fileName = file;

                string newEXFileName = System.IO.Path.ChangeExtension(fileName, newEx);

                File.Move(fileName, newEXFileName);
          
            }
        }
        
    }
}

