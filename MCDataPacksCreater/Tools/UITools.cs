using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCDataPacksCreater.Tools
{
    internal class UITools
    {
        /// <summary>
        /// combobox搜索功能
        /// </summary>
        /// <param name="cb"></param>
        /// <param name="strList"></param>
        public static void TextUpdate(ComboBox cb, List<string> strList)
        {
            string s = cb.Text;  //获取cb_material控件输入内
            List<string[]> strListNew = new List<string[]>();
            //清空combobox
            cb.DataSource = null;
            cb.Items.Clear();
            //遍历全部原始数据
            foreach (var item in strList)
            {
                // 根据输入的值模糊查询,将符合条件的值存储到新strListNew的集合里面
                if (item.Contains(s))
                {
                    strListNew.Add(new string[] { "", item });
                }
            }
            if (strListNew.Count >= 1) // 存在符合条件的内容
            {
                //将符合条件的内容加到combobox中
                //this.ComCB.Items.AddRange(strListNew.ToArray());
                GetComCB(cb, strListNew);
            }
            // 不存在符合条件时
            //设置光标位置，若不设置：光标位置始终保持在第一列，造成输入关键词的倒序排列
            cb.SelectionStart = cb.Text.Length;  // 设置光标位置，若不设置：光标位置始终保持在第一列，造成输入关键词的倒序排列
            //cb.Cursor = Cursors.Default; //保持鼠标指针原来状态，有时候鼠标指针会被下拉框覆盖，所以要进行一次设置
            cb.DroppedDown = true; // 自动弹出下拉框
            cb.MaxDropDownItems = 8; // 自动弹出下拉框
        }

        /// <summary>
        /// 设置combobox的item值
        /// </summary>
        /// <param name="cb">ComboBox</param>
        public static void GetComCB(ComboBox cb, List<string[]> res)
        {
            ArrayList mylist = new ArrayList();
            foreach (var item in res)
            {
                mylist.Add(item[1]);
            }
            cb.Items.AddRange(mylist.ToArray());
        }



    }
}
