namespace EjerOperaciones
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbOperaciones = new ComboBox();
            lblOperaciones = new Label();
            txtnum1 = new TextBox();
            txtnum2 = new TextBox();
            lblnum1 = new Label();
            lblnum2 = new Label();
            lblresultado = new Label();
            btnCalcular = new Button();
            txtResultado = new TextBox();
            SuspendLayout();
            // 
            // cmbOperaciones
            // 
            cmbOperaciones.FormattingEnabled = true;
            cmbOperaciones.Location = new Point(12, 44);
            cmbOperaciones.Name = "cmbOperaciones";
            cmbOperaciones.Size = new Size(151, 28);
            cmbOperaciones.TabIndex = 0;
            // 
            // lblOperaciones
            // 
            lblOperaciones.AutoSize = true;
            lblOperaciones.Location = new Point(12, 21);
            lblOperaciones.Name = "lblOperaciones";
            lblOperaciones.Size = new Size(92, 20);
            lblOperaciones.TabIndex = 1;
            lblOperaciones.Text = "Operaciones";
            // 
            // txtnum1
            // 
            txtnum1.Location = new Point(12, 125);
            txtnum1.Name = "txtnum1";
            txtnum1.Size = new Size(125, 27);
            txtnum1.TabIndex = 2;
            // 
            // txtnum2
            // 
            txtnum2.Location = new Point(216, 125);
            txtnum2.Name = "txtnum2";
            txtnum2.Size = new Size(125, 27);
            txtnum2.TabIndex = 3;
            // 
            // lblnum1
            // 
            lblnum1.AutoSize = true;
            lblnum1.Location = new Point(12, 102);
            lblnum1.Name = "lblnum1";
            lblnum1.Size = new Size(72, 20);
            lblnum1.TabIndex = 4;
            lblnum1.Text = "numero 1";
            // 
            // lblnum2
            // 
            lblnum2.AutoSize = true;
            lblnum2.Location = new Point(216, 102);
            lblnum2.Name = "lblnum2";
            lblnum2.Size = new Size(72, 20);
            lblnum2.TabIndex = 5;
            lblnum2.Text = "numero 2";
            // 
            // lblresultado
            // 
            lblresultado.AutoSize = true;
            lblresultado.Location = new Point(216, 249);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(75, 20);
            lblresultado.TabIndex = 7;
            lblresultado.Text = "Resultado";
            // 
            // btnCalcular
            // 
            btnCalcular.Cursor = Cursors.Cross;
            btnCalcular.Location = new Point(69, 272);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 8;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(216, 274);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(125, 27);
            txtResultado.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtResultado);
            Controls.Add(btnCalcular);
            Controls.Add(lblresultado);
            Controls.Add(lblnum2);
            Controls.Add(lblnum1);
            Controls.Add(txtnum2);
            Controls.Add(txtnum1);
            Controls.Add(lblOperaciones);
            Controls.Add(cmbOperaciones);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbOperaciones;
        private Label lblOperaciones;
        private TextBox txtnum1;
        private TextBox txtnum2;
        private Label lblnum1;
        private Label lblnum2;
        private Label label4;
        private Label lblresultado;
        private Button btnCalcular;
        private TextBox txtResultado;
    }
}
