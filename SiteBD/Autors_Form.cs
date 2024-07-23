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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SiteBD
{
    public partial class Autors_Form : Form
    {
        enum RowState
        {
            Existed,
            New,
            Modified,
            ModifiedNew,
            Deleted
        }
        DataBase dataBase = new DataBase();
        int selectedRow;
        public Autors_Form()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "ID");
            dataGridView1.Columns.Add("startDate", "Дата_начала");
            dataGridView1.Columns.Add("endDate", "Дата_конца");
            dataGridView1.Columns.Add("id_man", "ID_человека");
            dataGridView1.Columns.Add("id_org", "ID_организации");
            dataGridView1.Columns.Add("id_site", "ID_сайта");
            dataGridView1.Columns.Add("state", "Статус");

        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetValue(0),record.GetDateTime(1),record.GetDateTime(2),record.GetValue(3),record.GetValue(4),record.GetValue(5),RowState.ModifiedNew);
        }
        private void RefreshDataGrid(DataGridView dgw)
        {

            string queryString = $"select * from Автор_Сайта";
            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();

        }
        private void Autors_Form_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        menu menu;
        private void buttonBack_Click(object sender, EventArgs e)
        {
            menu = new menu();
            menu.Show();
            this.Close();
        }

        StaffForm staffForm;
        private void buttonStaff_Click(object sender, EventArgs e)
        {
            staffForm = new StaffForm();
            staffForm.Show();
        }
        SiteAutorsForms siteAutorsForms;
        private void buttonSiteAutors_Click(object sender, EventArgs e)
        {
            siteAutorsForms = new SiteAutorsForms();
            siteAutorsForms.Show();
        }

        SiteThemsForms siteThemsForms;
        private void buttonThems_Click(object sender, EventArgs e)
        {
            siteThemsForms = new SiteThemsForms();
            siteThemsForms.Show();
        }

        UpdatingForms updatingForms;
        private void buttonUpdating_Click(object sender, EventArgs e)
        {
            updatingForms = new UpdatingForms();
            updatingForms.Show();
        }

        WebPageInfoForms webPageInfoForms;
        private void button5_Click(object sender, EventArgs e)
        {
            webPageInfoForms = new WebPageInfoForms();
            webPageInfoForms.Show();
        }
    }
}
