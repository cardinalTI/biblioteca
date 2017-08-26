namespace Biblioteca
{
    partial class mostrar_libro
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
            this.DGVMlibros = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.CBMMlibro = new System.Windows.Forms.ComboBox();
            this.TXBMlibro = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMlibros)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVMlibros
            // 
            this.DGVMlibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMlibros.Location = new System.Drawing.Point(13, 69);
            this.DGVMlibros.Name = "DGVMlibros";
            this.DGVMlibros.Size = new System.Drawing.Size(496, 150);
            this.DGVMlibros.TabIndex = 7;
            this.DGVMlibros.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVMlibros_CellDoubleClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(362, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CBMMlibro
            // 
            this.CBMMlibro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBMMlibro.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBMMlibro.FormattingEnabled = true;
            this.CBMMlibro.Items.AddRange(new object[] {
            "Nombre del Libro",
            "Editorial",
            "Autor"});
            this.CBMMlibro.Location = new System.Drawing.Point(13, 26);
            this.CBMMlibro.Name = "CBMMlibro";
            this.CBMMlibro.Size = new System.Drawing.Size(131, 23);
            this.CBMMlibro.TabIndex = 8;
            // 
            // TXBMlibro
            // 
            this.TXBMlibro.Location = new System.Drawing.Point(164, 26);
            this.TXBMlibro.Name = "TXBMlibro";
            this.TXBMlibro.Size = new System.Drawing.Size(173, 20);
            this.TXBMlibro.TabIndex = 9;
            // 
            // mostrar_libro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 229);
            this.Controls.Add(this.TXBMlibro);
            this.Controls.Add(this.CBMMlibro);
            this.Controls.Add(this.DGVMlibros);
            this.Controls.Add(this.button1);
            this.Name = "mostrar_libro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mostrar_libro";
            ((System.ComponentModel.ISupportInitialize)(this.DGVMlibros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVMlibros;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox CBMMlibro;
        private System.Windows.Forms.TextBox TXBMlibro;
    }
}