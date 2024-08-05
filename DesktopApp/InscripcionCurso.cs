using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class insc_cursos : Form
    {
        public insc_cursos()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgc_cursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            HomeAlumno homeAlumno = new HomeAlumno();
            homeAlumno.Show();
            this.Hide();
        }

        private void insc_cursos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomeAlumno homeAlumno = new HomeAlumno();
            homeAlumno.Show();
            this.Hide();
        }
    }
}
