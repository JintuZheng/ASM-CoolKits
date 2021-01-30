using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MASM_SCAU
{
    public class ASMEditor
    {
        public string code="";//当前编辑器的代码内容


        public ASMEditor()
        {

        }

        public void setValue(string codesrc, string theme, ChromiumWebBrowser EditorBrowser)
        {
            string temple = MASM_SCAU.configs.ASMScripts.Default.htmlSourceScript;
            string[] lines = codesrc.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            string result = "";
            //Console.WriteLine(lines.Length);
            for (int i = 0; i < lines.Length; i++)
            {
                result += "\'" + lines[i].Replace("\\", "\\\\").Replace("\'", "\\\'").Replace("\"", "\\\"") + "\',\r\n";
            }
            result = temple.Replace("#CODECONTENT#", result).Replace("#THEME#", theme);
            //Console.Write(result);
            string ID = Utils.GenID();
            string urlPath = Environment.CurrentDirectory+@"\canvas\" + ID + ".html";
            FileStream fs = new FileStream(urlPath, FileMode.Create, FileAccess.ReadWrite); //可以指定盘符，也可以指定任意文件名
            StreamWriter sw = new StreamWriter(fs,Encoding.UTF8); // 创建写入流
            sw.Write(result);//以UTF8编码写入代码文件
            sw.Close(); //关闭文件
            EditorBrowser.Load(urlPath);
        }


        public string getValue()
        {
            return this.code;          
        }

        public void _delegate_getValue_Component(ChromiumWebBrowser EditorBrowser)//异步调用组件
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("function outSrc() {");
            sb.AppendLine("var s=editor.getValue(true)");
            sb.AppendLine("return s");
            // sb.AppendLine("return document.getElementsByClassName('view-lines')[0].innerHTML");
            sb.AppendLine("}");
            sb.AppendLine("outSrc();");
            var task01 = EditorBrowser.GetBrowser().GetFrame(EditorBrowser.GetBrowser().GetFrameNames()[0]).EvaluateScriptAsync(sb.ToString());
            task01.ContinueWith(t =>
            {
                if (!t.IsFaulted)
                {
                    var response = t.Result;
                    if (response.Success == true)
                    {
                        if (response.Result != null)
                        {
                            string tmpcode = response.Result.ToString();
                            tmpcode = tmpcode.Replace("\n", "\r\n");//LF尾转CRLF尾，由于摩洛哥编辑器的数据导出是Unix数据
                            MainForm.CallBack_getCodeFromEditor getCodeFromEditor = MainForm.instance.FuncDetail_getCodeFromEditor;//创建委托
                            getCodeFromEditor(tmpcode);//调用主进程委托
                        }
                    }
                }
            });
        }
        public void DisposeHtmlCache()//删除Cache，在主进程被销毁的时候
        {
            Utils.DelLicenseFiles(Environment.CurrentDirectory + @"\canvas\", ".html");
        }
        
        public void API(string command, ChromiumWebBrowser EditorBrowser)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("editor.getAction('"+command+"').run();");
            var task01 = EditorBrowser.GetBrowser().GetFrame(EditorBrowser.GetBrowser().GetFrameNames()[0]).EvaluateScriptAsync(sb.ToString());
            task01.ContinueWith(t =>{});
        }

    }
}
