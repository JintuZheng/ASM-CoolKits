using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MASM_SCAU
{
    class FixCompiler
    {
        public static string getUseablePath()
        {
            string[] paths = { "D:/", "C:/", "E:/"};
            for(int i = 0; i < paths.Length; i++)
            {
                if (Directory.Exists(paths[i]))
                {
                    return paths[i];
                }
            }
                return "null";
        }
        //修复函数
        public static void GoFix()
        {
            try
            {
                string path = getUseablePath();
                if (path.Equals("null"))
                {
                    MessageBox.Show("你的电脑没有可用驱动器！");
                    return;
                }
                Utils.CopyDirectory(Environment.CurrentDirectory + @"/ASMCompiler", path+"ASMCompiler");
                MASM_SCAU.configs.AppMainSettings.Default.CompilerPath = path+"ASMCompiler";
                MASM_SCAU.configs.AppMainSettings.Default.Save();
                MessageBox.Show("我已自动修复编译器，请减少手残行为~");
            }catch(Exception _e)
            {
                MessageBox.Show("修复失败");
            }

        }

        public static void checkNeedFix()
        {
            if (!Directory.Exists(MASM_SCAU.configs.AppMainSettings.Default.CompilerPath))
                GoFix();
        }

    }
}
