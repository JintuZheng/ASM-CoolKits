using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MASM_SCAU
{
    [Serializable]
    class CodeFile
    {
        public CodeFile()
        {

        }

        public CodeFile(string fname,Encoding ed,string content)
        {
            this.SourcePath = fname;
            string[] _farr = fname.Split(new string[] { @"\" }, StringSplitOptions.RemoveEmptyEntries);
            this.FileName = _farr[_farr.Length-1];
            this.SourceContent = content;
            this.CurrentContent = content;
            this.FileEncoding = ed;
        }

        public string CurrentContent { get; set; }//当前被修改的内容
        public string SourceContent { get; set; }//上一次打开和保存的内容
        public string SourcePath { get; set; }//源文件所在地址
        public Encoding FileEncoding { get; set; }//文件编码格式
        public string FileName { get; set; }//文件的文件名
        public bool isModified()//判断文件是否被修改（判断是否修改并且保存了）
        {
            if (CurrentContent.Equals(SourceContent))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void Cur2SourceContent()//保存文件内容
        {
            this.SourceContent = this.CurrentContent;
        }
        public void Path2SingleName()
        {
            string[] _farr = this.SourcePath.Split(new string[] { @"\" }, StringSplitOptions.RemoveEmptyEntries);
            this.FileName = _farr[_farr.Length - 1];
        }
    }
}
