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
            lblTitle = new System.Windows.Forms.Label();
            btnProfile = new System.Windows.Forms.Button();
            btnCourses = new System.Windows.Forms.Button();
            btnGrades = new System.Windows.Forms.Button();
            btnLogout = new System.Windows.Forms.Button();
            panelHeader = new System.Windows.Forms.Panel();
            lblUserName = new System.Windows.Forms.Label();
            btnPersonalOptions = new System.Windows.Forms.Button();
            panelFooter = new System.Windows.Forms.Panel();
            lblFooter = new System.Windows.Forms.Label();
            panelHeader.SuspendLayout();
            panelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(39, 55, 77);
            lblTitle.Location = new System.Drawing.Point(0, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(206, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Menú Principal";
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = System.Drawing.Color.FromArgb(82, 109, 130);
            btnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnProfile.ForeColor = System.Drawing.Color.White;
            btnProfile.Location = new System.Drawing.Point(559, 143);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new System.Drawing.Size(175, 38);
            btnProfile.TabIndex = 1;
            btnProfile.Text = "Perfil";
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnCourses
            // 
            btnCourses.BackColor = System.Drawing.Color.FromArgb(82, 109, 130);
            btnCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCourses.ForeColor = System.Drawing.Color.White;
            btnCourses.Location = new System.Drawing.Point(559, 199);
            btnCourses.Name = "btnCourses";
            btnCourses.Size = new System.Drawing.Size(175, 38);
            btnCourses.TabIndex = 2;
            btnCourses.Text = "Cursos";
            btnCourses.UseVisualStyleBackColor = false;
            btnCourses.Click += btnCourses_Click;
            // 
            // btnGrades
            // 
            btnGrades.BackColor = System.Drawing.Color.FromArgb(82, 109, 130);
            btnGrades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnGrades.ForeColor = System.Drawing.Color.White;
            btnGrades.Location = new System.Drawing.Point(559, 255);
            btnGrades.Name = "btnGrades";
            btnGrades.Size = new System.Drawing.Size(175, 38);
            btnGrades.TabIndex = 3;
            btnGrades.Text = "Calificaciones";
            btnGrades.UseVisualStyleBackColor = false;
            btnGrades.Click += btnGrades_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = System.Drawing.Color.FromArgb(82, 109, 130);
            btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnLogout.ForeColor = System.Drawing.Color.White;
            btnLogout.Location = new System.Drawing.Point(559, 311);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new System.Drawing.Size(175, 38);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Cerrar Sesión";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = System.Drawing.Color.FromArgb(221, 230, 237);
            panelHeader.Controls.Add(lblUserName);
            panelHeader.Controls.Add(btnPersonalOptions);
            panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            panelHeader.Location = new System.Drawing.Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new System.Drawing.Size(902, 47);
            panelHeader.TabIndex = 5;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblUserName.ForeColor = System.Drawing.Color.FromArgb(39, 55, 77);
            lblUserName.Location = new System.Drawing.Point(9, 14);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new System.Drawing.Size(84, 17);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "Usuario: X";
            // 
            // btnPersonalOptions
            // 
            btnPersonalOptions.BackColor = System.Drawing.Color.FromArgb(39, 55, 77);
            btnPersonalOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnPersonalOptions.ForeColor = System.Drawing.Color.White;
            btnPersonalOptions.Location = new System.Drawing.Point(1220, 9);
            btnPersonalOptions.Name = "btnPersonalOptions";
            btnPersonalOptions.Size = new System.Drawing.Size(70, 28);
            btnPersonalOptions.TabIndex = 0;
            btnPersonalOptions.Text = "Opciones";
            btnPersonalOptions.UseVisualStyleBackColor = false;
            // 
            // panelFooter
            // 
            panelFooter.BackColor = System.Drawing.Color.FromArgb(221, 230, 237);
            panelFooter.Controls.Add(lblFooter);
            panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelFooter.Location = new System.Drawing.Point(0, 404);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new System.Drawing.Size(902, 28);
            panelFooter.TabIndex = 6;
            // 
            // lblFooter
            // 
            lblFooter.AutoSize = true;
            lblFooter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblFooter.ForeColor = System.Drawing.Color.FromArgb(39, 55, 77);
            lblFooter.Location = new System.Drawing.Point(591, 0);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new System.Drawing.Size(109, 13);
            lblFooter.TabIndex = 0;
            lblFooter.Text = "© 2024 Mi Aplicación";
            // 
            // HomeAlumno
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(902, 432);
            Controls.Add(panelFooter);
            Controls.Add(panelHeader);
            Controls.Add(btnLogout);
            Controls.Add(btnGrades);
            Controls.Add(btnCourses);
            Controls.Add(btnProfile);
            Controls.Add(lblTitle);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Name = "HomeAlumno";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Home";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
