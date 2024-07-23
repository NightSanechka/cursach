using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SiteBD
{
    public partial class WebPageInfoForms : Form
    {
        DataBase dataBase = new DataBase();
        public WebPageInfoForms()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "ID_Сайт");
            dataGridView1.Columns.Add("startDate", "Дата_создания");
            dataGridView1.Columns.Add("nameDomen", "Домен");
            dataGridView1.Columns.Add("nameWay", "Путь");
            dataGridView1.Columns.Add("namePrt", "Протокол");
            dataGridView1.Columns.Add("startDate", "Дата_создания");
            dataGridView1.Columns.Add("endDate", "Дата_удаления");

        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetValue(0), record.GetDateTime(1), record.GetString(2), record.GetString(3),record.GetString(4), record.GetDateTime(5), record.GetDateTime(6));
        }
        private void RefreshDataGrid(DataGridView dgw)
        {

            string queryString = $"select * from Информация_о_страницах";
            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();

        }
        private void WebPageInfoForms_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }
    }
}
