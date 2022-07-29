using MCDataPacksCreater.Data;
using MCDataPacksCreater.Tools;
using MCDataPacksCreater.Windows;
using System.Data;

namespace MCDataPacksCreater
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnFileBrowser_Click(object sender, EventArgs e)
        {
            //选择XLSX文件
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "*.xlsx(Excel文件)|*.xlsx|*.xls(Excel文件)|*.xls";
            //确认读取
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //路径输入至输入框内容
                IptFilePath.Text = openFileDialog.FileName;
            }
        }
        private void BtnSure_Click(object sender, EventArgs e)
        {
            ExcelTools excelTools = new ExcelTools();
            DataTable dt = excelTools.GetExcelTableByOleDB(IptFilePath.Text, "Sheet1");
            dataGridView1.DataSource = dt;

            //转化并存入
            GoodsData.GoodsNameList = dt.AsEnumerable().Select(d => d.Field<string>("物品名称")).ToList();
            GoodsData.GoodsCodeList = dt.AsEnumerable().Select(d => d.Field<string>("物品代码")).ToList();
        }


        private void BtnToCompounForm_Click(object sender, EventArgs e)
        {
            if(GoodsData.GoodsNameList == null || GoodsData.GoodsCodeList ==null)
            {
                MessageBox.Show("请先读取正确的Excel", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CompounForm compounForm = new CompounForm();
                compounForm.ShowDialog();
            }
        }
    }
}