using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MASM_SCAU.LogAnalysis;

namespace MASM_SCAU
{
    public class ASMCompiler
    { 
        public ASMCompiler()
        {
        }

        public static void Init(bool isDebug)
        {
            string content=(isDebug)?MASM_SCAU.configs.ASMScripts.Default.debugScript: MASM_SCAU.configs.ASMScripts.Default.startScript;
            //string content = MASM_SCAU.configs.ASMScripts.Default.startScript;
            content =content.Replace("&&SYSTEM32&&",MASM_SCAU.configs.AppMainSettings.Default.CompilerPath+@"\System32");
            
            if (!Directory.Exists("C:/Users/" + Environment.UserName + "/AppData/Local/DOSBox"))//如果不存在就创建 dir 文件夹  
                    Directory.CreateDirectory("C:/Users/" + Environment.UserName + "/AppData/Local/DOSBox");
                FileStream fs = new FileStream("C:/Users/" + Environment.UserName + "/AppData/Local/DOSBox/dosbox-0.74.conf", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(content);
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            FileStream fs2 = new FileStream(MASM_SCAU.configs.AppMainSettings.Default.CompilerPath+@"\System32\dosbox-0.74.conf", FileMode.Create);
            byte[] data2 = System.Text.Encoding.Default.GetBytes(content);
            fs2.Write(data2, 0, data2.Length);
            fs2.Flush();
            fs2.Close();
        }       
        //传入代码内容编译和设置是否是Debug模式启动
        public static void Run(string codeContent,bool isDebug)
        {
            //监听编译日志的变化
            MyFileSystemWather myWather = new MyFileSystemWather(MASM_SCAU.configs.AppMainSettings.Default.CompilerPath+@"\System32", "*.tlg");
            myWather.OnChanged += new FileSystemEventHandler(OnChanged);
            myWather.OnCreated += new FileSystemEventHandler(OnCreated);
            myWather.OnRenamed += new RenamedEventHandler(OnRenamed);
            myWather.OnDeleted += new FileSystemEventHandler(OnDeleted);
            myWather.Start();
            //DOSBox全局脚本初始化
            Init(isDebug);
            FileStream fs = new FileStream(MASM_SCAU.configs.AppMainSettings.Default.CompilerPath+@"\System32\App.asm", FileMode.Create, FileAccess.ReadWrite); //可以指定盘符，也可以指定任意文件名，还可以为word等文件
            StreamWriter sw = new StreamWriter(fs); // 创建写入流
            sw.Write(codeContent, Encoding.UTF8);//以UTF8编码写入代码文件，这里非常重要，BOM头编码是识别代码的重要标识，非常重要非常重要啊，不能把写入流的编码格式放到上面啊！！！！！！！！！！！！！
            sw.Close(); //关闭文件
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = MASM_SCAU.configs.AppMainSettings.Default.CompilerPath+@"/DBOX/DOSBox.exe"; //启动的应用程序名称
            startInfo.Arguments = "-noconsole -conf "+ MASM_SCAU.configs.AppMainSettings.Default.CompilerPath+@"\System32\dosbox-0.74.conf";//静默模式启动
            startInfo.WindowStyle = ProcessWindowStyle.Normal;
            try
            {
                //启动外部程序
                Process proc = Process.Start(startInfo);//启动编译程序和DOSBox
                if (proc != null)
                {
                    //监视进程退出
                    proc.EnableRaisingEvents = true;
                    //指定退出事件方法
                    proc.Exited += new EventHandler(proc_Exited);
                }
            }
            catch (ArgumentException ex)
            { MessageBox.Show("DOSBox 启动遇到意外...."); }
        }

        private static void proc_Exited(object sender, EventArgs e)//DOSBox 正常退出事件
        {
            //Console.WriteLine("OUT");
            MainForm.instance.CBbtnStatusInvoke(MainForm.instance.StatusUnlock);
            File.Delete(MASM_SCAU.configs.AppMainSettings.Default.CompilerPath+@"\System32\APP.EXE");
        }

        private static void OnCreated(object source, FileSystemEventArgs e)
        {
            //Console.WriteLine("文件新建事件处理逻辑");        
        }

        private static void OnChanged(object source, FileSystemEventArgs e)
        {
            //Console.WriteLine("文件改变事件处理逻辑");      
            Analysis();  //启动编译分析器
            MainForm.instance.CBLogInvoke(MainForm.instance.LogUpdateWindow);//调用主线程委托更新UI
        }
        private static void OnDeleted(object source, FileSystemEventArgs e)
        {
           // Console.WriteLine("文件删除事件处理逻辑");           
        }
        private static void OnRenamed(object source, RenamedEventArgs e)
        {
            //Console.WriteLine("文件重命名事件处理逻辑");
            MessageBox.Show("编译日志文件不能被重命名！否则将可能发生不可预料错误！");
        }

        public static string GetLST()//调查当前LST文件
        {
            try
            {
                string fname = MASM_SCAU.configs.AppMainSettings.Default.CompilerPath+@"\System32\LOG.LST";
                /*Encoding ed = FileTools.EncodingInfoBOM(fname);
                //Console.WriteLine(ed);
                if (ed.Equals(Encoding.ASCII))
                {
                    ed = Encoding.GetEncoding("GBK");
                }*/
                Encoding ed = Encoding.UTF8;
                StreamReader streamReader = new StreamReader(fname, ed);
                string sourceContent = streamReader.ReadToEnd();
                streamReader.Close();
                return sourceContent;
            }
            catch (Exception _e)
            {
                return "遇到意外，请重新获取~";
            }

        }
    }
}
