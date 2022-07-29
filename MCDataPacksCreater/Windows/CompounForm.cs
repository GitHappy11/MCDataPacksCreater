using MCDataPacksCreater.Data;
using MCDataPacksCreater.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCDataPacksCreater.Windows
{
    public partial class CompounForm : Form
    {
        public CompounForm()
        {
            InitializeComponent();
        }
     


        private void GoodsItmeOne_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GoodsItmeOne_TextUpdate(object sender, EventArgs e)
        {
            List<string> strList = new List<string>();   //存放原始数据(可以是对象，字符串...)
            foreach (string item in GoodsData.GoodsNameList)//数据库中获取的原始数据 
            {
                strList.Add(item);
            }
            Cursor = Cursors.Default; //保持鼠标指针原来状态，有时候鼠标指针会被下拉框覆盖，所以要进行一次设置
            UITools.TextUpdate(GoodsItmeOne, strList);
        }

        private void CompounForm_Load(object sender, EventArgs e)
        {
            GoodsItmeOne.Items.AddRange(GoodsData.GoodsNameList.ToArray());
        }
    }

   
}
