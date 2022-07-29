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
            //ѡ��XLSX�ļ�
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "*.xlsx(Excel�ļ�)|*.xlsx|*.xls(Excel�ļ�)|*.xls";
            //ȷ�϶�ȡ
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //·�����������������
                IptFilePath.Text = openFileDialog.FileName;
            }
        }
        private void BtnSure_Click(object sender, EventArgs e)
        {
            ExcelTools excelTools = new ExcelTools();
            DataTable dt = excelTools.GetExcelTableByOleDB(IptFilePath.Text, "Sheet1");
            dataGridView1.DataSource = dt;

            //ת��������
            GoodsData.GoodsNameList = dt.AsEnumerable().Select(d => d.Field<string>("��Ʒ����")).ToList();
            GoodsData.GoodsCodeList = dt.AsEnumerable().Select(d => d.Field<string>("��Ʒ����")).ToList();
        }


        private void BtnToCompounForm_Click(object sender, EventArgs e)
        {
            if(GoodsData.GoodsNameList == null || GoodsData.GoodsCodeList ==null)
            {
                MessageBox.Show("���ȶ�ȡ��ȷ��Excel", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CompounForm compounForm = new CompounForm();
                compounForm.ShowDialog();
            }
        }
    }
}