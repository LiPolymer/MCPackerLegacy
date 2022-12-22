using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using CL.IO.Zip;

namespace MCPacker
{
    public partial class MCPacker : Form
    {
        public MCPacker()
        {
            InitializeComponent();
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void MCPacker_Load(object sender, EventArgs e)
        {
            if (Directory.Exists(".\\.minecraft"))
            {
                if (!File.Exists(".\\.minecraft\\packer.ver"))
                {
                    FileStream fs = File.Create(".\\.minecraft\\packer.ver");
                    fs.Close();
                }
                if (File.Exists(".\\def.list"))
                {
                    ilistbox.Text = File.ReadAllText(".\\def.list");
                }
            }
            else
            {
                MessageBox.Show(".minecraft文件夹未找到!\r\n请将本程序放在启动器目录下！","MCPr-ERROR");
                Environment.Exit(0);
            }
            verl.Text = File.ReadAllText(".\\.minecraft\\packer.ver");
            verbox.Text = verl.Text;
        }

        private void iwayselector_Scroll(object sender, EventArgs e)
        {
            if (iwayselector.Value == 0)
            {
                iwayname.Text = "ZIP";
                ilaunchercb.Enabled = true;
                pkgnamebox.Visible = false;
                pkgnamel.Visible = false;
            }
            if (iwayselector.Value == 1)
            {
                iwayname.Text = "SDP";
                ilaunchercb.Checked = false;
                ilaunchercb.Enabled = false;
                pkgnamebox.Visible = true;
                pkgnamel.Visible = true;
            }
            if (iwayselector.Value == 2)
            {
                iwayname.Text = "HMCL";
                ilaunchercb.Enabled = true;
                pkgnamebox.Visible = false;
                pkgnamel.Visible = false;
            }
            if (iwayselector.Value == 3)
            {
                iwayname.Text = "Mod与配置";
                ilaunchercb.Checked = false;
                ilaunchercb.Enabled = false;
                pkgnamebox.Visible = false;
                pkgnamel.Visible = false;
            }
            if (iwayselector.Value == 4)
            {
                iwayname.Text = "Mod,配置,资源包";
                ilaunchercb.Checked = false;
                ilaunchercb.Enabled = false;
                pkgnamebox.Visible = false;
                pkgnamel.Visible = false;
            }
            if (iwayselector.Value == 5)
            {
                iwayname.Text = "仅Mod";
                ilaunchercb.Checked = false;
                ilaunchercb.Enabled = false;
                pkgnamebox.Visible = false;
                pkgnamel.Visible = false;
            }
        }

        private void useworkfloderbox_CheckedChanged(object sender, EventArgs e)
        {
            if (!useworkfloderbox.Checked)
            {
                ilistgroup.Enabled = false;
                MessageBox.Show("暂时不支持关闭!", "WARN");
                useworkfloderbox.Checked = true;
            }
            if (useworkfloderbox.Checked)
            {
                ilistgroup.Enabled = true;
            }
        }

        private void ilistsavebtn_Click(object sender, EventArgs e)
        {
            File.WriteAllText(ilistpath.Text,ilistbox.Text);
        }

        private void ilistloadbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = ".\\";
            openFileDialog.Filter = "文本列表|*.list|所有文件|*.*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName;
                string list = File.ReadAllText(path);
                ilistbox.Text = list;
                ilistsavebtn.Enabled = true;
                ilistpath.Text = path;
            }
        }

        private void intstartbtn_Click(object sender, EventArgs e)
        {
            qwq.Enabled = false;
            taskprog.Value = 0;
            taskprog.Maximum = 100;
            File.WriteAllText(".\\buffer.list",ilistbox.Text);
            if (iwayselector.Value == 0)
            {
                status.Text = "ZIP模式";
                bworkerzip.RunWorkerAsync();
            }
            if (iwayselector.Value == 1)
            {
                status.Text = "SDP模式";
                MessageBox.Show("开发中!可能无法正常使用!", "WARN");
                //qwq.Enabled = true;
                //status.Text = "[空闲]";
                Thread thread = new Thread(SDPacker);
                thread.Start();
            }
            if (iwayselector.Value == 2)
            {
                status.Text = "HMCL模式";
                MessageBox.Show("开发中!","qwq");
                qwq.Enabled = true;
                status.Text = "[空闲]";
            }
            if (iwayselector.Value == 3)
            {
                status.Text = "M+C模式";
                Thread thread = new Thread(MCfgPacker);
                thread.Start();
            }
            if (iwayselector.Value == 4)
            {
                status.Text = "M+C+R模式";
                Thread thread = new Thread(MCResPacker);
                thread.Start();
            }
            if (iwayselector.Value == 5)
            {
                status.Text = "Mod模式";
                Thread thread = new Thread(ModsPacker);
                thread.Start();
            }
        }

        /// <summary>
        /// 复制文件夹及文件
        /// </summary>
        /// <param name="sourceFolder">原文件路径</param>
        /// <param name="destFolder">目标文件路径</param>
        /// <returns></returns>
        private void CopyFolder(string sourceFolder, string destFolder)
        {
            task.Text = "复制文件";
            try
            {
                if (!System.IO.Directory.Exists(destFolder))
                {
                    System.IO.Directory.CreateDirectory(destFolder);
                }
                string[] files = System.IO.Directory.GetFiles(sourceFolder);
                foreach (string file in files)
                {
                    string name = System.IO.Path.GetFileName(file);
                    string dest = System.IO.Path.Combine(destFolder, name);
                    System.IO.File.Copy(file, dest);
                }
                string[] folders = System.IO.Directory.GetDirectories(sourceFolder);
                foreach (string folder in folders)
                {
                    string name = System.IO.Path.GetFileName(folder);
                    string dest = System.IO.Path.Combine(destFolder, name);
                    CopyFolder(folder, dest);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message,"MPr-ERROR") ;
            }
        }

        private void Zippp(string sourceFolder, string outputPath)
        {
            if (!Directory.Exists(".\\output"))
            {
                Directory.CreateDirectory(".\\output");
            }
            taskprog.Maximum = 100;
            ZipHandler handler = ZipHandler.GetInstance();
            handler.PackDirectory(sourceFolder, outputPath, (num) => { taskprog.Value = Convert.ToInt32(num); task.Text = "压缩中[" + Convert.ToString(num) + "%]"; });
        }

        private void ModsPacker()
        {
            task.Text = "清理...";
            try
            {
                Directory.Delete(".\\working", true);
            }
            catch { }
            CopyFolder(".\\.minecraft\\mods", ".\\working\\.minecraft\\mods");
            string[] delist = File.ReadAllLines(".\\buffer.list");
            deleter(delist);
            Zippp(".\\working\\.minecraft\\mods", ".\\output\\mods_" + verbox.Text + ".zip");
            task.Text = "清理...";
            try
            {
                Directory.Delete(".\\working", true);
            }
            catch { }
            task.Text = "完成!";
            qwq.Enabled = true;
            status.Text = "[空闲]";
        }

        private void MCfgPacker()
        {
            task.Text = "清理...";
            try
            {
                Directory.Delete(".\\working", true);
            }
            catch { }
            CopyFolder(".\\.minecraft\\mods", ".\\working\\.minecraft\\mods");
            CopyFolder(".\\.minecraft\\config", ".\\working\\.minecraft\\config");
            string[] delist = File.ReadAllLines(".\\buffer.list");
            deleter(delist);
            Zippp(".\\working\\.minecraft", ".\\output\\mods_" + verbox.Text + ".zip");
            task.Text = "清理...";
            try
            {
                Directory.Delete(".\\working", true);
            }
            catch { }
            task.Text = "完成!";
            qwq.Enabled = true;
            status.Text = "[空闲]";
        }

        private void MCResPacker()
        {
            task.Text = "清理...";
            try
            {
                Directory.Delete(".\\working", true);
            }
            catch { }
            CopyFolder(".\\.minecraft\\mods", ".\\working\\.minecraft\\mods");
            CopyFolder(".\\.minecraft\\config", ".\\working\\.minecraft\\config");
            CopyFolder(".\\.minecraft\\resourcepacks", ".\\working\\.minecraft\\resourcepacks");
            string[] delist = File.ReadAllLines(".\\buffer.list");
            deleter(delist);
            Zippp(".\\working\\.minecraft", ".\\output\\mods+res_" + verbox.Text + ".zip");
            task.Text = "清理...";
            try
            {
                Directory.Delete(".\\working", true);
            }
            catch { }
            task.Text = "完成!";
            qwq.Enabled = true;
            status.Text = "[空闲]";
        }

        private void SDPIGen(string ver,string name,string outpath)
        {
            task.Text = "生成信息";
            if (!System.IO.Directory.Exists(outpath))
            {
                System.IO.Directory.CreateDirectory(outpath);
            }
            string[] info = {name,ver,"dev.inf",ver,"f"};
            File.WriteAllLines(outpath + "\\install.set", info);
        }

        private void SDPacker()
        {
            task.Text = "清理...";
            try
            {
                Directory.Delete(".\\working", true);
            }
            catch { }
            CopyFolder(".\\.minecraft", ".\\working\\.minecraft");
            string[] delist = File.ReadAllLines(".\\buffer.list");
            deleter(delist);
            SDPIGen(verbox.Text, pkgnamebox.Text, ".\\working\\.minecraft\\installinfo");
            Zippp(".\\working\\.minecraft", ".\\output\\Full_" + verbox.Text + ".sdp");
            task.Text = "清理...";
            try
            {
                Directory.Delete(".\\working", true);
            }
            catch { }
            task.Text = "完成!";
            qwq.Enabled = true;
            status.Text = "[空闲]";
        }

        private void deleter(string[] list)
        {
            try
            {
                task.Text = "删除文件";
                taskprog.Value = 0;
                taskprog.Maximum = list.Length;
                foreach (string file in list)
                {
                    string filep = @".\working\" + file;
                    taskprog.Value ++;
                    //if (File.Exists(filep))
                    if (true)
                    {
                        FileAttributes attr = File.GetAttributes(filep);
                        if (attr == FileAttributes.Directory)
                        {
                            Directory.Delete(filep, true);
                        }
                        else
                        {
                            File.Delete(filep);
                        }
                    }
                }
            }
            catch
            {

            }
        }

        private void bwokerzip_DoWork(object sender, DoWorkEventArgs e)
        {
            task.Text = "清理...";
            try
            {
                Directory.Delete(".\\working", true);
            }
            catch { }
            CopyFolder(".\\.minecraft",".\\working\\.minecraft");
            string[] delist = File.ReadAllLines(".\\buffer.list");
            if (ilaunchercb.Checked)
            {
                string name = System.IO.Path.GetFileName(launchernamebox.Text);
                string dest = System.IO.Path.Combine(".\\working", name);
                System.IO.File.Copy(launchernamebox.Text, dest);
            }
            deleter(delist);
            Zippp(".\\working",".\\output\\output_" + verbox.Text + ".zip");
            task.Text = "清理...";
            try
            {
                File.Delete(".\\buffer.list");
                Directory.Delete(".\\working", true);
            }
            catch { }
            task.Text = "完成!";
            qwq.Enabled = true;
            status.Text = "[空闲]";
        }

        private void verbox_TextChanged(object sender, EventArgs e)
        {
            File.WriteAllText(".\\.minecraft\\packer.ver", verbox.Text);
        }

        private void verl_Click(object sender, EventArgs e)
        {

        }

        private void dellogsbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Directory.Delete(".\\.minecraft\\logs", true);
            }
            catch { }
        }

        private void delsvrdatbtn_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete(".\\.minecraft\\servers.dat");
                File.Delete(".\\.minecraft\\servers.dat_old");
            }
            catch { }
        }

        private void delcrptbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Directory.Delete(".\\.minecraft\\crash-reports", true);
            }
            catch { }
        }

        private void ilaunchercb_CheckedChanged(object sender, EventArgs e)
        {
            if (!ilaunchercb.Checked)
            {
                launchernamebox.Enabled = false;
            }
            if (ilaunchercb.Checked)
            {
                launchernamebox.Enabled = true;
            }
        }

        private void MCPacker_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void turntogh_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Li3Fish/MCPacker");
        }
    }
}
