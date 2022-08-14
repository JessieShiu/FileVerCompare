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

namespace FileVerCompare1
{
    public partial class Form1 : Form
    {

        List<DataModel> Datas = new List<DataModel>();
        public Form1()
        {
            InitializeComponent();
            dgvResult.AutoGenerateColumns = false;
        }

        private void btnSelSrc_Click(object sender, EventArgs e)
        {
            txtSrcPath.Text = OpenFolderDialog();
        }

        private void btnSelDest_Click(object sender, EventArgs e)
        {
            txtDestPath.Text = OpenFolderDialog();
        }

        private void btnExec_Click(object sender, EventArgs e)
        {
            string srcFolder = txtSrcPath.Text.Trim();
            string destFolder = txtDestPath.Text.Trim();

            if (string.IsNullOrWhiteSpace(srcFolder) || string.IsNullOrWhiteSpace(destFolder))
            {
                MessageBox.Show("請輸入來源路徑及目的路徑!");
                return;
            }

            Datas.Clear();

            var folders = Directory.GetDirectories(srcFolder, "*", SearchOption.AllDirectories)
                                    .Select(f => new DataModel
                                    {
                                        IsFolder = true,
                                        Name = Path.GetFileName(f),
                                        FullPath = f,
                                    }).ToList();

            var files = Directory.GetFiles(srcFolder, "*.*", SearchOption.AllDirectories)
                                .Select(f =>
                                {
                                    var rtn =  new DataModel
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
                                        string destPath = f.Replace(srcFolder, destFolder);
                                        FileInfo fi = new FileInfo(destPath);
                                        if (File.Exists(destPath))
                                        {
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
            if (e.ColumnIndex == 3 && e.Value != null)
            {
                var data = Datas[e.RowIndex];

                if (data.DestVers["Major"] > data.SrcVers["Major"]) data.IsUpdate = false;
                else
                {
                    if (data.DestVers["Major"] > data.SrcVers["Major"]) data.IsUpdate = false;
                    else
                    {
                        if (data.DestVers["Build"] > data.SrcVers["Build"]) data.IsUpdate = false;
                        else
                        {
                            if (data.DestVers["Private"] > data.SrcVers["Private"]) data.IsUpdate = false;
                        }
                    }
                }

                if (!data.IsUpdate)
                {
                    e.CellStyle.ForeColor = Color.Red;
                    dgvResult.Rows[e.RowIndex].Cells[0].Value = false;
                }
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
    }

}
