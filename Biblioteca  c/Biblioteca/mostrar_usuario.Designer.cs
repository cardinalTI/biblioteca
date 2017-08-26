namespace Biblioteca
{
    partial class mostrar_usuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTMusuario = new System.Windows.Forms.TextBox();
            this.TXTMapaterno = new System.Windows.Forms.TextBox();
            this.TXTMamaterno = new System.Windows.Forms.TextBox();
            this.BTNMusuario = new System.Windows.Forms.Button();
            this.DGVmostrarusuario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVmostrarusuario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre(s)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apelllido Paterno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido Materno";
            // 
            // TXTMusuario
            // 
            this.TXTMusuario.Location = new System.Drawing.Point(130, 22);
            this.TXTMusuario.Name = "TXTMusuario";
            this.TXTMusuario.Size = new System.Drawing.Size(140, 20);
            this.TXTMusuario.TabIndex = 3;
            // 
            // TXTMapaterno
            // 
            this.TXTMapaterno.Location = new System.Drawing.Point(129, 48);
            this.TXTMapaterno.Name = "TXTMapaterno";
            this.TXTMapaterno.Size = new System.Drawing.Size(141, 20);
            this.TXTMapaterno.TabIndex = 4;
            // 
            // TXTMamaterno
            // 
            this.TXTMamaterno.Location = new System.Drawing.Point(130, 76);
            this.TXTMamaterno.Name = "TXTMamaterno";
            this.TXTMamaterno.Size = new System.Drawing.Size(140, 20);
            this.TXTMamaterno.TabIndex = 5;
            // 
            // BTNMusuario
            // 
            this.BTNMusuario.Location = new System.Drawing.Point(287, 44);
            this.BTNMusuario.Name = "BTNMusuario";
            this.BTNMusuario.Size = new System.Drawing.Size(75, 23);
            this.BTNMusuario.TabIndex = 6;
            this.BTNMusuario.Text = "Buscar";
            this.BTNMusuario.UseVisualStyleBackColor = true;
            this.BTNMusuario.Click += new System.EventHandler(this.BTNMusuario_Click);
            // 
            // DGVmostrarusuario
            // 
            this.DGVmostrarusuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVmostrarusuario.Location = new System.Drawing.Point(26, 115);
            this.DGVmostrarusuario.Name = "DGVmostrarusuario";
            this.DGVmostrarusuario.Size = new System.Drawing.Size(546, 135);
            this.DGVmostrarusuario.TabIndex = 7;
            this.DGVmostrarusuario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVmostrarusuario_CellDoubleClick);
            // 
            // mostrar_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 262);
            this.Controls.Add(this.DGVmostrarusuario);
            this.Controls.Add(this.BTNMusuario);
            this.Controls.Add(this.TXTMamaterno);
            this.Controls.Add(this.TXTMapaterno);
            this.Controls.Add(this.TXTMusuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "mostrar_usuario";
            this.Text = "mostrar_usuario";
            ((System.ComponentModel.ISupportInitialize)(this.DGVmostrarusuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTMusuario;
        private System.Windows.Forms.TextBox TXTMapaterno;
        private System.Windows.Forms.TextBox TXTMamaterno;
        private System.Windows.Forms.Button BTNMusuario;
        private System.Windows.Forms.DataGridView DGVmostrarusuario;
    }
}