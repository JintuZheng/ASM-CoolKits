using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MASM_SCAU
{
    static class FileTools
    {

        public static Encoding EncodingInfoBOM(string fname)
        {
            // Read the BOM
            var bom = new byte[4];
            using (var file = new FileStream(fname, FileMode.Open, FileAccess.Read))
            {
                file.Read(bom, 0, 4);
            }
            // Analyze the BOM
            if (bom[0] == 0x2b && bom[1] == 0x2f && bom[2] == 0x76) return Encoding.UTF7;
            if (bom[0] == 0xef && bom[1] == 0xbb && bom[2] == 0xbf) return Encoding.UTF8;
            if (bom[0] == 0xff && bom[1] == 0xfe) return Encoding.Unicode; //UTF-16LE
            if (bom[0] == 0xfe && bom[1] == 0xff) return Encoding.BigEndianUnicode; //UTF-16BE
            if (bom[0] == 0 && bom[1] == 0 && bom[2] == 0xfe && bom[3] == 0xff) return Encoding.UTF32;
            return Encoding.ASCII;
        }

        public static Encoding EncodingInfo(string filename)
        {

            System.IO.FileStream fs = new System.IO.FileStream(filename, System.IO.FileMode.Open, System.IO.FileAccess.Read);

            System.IO.BinaryReader br = new System.IO.BinaryReader(fs);

            Byte[] buffer = br.ReadBytes(2);

            if (buffer[0] >= 0xEF)

            {

                if (buffer[0] == 0xEF && buffer[1] == 0xBB)

                {

                    return System.Text.Encoding.UTF8;

                }

                else if (buffer[0] == 0xFE && buffer[1] == 0xFF)

                {

                    return System.Text.Encoding.BigEndianUnicode;

                }

                else if (buffer[0] == 0xFF && buffer[1] == 0xFE)

                {

                    return System.Text.Encoding.Unicode;

                }

                else

                {

                    return System.Text.Encoding.Default;

                }

            }

            else

            {

                return System.Text.Encoding.Default;

            }

        }

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

    }
}
