namespace AppEstadistica
{
    partial class frmMain
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
            label1 = new Label();
            txtCantidad = new MaskedTextBox();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            txtVar1 = new TextBox();
            txtVar2 = new TextBox();
            panel1 = new Panel();
            lblDatos = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 122);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "N° Datos";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(182, 115);
            txtCantidad.Mask = "0000";
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(28, 27);
            txtCantidad.TabIndex = 1;
            txtCantidad.MaskInputRejected += txtCantidad_MaskInputRejected;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 172);
            label2.Name = "label2";
            label2.Size = new Size(231, 20);
            label2.TabIndex = 2;
            label2.Text = "Digite el nombre de las variables:";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(104, 122, 177);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(123, 312);
            button1.Name = "button1";
            button1.Size = new Size(125, 61);
            button1.TabIndex = 4;
            button1.Text = "Insertar Datos";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 212);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 5;
            label3.Text = "Eje X:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(239, 212);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 6;
            label4.Text = "Eje Y:";
            // 
            // txtVar1
            // 
            txtVar1.Location = new Point(49, 235);
            txtVar1.Name = "txtVar1";
            txtVar1.Size = new Size(125, 27);
            txtVar1.TabIndex = 7;
            // 
            // txtVar2
            // 
            txtVar2.Location = new Point(215, 235);
            txtVar2.Name = "txtVar2";
            txtVar2.Size = new Size(125, 27);
            txtVar2.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(102, 102, 255);
            panel1.Controls.Add(lblDatos);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(383, 73);
            panel1.TabIndex = 9;
            // 
            // lblDatos
            // 
            lblDatos.AutoSize = true;
            lblDatos.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatos.ForeColor = SystemColors.ButtonHighlight;
            lblDatos.Location = new Point(21, 24);
            lblDatos.Name = "lblDatos";
            lblDatos.Size = new Size(116, 25);
            lblDatos.TabIndex = 10;
            lblDatos.Text = "Variables";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(383, 484);
            Controls.Add(panel1);
            Controls.Add(txtVar2);
            Controls.Add(txtVar1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(txtCantidad);
            Controls.Add(label1);
            Name = "frmMain";
            Text = "frmMain";
            Load += frmMain_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MaskedTextBox txtCantidad;
        private Label label2;
        private Button button1;
        private Label label3;
        private Label label4;
        private TextBox txtVar1;
        private TextBox txtVar2;
        private Panel panel1;
        private Label lblDatos;
    }
}