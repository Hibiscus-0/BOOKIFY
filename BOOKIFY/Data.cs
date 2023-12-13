using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOKIFY
{
    
    internal class Data
    {

    }

    public class studentList
    {
        private ArrayList students;

        public studentList() 
        {
            string filepath = "C:\\Users\\elcar\\OneDrive\\Desktop\\BOOKIFY\\BOOKIFY\\database\\Students.tsv";
            loadFile file = new loadFile(filepath);
            students = file.LoadFile(filepath);
        }

        public ArrayList GetStudents()
        {
            return students;
        }
    }

    public class teacherList
    {
        private ArrayList teacher;

        public teacherList()
        {
            string filepath = "C:\\Users\\elcar\\OneDrive\\Desktop\\BOOKIFY\\BOOKIFY\\database\\Teachers.tsv";
            loadFile file = new loadFile(filepath);
            teacher = file.LoadFile(filepath);
        }

        public ArrayList GetTeacher()
        {
            return teacher;
        }
    }

    public class bookList
    {
        private ArrayList books;

        public bookList() 
        {
            string filepath = "C:\\Users\\elcar\\OneDrive\\Desktop\\BOOKIFY\\BOOKIFY\\database\\Books.tsv";
            loadFile file = new loadFile(filepath);
            books = file.LoadFile(filepath);
        }

        public ArrayList getBooks()
        {
            return books;
        }
    }

    public class bookCategories
    {
        private ArrayList categories;

        public bookCategories()
        {
            categories = new ArrayList { "Fictional", "Non-Fictional", "Academic" };
        }

        public ArrayList getBookCategories()
        {
            return categories;
        }

    }

    //loadFile
    public class loadFile
    {
        private string filepath;
        private ArrayList arrayList;

        public loadFile(string filepath)
        {
            this.filepath = filepath;
            arrayList = LoadFile(filepath);

        }

        public ArrayList LoadFile(string filepath)
        {
            ArrayList rows = new ArrayList();

            using (StreamReader sr = new StreamReader(filepath))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] columns = line.Split('|');

                    ArrayList rowList = new ArrayList();

                    foreach (string column in columns)
                    {
                        rowList.Add(column);
                    }

                    rows.Add(rowList);
                }
            }

            return rows;
        }
    }

    public class convertArrayListtoDataTable
    {
        private ArrayList arrayList;
        private DataTable table;

        public convertArrayListtoDataTable(ArrayList arrayList)
        {
            this.arrayList = arrayList;
            table = new DataTable();
        }

        public DataTable GetDataTable(ArrayList arrayList)
        {
            ArrayList columnName = (ArrayList)arrayList[0];
            for (int i = 0; i < columnName.Count; i++)
            {
                table.Columns.Add(columnName[i].ToString(), typeof(string));
            }


            for (int j = 1; j < arrayList.Count; j++)
            {
                ArrayList rows = (ArrayList)arrayList[j];
                AddDataRow(table, columnName, rows);
            }


            return table;
        }

        public void AddDataRow(DataTable table, ArrayList columnName, ArrayList rows)
        {
            DataRow newRow = table.NewRow();

            for (int i = 0; i < columnName.Count; i++)
            {
                string ColumnName = columnName[i].ToString();
                string data = rows[i].ToString();
                newRow[ColumnName] = data;
            }


            table.Rows.Add(newRow);
        }
    }
}
