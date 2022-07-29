using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCDataPacksCreater.Tools
{
    internal class ExcelTools
    {
        public DataTable GetExcelTableNames(string strExcelPath)
        {
            try
            {
                DataTable dtExcel = new DataTable();
                //数据表
                DataSet ds = new DataSet();
                //获取文件扩展名
                string strExtension = Path.GetExtension(strExcelPath);
                string strFileName = Path.GetFileName(strExcelPath);
                //Excel的连接
                OleDbConnection objConn = null;
                switch (strExtension)
                {
                    case ".xls":
                        objConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + strExcelPath + ";" + "Extended Properties=\"Excel 8.0;HDR=yes;IMEX=1;\"");
                        break;
                    case ".xlsx":
                        objConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + strExcelPath + ";" + "Extended Properties=\"Excel 12.0;HDR=yes;IMEX=1;\"");//此连接可以操作.xls与.xlsx文件 (支持Excel2003 和 Excel2007 的连接字符串)  备注： "HDR=yes;"是说Excel文件的第一行是列名而不是数，"HDR=No;"正好与前面的相反。"IMEX=1 "如果列中的数据类型不一致，使用"IMEX=1"可必免数据类型冲突。 
                        break;
                    default:
                        objConn = null;
                        break;
                }
                if (objConn == null)
                {
                    return null;
                }
                objConn.Open();
                //获取Excel中所有Sheet表的信息
                DataTable schemaTable = objConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                //string lstSheetNames;
                List<string> lstSheetNames = new List<string>();

                for (int i = 0; i < schemaTable.Rows.Count; i++)
                {
                    string strSheetName = (string)schemaTable.Rows[i]["TABLE_NAME"];
                    if (strSheetName.Contains("$") && !strSheetName.Replace("'", "").EndsWith("$"))
                    {
                        //过滤无效SheetName完毕....
                        continue;
                    }
                    if (lstSheetNames != null && !lstSheetNames.Contains(strSheetName))
                        strSheetName = strSheetName.Replace("$", "").Replace("'", "");
                    lstSheetNames.Add(strSheetName);
                }
                objConn.Close();
                return dtExcel;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\r\n" + ex.StackTrace);
                return null;
            }
        }

        public DataTable GetExcelTableByOleDB(string strExcelPath, string tableName)
        {
            try
            {
                DataTable dtExcel = new DataTable();
                //数据表
                DataSet ds = new DataSet();
                //获取文件扩展名
                string strExtension = Path.GetExtension(strExcelPath);
                string strFileName = Path.GetFileName(strExcelPath);
                //Excel的连接
                OleDbConnection objConn = null;
                switch (strExtension)
                {
                    case ".xls":
                        objConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + strExcelPath + ";" + "Extended Properties=\"Excel 8.0;HDR=yes;IMEX=1;\"");
                        break;
                    case ".xlsx":
                        objConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + strExcelPath + ";" + "Extended Properties=\"Excel 12.0;HDR=yes;IMEX=1;\"");//此连接可以操作.xls与.xlsx文件 (支持Excel2003 和 Excel2007 的连接字符串)  备注： "HDR=yes;"是说Excel文件的第一行是列名而不是数，"HDR=No;"正好与前面的相反。"IMEX=1 "如果列中的数据类型不一致，使用"IMEX=1"可必免数据类型冲突。 
                        break;
                    default:
                        objConn = null;
                        break;
                }
                if (objConn == null)
                {
                    return null;
                }
                objConn.Open();
                //获取Excel中所有Sheet表的信息
                DataTable schemaTable = objConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                //获取Excel的第一个Sheet表名
                string tableName1 = schemaTable.Rows[0][2].ToString().Trim();


                //string lstSheetNames;
                List<string> lstSheetNames = new List<string>();

                for (int i = 0; i < schemaTable.Rows.Count; i++)
                {
                    string strSheetName = (string)schemaTable.Rows[i]["TABLE_NAME"];
                    if (strSheetName.Contains("$") && !strSheetName.Replace("'", "").EndsWith("$"))
                    {
                        //过滤无效SheetName完毕....
                        continue;
                    }
                    if (lstSheetNames != null && !lstSheetNames.Contains(strSheetName))
                        //MessageBox.Show(strSheetName);
                        lstSheetNames.Add(strSheetName);
                }
                //MessageBox.Show(lstSheetNames[0]);

                string strSql = "select * from [" + tableName + "$]";
                // string strSql = "select 分院名称,城区,地址 from [" + tableName + "$]";
                //获取Excel指定Sheet表中的信息
                OleDbCommand objCmd = new OleDbCommand(strSql, objConn);
                OleDbDataAdapter myData = new OleDbDataAdapter(strSql, objConn);
                myData.Fill(ds, tableName);//填充数据
                objConn.Close();
                //dtExcel即为excel文件中指定表中存储的信息
                dtExcel = ds.Tables[tableName];
                return dtExcel;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\r\n" + ex.StackTrace);
                return null;
            }
        }
    }
}
