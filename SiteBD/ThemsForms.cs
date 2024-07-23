using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiteBD
{
    public partial class ThemsForms : Form
    {
        DataBase dataBase = new DataBase();
        public ThemsForms()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "ID");
            dataGridView1.Columns.Add("startDate", "Дата_создания");
            dataGridView1.Columns.Add("ID_type", "ID_Вид");
            dataGridView1.Columns.Add("name", "Название");
            dataGridView1.Columns.Add("startPrice", "Стартовый_бюджет");
            dataGridView1.Columns.Add("price", "Цена");
            dataGridView1.Columns.Add("countThems", "Количество_тем");
            dataGridView1.Columns.Add("daysofsite", "Возраст_сайта");

        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetValue(0), record.GetDateTime(1), record.GetValue(2), record.GetString(3), record.GetValue(4), record.GetValue(5), record.GetValue(6),record.GetValue(7));
        }
        private void RefreshDataGrid(DataGridView dgw)
        {

            string queryString = $"select * from Сайт";
            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();

        }

        private void ThemsForms_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
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
