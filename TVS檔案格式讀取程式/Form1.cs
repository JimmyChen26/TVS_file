using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace TVS檔案格式讀取程式
{
    public partial class frmTSVFile : Form
    {
        /// <summary>
        /// 單字清單
        /// </summary>
        private WordCollection _WordList = new WordCollection();

        public frmTSVFile()
        {
            InitializeComponent();

            // 如果你已經在設計畫面雙擊產生事件，這幾行可以不要重複加
            this.Load += frmTSVFile_Load;
            this.FormClosing += frmTSVFile_FormClosing;
            OpenToolStripMenuItem.Click += tsmiOpen_Click;
            exitToolStripMenuItem.Click += tsmiExit_Click;
            aboutToolStripMenuItem.Click += tsmiAbout_Click;
            
        }

        /// <summary>
        /// 表單載入
        /// </summary>
        private void frmTSVFile_Load(object sender, EventArgs e)
        {
            toolStripLabel1.Text = "請開啟檔案";

            // 保險起見，用程式設定 ListView 屬性
            lvwWord.View = View.Details;
            lvwWord.FullRowSelect = true;
            lvwWord.GridLines = true;

            // 如果設計畫面還沒加欄位，這裡自動補上
            if (lvwWord.Columns.Count == 0)
            {
                lvwWord.Columns.Add("單字", 100);
                lvwWord.Columns.Add("音標", 120);
                lvwWord.Columns.Add("音檔路徑", 180);
                lvwWord.Columns.Add("解釋", 350);
            }
        }

        /// <summary>
        /// 開啟 TSV 或 TXT 檔案
        /// </summary>
        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "TSV files (*.tsv)|*.tsv|Text files (*.txt)|*.txt|All files (*.*)|*.*";
            ofd.Title = "開啟檔案";
            ofd.InitialDirectory = Application.StartupPath;

            DialogResult dr = ofd.ShowDialog(this);

            if (dr == DialogResult.OK)
            {
                try
                {
                    string[] lines;

                    // 先用 UTF8 讀取
                    // 如果你的音標亂碼，再把 Encoding.UTF8 改成 Encoding.Unicode
                    lines = File.ReadAllLines(ofd.FileName, Encoding.UTF8);

                    _WordList.LoadFromStringArray(lines);

                    UpdateListView();

                    toolStripLabel1.Text = $"已載入 {_WordList.Count} 筆單字資料";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "讀取檔案失敗：\n" + ex.Message,
                        "錯誤",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        /// <summary>
        /// 更新 ListView 的內容
        /// </summary>
        private void UpdateListView()
        {
            lvwWord.BeginUpdate();

            lvwWord.Items.Clear();

            foreach (WordItem item in _WordList)
            {
                ListViewItem lvi = new ListViewItem(item.Word);

                lvi.SubItems.Add(item.Phonogram);
                lvi.SubItems.Add(item.SoundPath);
                lvi.SubItems.Add(item.Explain);

                lvwWord.Items.Add(lvi);
            }

            lvwWord.EndUpdate();
        }

        /// <summary>
        /// About
        /// </summary>
        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.ShowDialog(this);
        }

        /// <summary>
        /// 結束程式
        /// </summary>
        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 關閉前確認
        /// </summary>
        private void frmTSVFile_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                "確定要離開嗎?",
                "離開",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}