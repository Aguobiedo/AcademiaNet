namespace DesktopApp
{
    partial class ListaCursos
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
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] { "1", "Curso1" }, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.ActiveBorder, null);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] { "2", "Curso2" }, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.ActiveBorder, null);
            listView1 = new System.Windows.Forms.ListView();
            id = new System.Windows.Forms.ColumnHeader();
            nombre = new System.Windows.Forms.ColumnHeader();
            btn_volver = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.BackColor = System.Drawing.SystemColors.Info;
            listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { id, nombre });
            listView1.GridLines = true;
            listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] { listViewItem3, listViewItem4 });
            listView1.Location = new System.Drawing.Point(68, 26);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(609, 295);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            id.Text = "ID";
            // 
            // nombre
            // 
            nombre.Text = "Nombre";
            // 
            // btn_volver
            // 
            btn_volver.Location = new System.Drawing.Point(40, 341);
            btn_volver.Name = "btn_volver";
            btn_volver.Size = new System.Drawing.Size(75, 23);
            btn_volver.TabIndex = 1;
            btn_volver.Text = "Volver";
            btn_volver.UseVisualStyleBackColor = true;
            btn_volver.Click += button1_Click;
            // 
            // ListaCursos
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btn_volver);
            Controls.Add(listView1);
            Name = "ListaCursos";
            Text = "ListaCursos";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader nombre;
        private System.Windows.Forms.Button btn_volver;
    }
}