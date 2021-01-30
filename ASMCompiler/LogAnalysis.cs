using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;



namespace MASM_SCAU
{
    public static class LogAnalysis
    {

        public class Logitem
        {
            public string lineNumber="0";
            public string code="00";
            public string content="None";
            public string type="Warning";
        }

        private static List<string> infoLines=new List<string>();
        private static List<Logitem> lstLines = new List<Logitem>();
        private static int Errors = 0;
        private static int Warns = 0;

        public static  void Analysis()//启动日志分析得到编译日志
        {
            string rawLogtxt = File.ReadAllText(MASM_SCAU.configs.AppMainSettings.Default.CompilerPath+@"\System32\LOG.LOG");
            string[] rawLines = rawLogtxt.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            //
             Errors = 0;
             Warns = 0;
            infoLines.Clear();
            lstLines.Clear();
            //
            foreach(string iline in rawLines)
            {
                infoLines.Add(iline);
                if (iline.Contains("App.asm("))
                {
                    infoLines.Add(iline);
                    Logitem logitem=new Logitem();
                    try
                    {
                        string[] infoArr = iline.Split(new string[] { "App.asm(", "): ", ": " }, StringSplitOptions.RemoveEmptyEntries);
                        logitem.lineNumber = infoArr[0];

                        logitem.content = infoArr[2];
                        logitem.content = Translate(logitem.content);//假如连接了网络，调用翻译
                                                                     //Console.Write(Translate(logitem.content));
                        if (infoArr[1].Contains("error"))//假如是错误类型
                        {
                            logitem.type = "Error";
                            logitem.code = infoArr[1].Replace("error ", "");
                        }
                        else//假如是警告类型
                        {
                            logitem.type = "warning";
                            logitem.code = infoArr[1].Replace("warning ", "");
                        }
                        lstLines.Add(logitem);
                    }
                    catch (Exception _e)
                    {
                        logitem.content = "你输入的中文好毒噢，我内存爆了";
                        logitem.type = "Error";
                        logitem.lineNumber = "?";

                    }
                    
                }else if(iline.Contains("Warning Errors"))
                {
                    string err_tmp = iline.Replace(" ", "");
                    err_tmp = err_tmp.Replace("WarningErrors","");
                    Warns = Convert.ToInt32(err_tmp);
                }else if(iline.Contains("Severe  Errors"))
                {
                    string err_tmp = iline.Replace(" ", "");
                    err_tmp = err_tmp.Replace("SevereErrors", "");
                    Errors = Convert.ToInt32(err_tmp);
                }
            }
        }

        public static List<string> getRawLines()
        {
            return infoLines;
        }

        public static int getErrorSum()
        {
            return Errors;
        }
        public static int getWarnSum()
        {
            return Warns;
        }

        public static List<Logitem> getResult()
        {
            return lstLines;
        }
            
        public static string Translate(string logContent)
        {
            try
            {
                string Transurl = "http://fanyi.youdao.com/translate?&doctype=json&type=AUTO&i=" + logContent;
                WebRequest myWebRequest = WebRequest.Create(Transurl);
                WebResponse myWebResponse = myWebRequest.GetResponse();
                Stream ReceiveStream = myWebResponse.GetResponseStream();
                string responseStr = "";
                if (ReceiveStream != null)
                {
                    StreamReader reader = new StreamReader(ReceiveStream, Encoding.UTF8);
                    responseStr = reader.ReadToEnd();
                    reader.Close();
                }
                myWebResponse.Close();
                string[] res = responseStr.Split(new string[] { "\"}]]}", "\",\"tgt\":\"" }, StringSplitOptions.None);
                return res[res.Length - 2].Replace("预期","出现异常啦");
            }catch(Exception _e)
            {
                return logContent;
            }

        }
    }
}
