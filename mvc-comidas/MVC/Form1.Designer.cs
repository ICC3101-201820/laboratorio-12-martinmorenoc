namespace MVC
{
    partial class Form1
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
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.proteinasTextBox = new System.Windows.Forms.TextBox();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.proteinaLabel = new System.Windows.Forms.Label();
            this.agregarButonn = new System.Windows.Forms.Button();
            this.comidasList = new System.Windows.Forms.ListBox();
            this.carbohidratosLabel = new System.Windows.Forms.Label();
            this.grasasLabel = new System.Windows.Forms.Label();
            this.carbohidratosTextBox = new System.Windows.Forms.TextBox();
            this.grasasTextBox = new System.Windows.Forms.TextBox();
            this.listadoLabel = new System.Windows.Forms.Label();
            this.eliminarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(116, 78);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(144, 20);
            this.nombreTextBox.TabIndex = 0;
            // 
            // proteinasTextBox
            // 
            this.proteinasTextBox.Location = new System.Drawing.Point(116, 116);
            this.proteinasTextBox.Name = "proteinasTextBox";
            this.proteinasTextBox.Size = new System.Drawing.Size(144, 20);
            this.proteinasTextBox.TabIndex = 1;
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(27, 81);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(44, 13);
            this.nombreLabel.TabIndex = 2;
            this.nombreLabel.Text = "Nombre";
            this.nombreLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // proteinaLabel
            // 
            this.proteinaLabel.AutoSize = true;
            this.proteinaLabel.Location = new System.Drawing.Point(27, 119);
            this.proteinaLabel.Name = "proteinaLabel";
            this.proteinaLabel.Size = new System.Drawing.Size(51, 13);
            this.proteinaLabel.TabIndex = 3;
            this.proteinaLabel.Text = "Proteinas";
            // 
            // agregarButonn
            // 
            this.agregarButonn.Location = new System.Drawing.Point(148, 247);
            this.agregarButonn.Name = "agregarButonn";
            this.agregarButonn.Size = new System.Drawing.Size(87, 27);
            this.agregarButonn.TabIndex = 4;
            this.agregarButonn.Text = "Agregar";
            this.agregarButonn.UseVisualStyleBackColor = true;
            this.agregarButonn.Click += new System.EventHandler(this.button1_Click);
            // 
            // comidasList
            // 
            this.comidasList.FormattingEnabled = true;
            this.comidasList.Location = new System.Drawing.Point(356, 78);
            this.comidasList.Name = "comidasList";
            this.comidasList.Size = new System.Drawing.Size(406, 264);
            this.comidasList.TabIndex = 5;
            // 
            // carbohidratosLabel
            // 
            this.carbohidratosLabel.AutoSize = true;
            this.carbohidratosLabel.Location = new System.Drawing.Point(27, 195);
            this.carbohidratosLabel.Name = "carbohidratosLabel";
            this.carbohidratosLabel.Size = new System.Drawing.Size(72, 13);
            this.carbohidratosLabel.TabIndex = 9;
            this.carbohidratosLabel.Text = "Carbohidratos";
            this.carbohidratosLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // grasasLabel
            // 
            this.grasasLabel.AutoSize = true;
            this.grasasLabel.Location = new System.Drawing.Point(27, 157);
            this.grasasLabel.Name = "grasasLabel";
            this.grasasLabel.Size = new System.Drawing.Size(40, 13);
            this.grasasLabel.TabIndex = 8;
            this.grasasLabel.Text = "Grasas";
            this.grasasLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // carbohidratosTextBox
            // 
            this.carbohidratosTextBox.Location = new System.Drawing.Point(116, 192);
            this.carbohidratosTextBox.Name = "carbohidratosTextBox";
            this.carbohidratosTextBox.Size = new System.Drawing.Size(144, 20);
            this.carbohidratosTextBox.TabIndex = 7;
            this.carbohidratosTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // grasasTextBox
            // 
            this.grasasTextBox.Location = new System.Drawing.Point(116, 154);
            this.grasasTextBox.Name = "grasasTextBox";
            this.grasasTextBox.Size = new System.Drawing.Size(144, 20);
            this.grasasTextBox.TabIndex = 6;
            this.grasasTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // listadoLabel
            // 
            this.listadoLabel.AutoSize = true;
            this.listadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.listadoLabel.Location = new System.Drawing.Point(519, 42);
            this.listadoLabel.Name = "listadoLabel";
            this.listadoLabel.Size = new System.Drawing.Size(64, 20);
            this.listadoLabel.TabIndex = 10;
            this.listadoLabel.Text = "Listado";
            this.listadoLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.listadoLabel.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // eliminarButton
            // 
            this.eliminarButton.Location = new System.Drawing.Point(486, 375);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(158, 31);
            this.eliminarButton.TabIndex = 11;
            this.eliminarButton.Text = " Eliminar Selección";
            this.eliminarButton.UseVisualStyleBackColor = true;
            this.eliminarButton.Click += new System.EventHandler(this.eliminarButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.eliminarButton);
            this.Controls.Add(this.listadoLabel);
            this.Controls.Add(this.carbohidratosLabel);
            this.Controls.Add(this.grasasLabel);
            this.Controls.Add(this.carbohidratosTextBox);
            this.Controls.Add(this.grasasTextBox);
            this.Controls.Add(this.comidasList);
            this.Controls.Add(this.agregarButonn);
            this.Controls.Add(this.proteinaLabel);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.proteinasTextBox);
            this.Controls.Add(this.nombreTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox proteinasTextBox;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Label proteinaLabel;
        private System.Windows.Forms.Button agregarButonn;
        private System.Windows.Forms.ListBox comidasList;
        private System.Windows.Forms.Label carbohidratosLabel;
        private System.Windows.Forms.Label grasasLabel;
        private System.Windows.Forms.TextBox carbohidratosTextBox;
        private System.Windows.Forms.TextBox grasasTextBox;
        private System.Windows.Forms.Label listadoLabel;
        private System.Windows.Forms.Button eliminarButton;
    }
}

