namespace Interfaces
{
    partial class FrmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTamaño = new System.Windows.Forms.TextBox();
            this.numDuParticiones = new System.Windows.Forms.NumericUpDown();
            this.btnEmpezar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numDuParticiones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Disco Duro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tamaño del disco duro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero de particiones";
            // 
            // txtTamaño
            // 
            this.txtTamaño.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTamaño.Location = new System.Drawing.Point(133, 125);
            this.txtTamaño.Name = "txtTamaño";
            this.txtTamaño.Size = new System.Drawing.Size(119, 29);
            this.txtTamaño.TabIndex = 3;
            // 
            // numDuParticiones
            // 
            this.numDuParticiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDuParticiones.Location = new System.Drawing.Point(146, 205);
            this.numDuParticiones.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numDuParticiones.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDuParticiones.Name = "numDuParticiones";
            this.numDuParticiones.Size = new System.Drawing.Size(95, 29);
            this.numDuParticiones.TabIndex = 4;
            this.numDuParticiones.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnEmpezar
            // 
            this.btnEmpezar.Location = new System.Drawing.Point(302, 249);
            this.btnEmpezar.Name = "btnEmpezar";
            this.btnEmpezar.Size = new System.Drawing.Size(75, 23);
            this.btnEmpezar.TabIndex = 5;
            this.btnEmpezar.Text = "Empezar";
            this.btnEmpezar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Interfaces.Properties.Resources._32_325739_blue_technical_background_hd;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(392, 284);
            this.Controls.Add(this.btnEmpezar);
            this.Controls.Add(this.numDuParticiones);
            this.Controls.Add(this.txtTamaño);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numDuParticiones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTamaño;
        private System.Windows.Forms.NumericUpDown numDuParticiones;
        private System.Windows.Forms.Button btnEmpezar;
    }
}

