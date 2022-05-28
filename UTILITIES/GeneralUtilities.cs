using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using IdanLalezari326643269.DATA;
using System.Windows.Forms;

namespace IdanLalezari326643269.UTILITIES
{
    public abstract class GeneralUtilities
    {
        protected DataTable table;
        protected int currentRow;
        protected string primaryKey;
        public static int GoToFirst(DataTable table, int currentRow)
        {
            if (IsEmpty(table))
                throw new Exception("ניווט על טבלה ריקה");
            return currentRow = 0;
        }


        /// מעדכן את השורה הנוכחית לשורה האחרונה

        public static int GoToLast(DataTable table, int currentRow)
        {
            if (IsEmpty(table))
                throw new Exception("ניווט על טבלה ריקה");
            return currentRow = table.Rows.Count - 1;
        }

        /// עובר לשורה הבאה בטבלה. אם אנחנו בסוף חוזרים להתחלה

        public static int MoveNext(DataTable table, int currentRow)
        {
            if (IsEmpty(table))
                throw new Exception("ניווט על טבלה ריקה");
            return currentRow = (currentRow + 1) % table.Rows.Count;

        }

        /// moves to the previous object. If reaches the beginning, goes back
        /// to the end

        public static int MovePrev(DataTable table, int currentRow)
        {
            if (IsEmpty(table))
                throw new Exception("ניווט על טבלה ריקה");
            if (currentRow == 0)
                currentRow = currentRow+1;
            else
                --currentRow;
            return currentRow;
        }
        public static int Size(DataTable table)
        {
            return table.Rows.Count;
        }

        /// בודק האם הטבלה ריקה

        /// <returns> true if empty, false if not empty<

        public static bool IsEmpty(DataTable table)
        {
            return (table.Rows.Count == 0);
             
        }
        public static string AddRecd(DataTable table, string strSqrl)//הוספת רשומה 
        {
            DAL.GetDataSet(strSqrl);
            string st = "נתונים נשמרו";
            return st;

        }
        public static void RefrechTable(DataTable table, string tableName)
        {
            DAL.GetDataSet("Select * from  " + tableName);
            table = DAL.ds.Tables[0];
        }

        public static string UpDateRecd(DataTable table, string strSqrl)//עידכון רשומה 
        {
            DAL.GetDataSet(strSqrl);
            string st = "נתונים עודכנו";
            return st;

        }
        public static string DeleteRecd(DataTable table, string strSqrl)//מחיקת רשומה 
        {
            DAL.GetDataSet(strSqrl);
            string st = "נתונים נמחקו";
            return st;

        }

        public static string RecordExist(DataTable Table, string strSqrl)
        {
           string s;
           DAL.GetDataSet(strSqrl);
           if (DAL.ds.Tables[0].Rows.Count==0)
                 s="רשומה לא קיימת";
           else
                 s="רשומה קיימת";
        return s;
        }

        public static string GetGreetingText()
        {
            int hour = DateTime.Now.Hour;
            string greeting = "";
            if(hour >= 5 && hour < 12)
            {
                greeting = "בוקר טוב";
            }
            else if(hour >= 12 && hour < 18)
            {
                greeting = "צהריים טובים";
            }
            else if(hour >= 18 && hour < 21)
            {
                greeting = "ערב טוב";
            }
            else if(hour >= 21 && hour < 5)
            {
                greeting = "לילה טוב";
            }
            return greeting;
        }

        /// <summary>
        /// get the hour time in [hh:mm] format
        /// </summary>
        /// <returns>string</returns>
        public static string GetHourString()
        {
            string hour = DateTime.Now.Hour.ToString();
            string min = DateTime.Now.Minute.ToString();
            if (hour.Length < 2) hour = $"0{hour}";
            if (min.Length < 2) min = $"0{min}";
            return $"{hour}:{min}";
        }

        public static string GetLTRMark()
        {
            return "\u200E";
        }

        public static void addUser(string id, string userGroup)
        {
            string group = userGroup;
            DataTable Table = DAL.OpenTable("Users");
            //switch (userGroup)
            //{
            //    case ENUM.Enums.UserGroup.Principal:
            //        group = "Principal";
            //        break;
            //    case ENUM.Enums.UserGroup.Teacher:
            //        group = "Teacher";
            //        break;
            //    case ENUM.Enums.UserGroup.Student:
            //        group = "Student";
            //        break;
            //    default:
            //        break;
            //}
            string strSQL = $"INSERT INTO Users " /*(ID,Password,Group,Gender)*/ + $"VALUES ('{id}','{id}','{group}','N')";
            LOGGER.Logger.PrintLog(strSQL);
            MessageBox.Show(GeneralUtilities.AddRecd(Table, strSQL));
        }
    }
}
