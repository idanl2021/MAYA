using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;


// יש לשנות
namespace IdanLalezari326643269.DATA
{
    class DAL
    {   
        public static DataSet ds; //אוביקט לאיחזור נתונים 
        public static OleDbConnection objConn; // Connection אוביקט
        public static OleDbDataAdapter da;

        public static void GetDataSet(string sqlStr)
        {

            // בונה את מחרוזת הקישור
            // string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=6point.mdb";
            string strConn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=IdanLalezari326643269.accdb";
            // מאתחל חיבור לבסיס הנתונים
            objConn = new OleDbConnection(strConn);
            // DataSet מאתחל אוביקט מסוג 
            ds = new DataSet();
            // מבצעה את השאילתה

            da = new OleDbDataAdapter(sqlStr, strConn);
            // DataSet טוען את תוצאת השאילתה לתוך 

            try
            {
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

            }
        }
        public static DataTable OpenTable(string tableName)
        {
            try
            {
                try
                {
                    GetDataSet("Select * from " + tableName);//פתיחת טבלה 
                }
                catch (Exception ex)
                {
                    LOGGER.Logger.PrintLog("error in OpenTable() func: " + ex.Message, ENUM.Enums.LogType.Error);
                }
                return (ds.Tables[0]);
            }
            catch (Exception ex)
            {
                LOGGER.Logger.PrintLog(ex.Message, ENUM.Enums.LogType.Error);
                throw ex;
            }

        }

        public static DataTable GetSqlTable(string sql)
        {
            GetDataSet(sql);//פתיחת טבלה 
            return (ds.Tables[0]);
        }

        //a function that insert a new row to the table in the access database 
        public static void InsertRow(string tableName, Dictionary<string, string> dict)
        {
            try
            {
                //TODO: TEST!!!!

                //add the new row that contains the new data in dict to the table
                DataRow dr = ds.Tables[tableName].NewRow();
                foreach (KeyValuePair<string, string> kvp in dict)
                {
                    dr[kvp.Key] = kvp.Value;
                }
                ds.Tables[tableName].Rows.Add(dr);
                //update the database
                da.Update(ds, tableName);

            }
            catch (Exception ex)
            {
                LOGGER.Logger.PrintLog("error in InsertRow() func: " + ex.Message, ENUM.Enums.LogType.Error);
            }
        }
    }
}

