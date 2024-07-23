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
    public partial class CalcFieldsForms : Form
    {
        DataBase dataBase = new DataBase();
        public CalcFieldsForms()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "ID");
            dataGridView1.Columns.Add("name", "Имя");
            dataGridView1.Columns.Add("surname", "Фамилия");
            dataGridView1.Columns.Add("lastname", "Отчество");
            dataGridView1.Columns.Add("ID_type", "Код_направления");
            dataGridView1.Columns.Add("countSites", "Количество_сайтов");
            dataGridView1.Columns.Add("fullname", "Полное_имя");

        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetValue(0),record.GetString(1),record.GetString(2),record.GetString(3),record.GetValue(4),record.GetValue(5),record.GetString(6));
        }
        private void RefreshDataGrid(DataGridView dgw)
        {

            string queryString = $"select * from Человек";
            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();

        }
        private void CalcFieldsForms_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        menu menu;
        private void buttonBack_Click(object sender, EventArgs e)
        {
            menu = new menu();
            menu.Show();
            this.Close();
        }
    }
}
