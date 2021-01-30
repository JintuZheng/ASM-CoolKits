using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MASM_SCAU
{
    class Utils
    {
        public static string MD5Encrypt(string strText)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] targetData = md5.ComputeHash(Encoding.UTF8.GetBytes(strText));

            string byte2String = null;

            for (int i = 0; i < targetData.Length; i++)
            {
                byte2String += targetData[i].ToString("x2");
            }

            return byte2String.ToUpper();
        }

        public static string DateGen()
        {
            string dcode = DateTime.Now.Date.ToString();
            return dcode;
        }
        public static string GenID()//生成唯一的一个ID
        {
            Random ran = new Random();
            int RandKey = ran.Next(0, 999);
            string rkey = RandKey.ToString() + "下雨了收衣服了";
            string dc = DateGen();
            string wholeraw = dc + rkey;
            return MD5Encrypt(wholeraw);
        }

        public static void CopyDirectory(string sourceDirPath, string SaveDirPath)
        {
            try
            {
                //如果指定的存储路径不存在，则创建该存储路径
                if (!Directory.Exists(SaveDirPath))
                {
                    //创建
                    Directory.CreateDirectory(SaveDirPath);
                }
                //获取源路径文件的名称
                string[] files = Directory.GetFiles(sourceDirPath);
                //遍历子文件夹的所有文件
                foreach (string file in files)
                {
                    string pFilePath = SaveDirPath + "\\" + Path.GetFileName(file);
                    if (File.Exists(pFilePath))
                        continue;
                    File.Copy(file, pFilePath, true);
                }
                string[] dirs = Directory.GetDirectories(sourceDirPath);
                //递归，遍历文件夹
                foreach (string dir in dirs)
                {
                    CopyDirectory(dir, SaveDirPath + "\\" + Path.GetFileName(dir));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void DelLicenseFiles(string path, string name)
        {
            try
            {
                DirectoryInfo Folder = new DirectoryInfo(path);
                var files = Folder.GetDirectories();
                foreach (FileInfo file in Folder.GetFiles())
                {
                    if (file.Attributes != FileAttributes.Directory)
                    {
                        if (file.Name.Contains(name))
                        {
                            file.Delete();
                        }
                    }
                }
                foreach (var dicInfo in Folder.GetDirectories())
                {
                    DelLicenseFiles(dicInfo.FullName, name);
                }
            }
            catch
            {

            }
        }
    }
}
