using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MASM_SCAU
{
    class ASMFileManager
    {
        public List<CodeFile> Opened = new List<CodeFile>(); //打开的代码文件
        public List<CodeFile> History = new List<CodeFile>();//历史记录文件，在程序打开的时候自动打开

        public CodeFile EditingFile;//该类未实例化用于指针访问，正在编辑器的文件
        int newFileIndex = 1;

        public ASMFileManager()
        {
            if (Opened.Count == 0)
            {
                NewASMFile();
            }
            EditingFile = Opened[0];
        }

        public void OpenHistory()//打开最近的历史文件
        {
            for(int i = 0; i < History.Count; i++)
            {
                OpenASMFile(History[i].SourcePath);
                Console.WriteLine(History[i].SourcePath);
            }
        }

        public void SaveHistory()
        {

                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(Environment.CurrentDirectory + @"\History.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, History);
                stream.Close();

        }

        public void LoadHistory()
        {
        if (File.Exists(Environment.CurrentDirectory + @"\History.bin"))
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(Environment.CurrentDirectory + @"\History.bin", FileMode.Open, FileAccess.Read, FileShare.None);
                if (stream != null)
                {
                    this.History = (List<CodeFile>)formatter.Deserialize(stream);
                    OpenHistory();
                    Console.WriteLine("sss");
                }
            
            stream.Close();
            
            }
        }

        public void ClearHistory()
        {
            this.History.Clear();
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(Environment.CurrentDirectory + @"\History.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, History);
            stream.Close();
        }

        public void OpenASMFile(string fname)
        {
            try
            {
                if (!CheckASMFileIsOpened(fname) && File.Exists(fname))
                {
                    Encoding ed = FileTools.EncodingInfoBOM(fname);
                    
                    if (ed.Equals(Encoding.ASCII))
                    {
                        ed = Encoding.GetEncoding("GBK");
                    }

                    StreamReader streamReader = new StreamReader(fname, ed);
                    string sourceContent = streamReader.ReadToEnd();
                    streamReader.Close();
                    CodeFile cdNew = new CodeFile(fname, ed, sourceContent);
                    Opened.Add(cdNew);//添加到被打开的文件序列里面
                    MainForm.instance.Invoke_Open2Editor(MainForm.instance.Open2Editor, cdNew.SourceContent);//调用委托更新UI
                    EditingFile = Opened[Opened.Count - 1];
                }
            }
            catch(Exception _e)
            {

            }
        }

        public void OpenASMFile()//打开代码文件
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "(*.asm文件)|*.asm";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if ((openFileDialog.ShowDialog() == DialogResult.OK)&&(openFileDialog.CheckFileExists))//打开ASM文件
            {
                try
                {
                    string fname = openFileDialog.FileName;
                    //
                    //这里加检查文件列表是否存在的
                    if (CheckASMFileIsOpened(fname))
                    {
                        MessageBox.Show("该文件已经被打开了咯~，无需打开","提示",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }
                    else
                    {
                        //               
                        Encoding ed = FileTools.EncodingInfoBOM(fname);
                        Console.WriteLine(ed);
                        if (ed.Equals(Encoding.ASCII))
                        {
                            ed = Encoding.GetEncoding("GBK");
                        }
                        
                        StreamReader streamReader = new StreamReader(fname, ed);
                        string sourceContent = streamReader.ReadToEnd();
                        streamReader.Close();
                        CodeFile cdNew = new CodeFile(fname, ed, sourceContent);
                        Opened.Add(cdNew);//添加到被打开的文件序列里面
                        MainForm.instance.Invoke_Open2Editor(MainForm.instance.Open2Editor,cdNew.SourceContent);//调用委托更新UI
                        EditingFile = Opened[Opened.Count - 1];
                    }
                }
                catch (IOException _ioe)
                {
                    MessageBox.Show("文件打开失败！", "错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    Console.WriteLine(_ioe);
                }
            }
        }
        public bool CheckASMFileIsOpened(string fname)//检查代码文件是否已经被打开
        {
            for(int i = 0; i < Opened.Count; i++)
            {
                if (Opened[i].SourcePath.Equals(fname))
                {
                    return true;
                }
            }
            return false;
        }
        
        public int GetASMFileOpened(string FnameID)
        {
            for (int i = 0; i < Opened.Count; i++)
            {
                if (Opened[i].SourcePath.Equals(FnameID))
                {
                    return i;
                }
            }
            return -1;
        }
        
        public void TmpSaveASMFileOpened(string newContent)//暂存编辑器文件
        {
            if (EditingFile != null)
            {
                EditingFile.CurrentContent = newContent;
            }
        }


        public void SaveASASMFile(int tarFnameID)//另存为选中的文件
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "(*.asm文件)|*.asm";
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FilterIndex = 1;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Stream myStream;
                if ((myStream = saveFileDialog.OpenFile()) != null)
                {
                    using (StreamWriter sw = new StreamWriter(myStream,Encoding.UTF8))
                    {
                        sw.Write(Opened[tarFnameID].CurrentContent);
                    }
                }
                Opened[tarFnameID].Cur2SourceContent();//把文件的Cur文件内容保存到Source内容中
                Opened[tarFnameID].SourcePath = saveFileDialog.FileName;
                Opened[tarFnameID].FileEncoding = Encoding.UTF8;
                Opened[tarFnameID].Path2SingleName();//从路径中提取新的文件名字，该函数必须在SourcePath被更新之后使用
                Console.WriteLine("saveFileDialog.FileName:" + saveFileDialog.FileName + ",Opened[tarFnameID].SourcePath:"+ Opened[tarFnameID].SourcePath);
                History.Add(Opened[tarFnameID]);//添加到历史记录
            }
        }
        public void CloseASMFileOpened(int tarFnameID)//关闭一个单独的代码文件
        {
            int index = tarFnameID;
            if (Opened[index].isModified())
            {
                DialogResult result = MessageBox.Show("你的文件尚未保存，请问是否保存？", "警告：", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result.Equals(DialogResult.Yes))//假如选择了保存到文件
                {
                    SaveASMFile(index);
                    //假如在另存为文件的时候选择了取消
                    //则不出栈
                }
                else if (result.Equals(DialogResult.No))//选择不保存
                {
                    Opened.RemoveAt(index);
                    //假如被清空最后一个文件，自动新建一个文件
                    if (Opened.Count == 0)
                    {
                        NewASMFile();
                        newFileIndex = 1;
                    }
                    EditingFile = Opened[0];
                }
            }
            else//假如没有修改直接关闭
            {
                Opened.RemoveAt(index);
                //假如被清空最后一个文件，自动新建一个文件
                if (Opened.Count == 0)
                {
                    NewASMFile();
                    newFileIndex = 1;
                }
                EditingFile = Opened[0];
            }
        }
        public void SaveASMFile(int tarFnameID)//保存选中的文件
        {
            try {
                if (File.Exists(Opened[tarFnameID].SourcePath))
                {
                    FileStream fs = new FileStream(Opened[tarFnameID].SourcePath, FileMode.Create, FileAccess.ReadWrite); //可以指定盘符，也可以指定任意文件名
                    StreamWriter sw = new StreamWriter(fs, Encoding.UTF8); // 创建写入流
                    sw.Write(Opened[tarFnameID].CurrentContent);//以UTF8编码写入代码文件
                    sw.Close(); //关闭文件
                    Console.WriteLine("保存成功");
                }
                else//假如保存的文件不在目录了
                {
                    SaveASASMFile(tarFnameID);//启动另存为
                }
             
            }
            catch (Exception _e)
            {
                MessageBox.Show("保存文件出现错误，可能文件被其他程序占用，请尝试关闭相关进程","错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Console.WriteLine(_e);
            }
            finally
            {
                Opened[tarFnameID].Cur2SourceContent();//把文件的Cur文件内容保存到Source内容中
                Opened[tarFnameID].FileEncoding = Encoding.UTF8;
                Opened[tarFnameID].Path2SingleName();//从路径中提取新的文件名字，该函数必须在SourcePath被更新之后使用
                History.Add(Opened[tarFnameID]);//添加到历史记录
                //Console.WriteLine(Opened[tarFnameID].FileName);
            }
        }
        public string SwitchASMFileEditing(int targetFnameID)//切换文件在编辑器的显示(重载2)
        {
            EditingFile = Opened[targetFnameID];
            return EditingFile.CurrentContent;
        }
        public void NewASMFile()//新建文件
        {
            Console.WriteLine(newFileIndex);
            CodeFile cdNew = new CodeFile(Environment.CurrentDirectory + @"\新建ASM文件"+newFileIndex.ToString()+".asm", Encoding.UTF8,MASM_SCAU.configs.ASMScripts.Default.newCodeScript);
            cdNew.SourceContent = "";
            newFileIndex++;
            Opened.Add(cdNew);
        }

        public int GetEditingID()
        {
            return GetASMFileOpened(EditingFile.SourcePath);
        }
    }
}