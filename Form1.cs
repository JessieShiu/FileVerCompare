using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace FileVerCompare
{
    public partial class Form1 : Form
    {
        private string NOW => DateTime.Now.ToString("yyyy-MM-dd mm:ss");

        List<DataModel> Datas = new List<DataModel>();
        private string SrcFolder => txtSrcPath.Text.Trim();
        private string ServerFolder => txtServerPath.Text.Trim();
        private string BackupFolder => txtBackupPath.Text.Trim();
        public Form1()
        {
            InitializeComponent();
            dgvResult.AutoGenerateColumns = false;
            txtServerPath.Text = ConfigurationManager.AppSettings["SrvPath"];
            txtBackupPath.Text = ConfigurationManager.AppSettings["BakPath"];
        }

        private void btnSelSrc_Click(object sender, EventArgs e)
        {
            var path = OpenFolderDialog();
            if (!string.IsNullOrWhiteSpace(path))
            {
                txtSrcPath.Text = path;
            }
           
        }

        private void btnSelDest_Click(object sender, EventArgs e)
        {
            var path = OpenFolderDialog();
            if (!string.IsNullOrWhiteSpace(path))
            {
                txtServerPath.Text = path;
            }
        }

        private void btnSelBk_Click(object sender, EventArgs e)
        {
            var path = OpenFolderDialog();
            if (!string.IsNullOrWhiteSpace(path))
            {
                txtBackupPath.Text = path;
            }
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            GetData();          
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(BackupFolder))
            {
                MessageBox.Show("請輸入備份路徑!");
                return;
            }

            if (Datas.Count == 0)
            {
                if (!GetData()) return;
            }

            txtMsg.AppendText($"{NOW}開始備份.....{Environment.NewLine}");

            Task.Factory.StartNew(() =>
            {
                string topBKFolder = Path.Combine(BackupFolder, DateTime.Now.ToString("yyyyMMdd"));
                if (!Directory.Exists(topBKFolder))
                    Directory.CreateDirectory(topBKFolder);

                Datas.ForEach(path =>
                {
                    string servPath = path.FullPath.Replace(SrcFolder, ServerFolder);
                    string bkPath = path.FullPath.Replace(SrcFolder, topBKFolder);

                    try
                    {
                        if (path.IsFolder)
                        {
                            if (!Directory.Exists(bkPath))
                                Directory.CreateDirectory(bkPath);
                        }
                        else
                        {
                            if (File.Exists(servPath))
                            {
                                this.BeginInvoke((Action)(()=> { txtMsg.AppendText($"{NOW} COPY {servPath} to {bkPath}{Environment.NewLine}"); }));
                                File.Copy(servPath, bkPath, true);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        this.BeginInvoke((Action)(() => { txtMsg.AppendText($"錯誤訊息: {ex.Message} {Environment.NewLine}"); }));
                    }

                });

                this.BeginInvoke((Action)(() => { txtMsg.AppendText($"{NOW} 備份完成... {Environment.NewLine}"); }));
                MessageBox.Show("備份完成!");

            });
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("是否確定更新?", "警告",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning);

            if (result == DialogResult.No) return;

            MessageBox.Show("建構中!");
        }

        private bool GetData()
        {
            Datas.Clear();

            if (string.IsNullOrWhiteSpace(SrcFolder) || string.IsNullOrWhiteSpace(ServerFolder))
            {
                MessageBox.Show("請輸入來源路徑及目的路徑!");
                return false;
            }

            var folders = Directory.GetDirectories(SrcFolder, "*", SearchOption.AllDirectories)
                                    .Select(f => new DataModel
                                    {
                                        IsFolder = true,
                                        Name = Path.GetFileName(f),
                                        FullPath = f,
                                    }).ToList();

            var files = Directory.GetFiles(SrcFolder, "*.*", SearchOption.AllDirectories)
                                .Select(f =>
                                {
                                    var rtn = new DataModel
                                    {
                                        IsFolder = false,
                                        Name = $"　{Path.GetFileName(f)}",
                                        FullPath = f,
                                    };

                                    var versInfo = GetVersion(f, out string version);
                                    if (!string.IsNullOrWhiteSpace(version))
                                    {
                                        rtn.SrcVer = version;
                                        rtn.SrcVers = versInfo;

                                        //取目的檔案Version
                                        string destPath = f.Replace(SrcFolder, ServerFolder);
                                        FileInfo fi = new FileInfo(destPath);
                                        if (File.Exists(destPath))
                                        {
                                            rtn.IsDestExist = true;
                                            var destVerInfo = GetVersion(destPath, out string destVersion);
                                            if (!string.IsNullOrWhiteSpace(destVersion))
                                            {
                                                rtn.DestVer = destVersion;
                                                rtn.DestVers = destVerInfo;
                                            }
                                        }
                                    }
                                    return rtn;
                                });

            Datas = folders.Concat(files).OrderBy(x => x.FullPath).ToList();

            dgvResult.DataSource = Datas;
            dgvResult.Refresh();

            return true;
        }

        private Dictionary<string, int> GetVersion(string path, out string version)
        {
            var result = new Dictionary<string, int>();
            version = "";
            var versInfo = FileVersionInfo.GetVersionInfo(path);

            if (!string.IsNullOrEmpty(versInfo.FileVersion))
                version = $"{versInfo.FileMajorPart}.{versInfo.FileMinorPart}.{versInfo.FileBuildPart}.{versInfo.FilePrivatePart}";

            result.Add("Major", versInfo.FileMajorPart);
            result.Add("Minor", versInfo.FileMinorPart);
            result.Add("Build", versInfo.FileBuildPart);
            result.Add("Private", versInfo.FilePrivatePart);

            return result;
        }

        public static string OpenFolderDialog(string defaultFolder = "")
        {
            using (var fbd = new FolderBrowserDialog())
            {
                fbd.SelectedPath = defaultFolder;
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK)
                {
                    return fbd.SelectedPath;
                }
            }
            return "";
        }

        private void dgvResult_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (Datas.Count == 0) return;

            if (e.ColumnIndex == 1)
            {
                var data = Datas[e.RowIndex];
                if (data.IsFolder)
                    e.Value = Properties.Resources.folder_icon;
            }            
            else if (e.ColumnIndex == 3 && e.Value != null)
            {
                var data = Datas[e.RowIndex];

                if (!data.IsUpdate)
                {
                    e.CellStyle.ForeColor = Color.Red;
                    dgvResult.Rows[e.RowIndex].Cells[0].Value = false;
                }
            }
        }

        private void dgvResult_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvResult.Rows)
            {
                var data = Datas[row.Index];

                if (data.IsFolder || !data.IsDestExist) continue;

                bool update = true;
                if (data.DestVers["Major"] > data.SrcVers["Major"]) update = false;
                else if (data.DestVers["Major"] == data.SrcVers["Major"])
                {
                    if (data.DestVers["Minor"] > data.SrcVers["Minor"]) update = false;
                    else if (data.DestVers["Minor"] == data.SrcVers["Minor"])
                    {
                        if (data.DestVers["Build"] > data.SrcVers["Build"]) update = false;
                        else if (data.DestVers["Build"] == data.SrcVers["Build"])
                        {
                            if (data.DestVers["Private"] > data.SrcVers["Private"]) update = false;
                        }
                    }
                }
                data.IsUpdate = update;
            }
        }
    }

    public class DataModel
    {
        public bool IsFolder { get; set; }
        public string Name { get; set; }
        public string FullPath { get; set; }
        public string SrcVer { get; set; }
        public Dictionary<string, int> SrcVers { get; set; }
        public string DestVer { get; set; }
        public Dictionary<string, int> DestVers { get; set; }
        public bool IsUpdate { get; set; } = true;
        public bool IsDestExist { get; set; }
    }

}
