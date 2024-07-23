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
using System.Data.SqlClient;

namespace SiteBD
{
    public partial class Add_Form : Form
    {
        DataBase dataBase = new DataBase();
        public Add_Form()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }


        SiteInfo siteInfo;
        private void buttonSave_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();
            DateTime datetime;
            var date = textBoxDate.Text;
            var dateTime = textBoxDate.Text;
            var id_type = textBoxidType.Text;
            var name = textBoxName.Text;
            int ID;
            int startPrice;
            int Price;

            if (int.TryParse(textBoxID.Text,out ID) && int.TryParse(textBoxStartPrice.Text, out startPrice) && int.TryParse(textBoxPrice.Text,out Price) && DateTime.TryParse(dateTime, out datetime))
            {
                var addQuery = $"insert into Сайт (Код_сайт,Дата_создания,Код_вид,Название,Старт_бюджет,Цена) values ('{ID}','{datetime}','{id_type}','{name}','{startPrice}','{Price}')";
                var command = new SqlCommand(addQuery,dataBase.getConnection());
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешна создана", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Неправильный формат данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dataBase.closeConnection();
            
        }
    }
}
