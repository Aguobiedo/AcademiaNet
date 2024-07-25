namespace DesktopApp
{
    partial class HomeAlumno
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnCourses = new System.Windows.Forms.Button();
            this.btnGrades = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnPersonalOptions = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.lblFooter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(150, 100);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(200, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Menú Principal";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnProfile
            // 
            this.btnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnProfile.Location = new System.Drawing.Point(170, 160);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(160, 40);
            this.btnProfile.TabIndex = 1;
            this.btnProfile.Text = "Perfil";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnCourses
            // 
            this.btnCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCourses.Location = new System.Drawing.Point(170, 220);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(160, 40);
            this.btnCourses.TabIndex = 2;
            this.btnCourses.Text = "Cursos";
            this.btnCourses.UseVisualStyleBackColor = true;
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);
            // 
            // btnGrades
            // 
            this.btnGrades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnGrades.Location = new System.Drawing.Point(170, 280);
            this.btnGrades.Name = "btnGrades";
            this.btnGrades.Size = new System.Drawing.Size(160, 40);
            this.btnGrades.TabIndex = 3;
            this.btnGrades.Text = "Calificaciones";
            this.btnGrades.UseVisualStyleBackColor = true;
            this.btnGrades.Click += new System.EventHandler(this.btnGrades_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLogout.Location = new System.Drawing.Point(170, 340);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(160, 40);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Cerrar Sesión";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.LightGray;
            this.panelHeader.Controls.Add(this.lblUserName);
            this.panelHeader.Controls.Add(this.btnPersonalOptions);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(500, 50);
            this.panelHeader.TabIndex = 5;
            // 
            // btnPersonalOptions
            // 
            this.btnPersonalOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPersonalOptions.Location = new System.Drawing.Point(400, 10);
            this.btnPersonalOptions.Name = "btnPersonalOptions";
            this.btnPersonalOptions.Size = new System.Drawing.Size(80, 30);
            this.btnPersonalOptions.TabIndex = 0;
            this.btnPersonalOptions.Text = "Opciones";
            this.btnPersonalOptions.UseVisualStyleBackColor = true;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblUserName.Location = new System.Drawing.Point(10, 15);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(80, 17);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "Usuario: X";
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.LightGray;
            this.panelFooter.Controls.Add(this.lblFooter);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 400);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(500, 30);
            this.panelFooter.TabIndex = 6;
            // 
            // lblFooter
            // 
            this.lblFooter.AutoSize = true;
            this.lblFooter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblFooter.Location = new System.Drawing.Point(200, 10);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(100, 13);
            this.lblFooter.TabIndex = 0;
            this.lblFooter.Text = "© 2024 Mi Aplicación";
            // 
            // HomeAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 430);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnGrades);
            this.Controls.Add(this.btnCourses);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "HomeAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Button btnGrades;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnPersonalOptions;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label lblFooter;
    }
}