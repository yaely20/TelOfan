using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelOfan.DAL;
using System.Data;



namespace TelOfan.BLL
{
    public abstract class GeneralTable
    {
        //מופע סטטי של מחלקת קונקט- מופע יחיד עבור כל מחלקות הרבים
        public static Connect connect = new Connect();
        protected DataTable table;
        protected List<GeneralRow> list;
        //פעולה בונה,שמקבלת שם של טבלה, מכניסה למופע של הטבלה את הטבלה שחזרה מהחיבור לאקסס - ממחלקת קוננקט
        public GeneralTable(string NameTable)
        {
            table = connect.GetTable(NameTable);
            list = new List<GeneralRow>();
        }
        public void AddItem(GeneralRow item)
        {
            //מוסיף אוביקט חדש לרשימה
            list.Add(item);
            //מאתחל את השורה להיות מסוג הטבלה אליה אנחנו נרצה להוסיף נתונים
            item.row = table.NewRow();
            //ממלאה את השורה החדשה באקסס ע"פ הנתונים שהמשתמש הזין
            item.FillDataRow();
            // מוסיף שורה חדשה בטבלה- את השורה שבה טיפלנו עד כה
            table.Rows.Add(item.row);
        }
        public void UpdateItem(GeneralRow item)
        {
            item.FillDataRow();
    
        }
        public void DeliteItem (GeneralRow item)
        {
            item.row.Delete();
            list.Remove(item);
        }
        public void SaveChanges()
        {
            connect.UpdateTable(this.table.TableName);

        }
    }

    }

