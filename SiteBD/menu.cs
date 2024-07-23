using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiteBD
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        SiteInfo siteInfo;
        private void button1_Click(object sender, EventArgs e)
        {
            siteInfo = new SiteInfo();
            siteInfo.Show();
            this.Close();
        }
        Autors_Form autors_Form;
        private void buttonStaffInfo_Click(object sender, EventArgs e)
        {
            autors_Form = new Autors_Form();
            autors_Form.Show();
            this.Close();
        }
        CalcFieldsForms calcFieldsForms;
        private void buttonIPSite_Click(object sender, EventArgs e)
        {
            calcFieldsForms = new CalcFieldsForms();
            calcFieldsForms.Show();
            this.Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        ThemsForms themsForms;
        private void button1_Click_1(object sender, EventArgs e)
        {
            themsForms = new ThemsForms();
            themsForms.Show();
            this.Close();
        }
    }
}
