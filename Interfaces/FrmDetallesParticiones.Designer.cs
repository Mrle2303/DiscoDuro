namespace Interfaces
{
    partial class FrmDetallesParticiones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtTamanioP = new System.Windows.Forms.TextBox();
            this.TxtNombreP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DgvInfoParticiones = new System.Windows.Forms.DataGridView();
            this.NombreP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TamañoP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disponible = new Logica_de_negocios.DataGridViewProgressColumn();
            this.btnBorar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInfoParticiones)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.TxtTamanioP);
            this.panel1.Controls.Add(this.TxtNombreP);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 96);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(172, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "MB";
            // 
            // TxtTamanioP
            // 
            this.TxtTamanioP.Location = new System.Drawing.Point(66, 51);
            this.TxtTamanioP.Name = "TxtTamanioP";
            this.TxtTamanioP.Size = new System.Drawing.Size(100, 20);
            this.TxtTamanioP.TabIndex = 3;
            this.TxtTamanioP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTamanioP_KeyPress);
            // 
            // TxtNombreP
            // 
            this.TxtNombreP.Location = new System.Drawing.Point(66, 12);
            this.TxtNombreP.Name = "TxtNombreP";
            this.TxtNombreP.Size = new System.Drawing.Size(100, 20);
            this.TxtNombreP.TabIndex = 2;
            this.TxtNombreP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreP_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tamaño";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Añadir Particiones";
            // 
            // btnAñadir
            // 
            this.btnAñadir.BackColor = System.Drawing.Color.Transparent;
            this.btnAñadir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAñadir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadir.ForeColor = System.Drawing.Color.White;
            this.btnAñadir.Location = new System.Drawing.Point(29, 154);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(78, 23);
            this.btnAñadir.TabIndex = 3;
            this.btnAñadir.Text = "Añadir ";
            this.btnAñadir.UseVisualStyleBackColor = false;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(241, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Particiones Existentes";
            // 
            // DgvInfoParticiones
            // 
            this.DgvInfoParticiones.AllowUserToAddRows = false;
            this.DgvInfoParticiones.AllowUserToDeleteRows = false;
            this.DgvInfoParticiones.AllowUserToResizeColumns = false;
            this.DgvInfoParticiones.AllowUserToResizeRows = false;
            this.DgvInfoParticiones.BackgroundColor = System.Drawing.Color.Azure;
            this.DgvInfoParticiones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvInfoParticiones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvInfoParticiones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(73)))), ((int)(((byte)(124)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(73)))), ((int)(((byte)(124)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvInfoParticiones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DgvInfoParticiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvInfoParticiones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreP,
            this.TamañoP,
            this.disponible});
            this.DgvInfoParticiones.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvInfoParticiones.DefaultCellStyle = dataGridViewCellStyle6;
            this.DgvInfoParticiones.EnableHeadersVisualStyles = false;
            this.DgvInfoParticiones.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(165)))), ((int)(((byte)(194)))));
            this.DgvInfoParticiones.Location = new System.Drawing.Point(244, 29);
            this.DgvInfoParticiones.Name = "DgvInfoParticiones";
            this.DgvInfoParticiones.ReadOnly = true;
            this.DgvInfoParticiones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvInfoParticiones.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DgvInfoParticiones.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(159)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.DgvInfoParticiones.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.DgvInfoParticiones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgvInfoParticiones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvInfoParticiones.Size = new System.Drawing.Size(342, 207);
            this.DgvInfoParticiones.TabIndex = 5;
            this.DgvInfoParticiones.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvInfoParticiones_CellDoubleClick);
            // 
            // NombreP
            // 
            this.NombreP.HeaderText = "Nombre";
            this.NombreP.Name = "NombreP";
            this.NombreP.ReadOnly = true;
            this.NombreP.Width = 121;
            // 
            // TamañoP
            // 
            this.TamañoP.HeaderText = "Tamaño";
            this.TamañoP.Name = "TamañoP";
            this.TamañoP.ReadOnly = true;
            this.TamañoP.Width = 121;
            // 
            // disponible
            // 
            this.disponible.HeaderText = "Disponible";
            this.disponible.Name = "disponible";
            this.disponible.ReadOnly = true;
            // 
            // btnBorar
            // 
            this.btnBorar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBorar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorar.ForeColor = System.Drawing.Color.White;
            this.btnBorar.Location = new System.Drawing.Point(144, 154);
            this.btnBorar.Name = "btnBorar";
            this.btnBorar.Size = new System.Drawing.Size(75, 23);
            this.btnBorar.TabIndex = 6;
            this.btnBorar.Text = "Borar";
            this.btnBorar.UseVisualStyleBackColor = true;
            this.btnBorar.Click += new System.EventHandler(this.btnBorar_Click);
            // 
            // FrmDetallesParticiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(614, 248);
            this.Controls.Add(this.btnBorar);
            this.Controls.Add(this.DgvInfoParticiones);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmDetallesParticiones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Particiones";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDetallesParticiones_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInfoParticiones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtTamanioP;
        private System.Windows.Forms.TextBox TxtNombreP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView DgvInfoParticiones;
        private System.Windows.Forms.Button btnBorar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TamañoP;
        private Logica_de_negocios.DataGridViewProgressColumn disponible;
    }
}