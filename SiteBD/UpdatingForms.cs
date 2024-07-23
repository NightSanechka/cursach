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
    public partial class UpdatingForms : Form
    {
        DataBase dataBase = new DataBase();
        public UpdatingForms()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "ID_Сайт");
            dataGridView1.Columns.Add("startDate", "Дата_создания");
            dataGridView1.Columns.Add("nameTheme", "Указание");
            dataGridView1.Columns.Add("updatingDate", "Дата_создания");
        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetValue(0), record.GetDateTime(1), record.GetString(2), record.GetDateTime(3));
        }
        private void RefreshDataGrid(DataGridView dgw)
        {

            string queryString = $"select * from Обновления_сайтов";
            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();

        }
        private void UpdatingForms_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }
    }
}
