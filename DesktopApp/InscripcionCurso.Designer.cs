namespace DesktopApp
{
    partial class insc_cursos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelHeader = new System.Windows.Forms.Panel();
            lblUserName = new System.Windows.Forms.Label();
            btnPersonalOptions = new System.Windows.Forms.Button();
            dgc_cursos = new System.Windows.Forms.DataGridView();
            Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btn_back = new System.Windows.Forms.Button();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgc_cursos).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = System.Drawing.Color.FromArgb(221, 230, 237);
            panelHeader.Controls.Add(lblUserName);
            panelHeader.Controls.Add(btnPersonalOptions);
            panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            panelHeader.Location = new System.Drawing.Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new System.Drawing.Size(800, 47);
            panelHeader.TabIndex = 6;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
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
            btnPersonalOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            btnPersonalOptions.ForeColor = System.Drawing.Color.White;
            btnPersonalOptions.Location = new System.Drawing.Point(1220, 9);
            btnPersonalOptions.Name = "btnPersonalOptions";
            btnPersonalOptions.Size = new System.Drawing.Size(70, 28);
            btnPersonalOptions.TabIndex = 0;
            btnPersonalOptions.Text = "Opciones";
            btnPersonalOptions.UseVisualStyleBackColor = false;
            // 
            // dgc_cursos
            // 
            dgc_cursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgc_cursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgc_cursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Código, Curso });
            dgc_cursos.Dock = System.Windows.Forms.DockStyle.Fill;
            dgc_cursos.Location = new System.Drawing.Point(0, 47);
            dgc_cursos.Name = "dgc_cursos";
            dgc_cursos.Size = new System.Drawing.Size(800, 403);
            dgc_cursos.TabIndex = 7;
            dgc_cursos.CellContentClick += dgc_cursos_CellContentClick;
            // 
            // Código
            // 
            Código.HeaderText = "Código";
            Código.Name = "Código";
            // 
            // Curso
            // 
            Curso.HeaderText = "Curso";
            Curso.Name = "Curso";
            // 
            // btn_back
            // 
            btn_back.Location = new System.Drawing.Point(18, 415);
            btn_back.Name = "btn_back";
            btn_back.Size = new System.Drawing.Size(75, 23);
            btn_back.TabIndex = 8;
            btn_back.Text = "Volver";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // insc_cursos
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btn_back);
            Controls.Add(dgc_cursos);
            Controls.Add(panelHeader);
            Name = "insc_cursos";
            Text = "lista_cursos";
            Load += insc_cursos_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgc_cursos).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnPersonalOptions;
        private System.Windows.Forms.DataGridView dgc_cursos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curso;
        private System.Windows.Forms.Button btn_back;
    }
}