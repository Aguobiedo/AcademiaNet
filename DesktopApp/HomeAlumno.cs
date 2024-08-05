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
    public partial class HomeAlumno : Form
    {
        public HomeAlumno()
        {
            InitializeComponent();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            // Acción para el botón Perfil
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            ListaCursos listaCursos = new ListaCursos();
            listaCursos.Show();
            this.Hide();
        }

        private void btnGrades_Click(object sender, EventArgs e)
        {
            // Acción para el botón Calificaciones
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            insc_cursos list_cursos = new insc_cursos();
            list_cursos.Show();
            this.Hide();
        }

        
    }
}