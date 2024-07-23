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
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class SiteInfo : Form
    {
        DataBase dataBase = new DataBase();
        int selectedRow;
        public SiteInfo()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("Date", "Дата_создания");
            dataGridView1.Columns.Add("Id_type", "ID_Вид");
            dataGridView1.Columns.Add("Name", "Название");
            dataGridView1.Columns.Add("Start_price", "Старт_цена");
            dataGridView1.Columns.Add("Price", "Цена"); 
            dataGridView1.Columns.Add("Status", "Состояние");

        }

        private void ClearFields()
        {
            textBoxID.Text = "";
            textBoxIDType.Text = "";
            textBoxName.Text = "";
            textBoxPrice.Text = "";
            textBoxStartDate.Text = "";
            textBoxStartPrice.Text = "";
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetValue(0),record.GetDateTime(1),record.GetValue(2),record.GetString(3),record.GetValue(4),record.GetValue(5),RowState.ModifiedNew);
        }
        private void RefreshDataGrid(DataGridView dgw)
        {

            string queryString = $"select * from Сайт";
            SqlCommand command = new SqlCommand(queryString,dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                ReadSingleRow(dgw,reader);
            }
            reader.Close();
                                    
        }
        menu menu;
        private void buttonBack_Click(object sender, EventArgs e)
        {
            menu = new menu();
            menu.Show();
            this.Close();
        }

        private void SiteInfo_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if(e.RowIndex >= 0 )
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textBoxID.Text = row.Cells[0].Value.ToString();
                textBoxStartDate.Text = row.Cells[1].Value.ToString();
                textBoxIDType.Text = row.Cells[2].Value.ToString();
                textBoxName.Text = row.Cells[3].Value.ToString();
                textBoxStartPrice.Text = row.Cells[4].Value.ToString();
                textBoxPrice.Text = row.Cells[5].Value.ToString();
            }
        }

        private void textBoxFind_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                textBoxFind.Text = "";
            }

        }

        private void buttonResetFind_Click(object sender, EventArgs e)
        {
            if(textBoxFind.Text.ToString() == string.Empty)
            {
                textBoxFind.Text = "Введите название сайта";
                RefreshDataGrid(dataGridView1);
            }
            
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string searchString = $"select * from Сайт where Название like '%" + textBoxFind.Text + "%'";
            SqlCommand command = new SqlCommand( searchString,dataBase.getConnection() );
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgw,reader);
            }
            reader.Close();
        }

        private void textBoxFind_TextChanged_1(object sender, EventArgs e)
        {
            Search(dataGridView1);
            ClearFields();
        }

        private void deleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows[index].Visible = false;

            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[6].Value = RowState.Deleted;
                return;
            }
            dataGridView1.Rows[index].Cells[6].Value = RowState.Deleted;
        }

        Add_Form addForm;
        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            addForm = new Add_Form();
            addForm.Show();
        }
        private void Update()
        {
            dataBase.openConnection();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                var rowState = (RowState)dataGridView1.Rows[i].Cells[6].Value;

                if (rowState == RowState.Existed)
                {
                    continue;
                }

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                    var deleteQuery = $"delete from Сайт where Код_сайт = {id} ";
                    var command = new SqlCommand(deleteQuery,dataBase.getConnection());
                    command.ExecuteNonQuery();
                }
                if (rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    var date = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    var id_type = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    var name = dataGridView1.Rows[i].Cells[3].Value.ToString(); 
                    var startPrice = dataGridView1.Rows[i].Cells[4].Value.ToString();
                    var price = dataGridView1.Rows[i].Cells[5].Value.ToString();

                    var changeQuery = $"update Сайт set Дата_создания = '{date}', Код_вид = '{id_type}', Название = '{name}', Старт_бюджет = '{startPrice}', Цена = '{price}' where Код_сайт = '{id}'";

                    var command = new SqlCommand(changeQuery,dataBase.getConnection());
                    command.ExecuteNonQuery();
                    
                }
            }
            dataBase.closeConnection();
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            deleteRow();
            ClearFields();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Update();
            ClearFields();
            MessageBox.Show("Запись сохрнанена", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            var id = textBoxID.Text;
            DateTime datetime;
            DateTime.TryParse(textBoxStartDate.Text, out datetime);
            var dateTime = textBoxStartDate.Text;
            var id_type = textBoxIDType.Text;
            var name = textBoxName.Text;
            int startPrice;
            int price; int.TryParse(textBoxPrice.Text, out price);


            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if (int.TryParse(textBoxStartPrice.Text, out startPrice))
                {
                    dataGridView1.Rows[selectedRowIndex].SetValues(id,dateTime, id_type, name, startPrice, price);
                    dataGridView1.Rows[selectedRowIndex].Cells[6].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("Введён неправильный формат данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Change();
            ClearFields();
        }
    }
}
