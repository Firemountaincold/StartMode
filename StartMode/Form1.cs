using System;
using System.IO;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace StartMode
{
    public partial class Form1 : Form
    {
        public bool selfstart = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonwork_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("work.a");
                while (!sr.EndOfStream)
                {
                    string exew = sr.ReadLine();
                    ProcessStartInfo infow = new ProcessStartInfo(exew);
                    Process prow = new Process();
                    prow.StartInfo = infow;
                    prow.Start();
                }
                sr.Close();
                System.Threading.Thread.Sleep(1000);
                Application.Exit();
                Process.GetCurrentProcess().Kill();
            }
            catch (Exception)
            {
                MessageBox.Show("请先添加要启动的文件！", "警告");
            }            
        }

        private void buttonrelax_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("relax.a");
                while (!sr.EndOfStream)
                {
                    string exer = sr.ReadLine();
                    ProcessStartInfo infor = new ProcessStartInfo(exer);
                    Process pror = new Process();
                    pror.StartInfo = infor;
                    pror.Start();
                }
                sr.Close();
                System.Threading.Thread.Sleep(1000);
                Application.Exit();
                Process.GetCurrentProcess().Kill();
            }
            catch (Exception)
            {
                MessageBox.Show("请先添加要启动的文件！", "警告");
            }
        }

        private void buttonexplorer_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpenFile = new OpenFileDialog { Filter = "可执行文件(*.exe)|*.exe" };
            if (dlgOpenFile.ShowDialog() == DialogResult.OK)//OK表示按下了“打开”
            {
                textBoxadd.Text = dlgOpenFile.FileName;
            }
        }

        private void buttonworkjoin_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("work.a", true);  
            sw.Write(textBoxadd.Text);
            sw.WriteLine();
            sw.Close();
        }

        private void buttonrelaxjoin_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("relax.a", true);
            sw.Write(textBoxadd.Text);
            sw.WriteLine();
            sw.Close();
        }

        private void buttonworkdel_Click(object sender, EventArgs e)
        {
            StreamWriter te = new StreamWriter("work.a");
            te.Close();
            StreamReader sr = new StreamReader("work.a");
            StreamWriter sw = new StreamWriter("work.temp");
            while (!sr.EndOfStream)
            {
                string exer = sr.ReadLine();
                if (exer != textBoxadd.Text)
                {
                    sw.WriteLine(exer);
                }
            }
            sr.Close();
            sw.Close();
            File.Delete("work.a");
            File.Move("work.temp", "work.a");
        }

        private void buttonrelaxdel_Click(object sender, EventArgs e)
        {
            StreamWriter te = new StreamWriter("relax.a");
            te.Close();
            StreamReader sr = new StreamReader("relax.a");
            StreamWriter sw = new StreamWriter("relax.temp");
            while (!sr.EndOfStream)
            {
                string exer = sr.ReadLine();
                if (exer != textBoxadd.Text) 
                {
                    sw.WriteLine(exer);
                }
            }
            sr.Close();
            sw.Close();
            File.Delete("relax.a");
            File.Move("relax.temp", "relax.a");
        }

        private void buttonstart_Click(object sender, EventArgs e)
        {
            string user = Environment.UserName;
            string startpath = @"C:\Users\" + user + @"\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup\";
            if (!selfstart)
            {
                CreateShortcut(startpath);
                selfstart = true;
                buttonstart.Text = "取消自启";
            }
            else
            {
                DeleteShortcut(startpath);
                selfstart = false;
                buttonstart.Text = "自启动";
            }
        }

        private static void CreateShortcut(string lnkFilePath, string args = "")
        {
            try
            {
                var shell = new IWshRuntimeLibrary.WshShell();
                var shortcut = (IWshRuntimeLibrary.IWshShortcut)shell.CreateShortcut(lnkFilePath+"StartMode.lnk");
                shortcut.TargetPath = Assembly.GetEntryAssembly().Location;
                shortcut.Arguments = args;
                shortcut.WorkingDirectory = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
                shortcut.Save();
                
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "警告");
            }
        }

        private static void DeleteShortcut(string lnkFilePath)
        {
            File.Delete(lnkFilePath + "StartMode.lnk");
        }
    }
}
