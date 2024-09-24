namespace AppEstadistica
{
    partial class frmDatos
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatos));
            dgvDatos = new DataGridView();
            EjeX = new DataGridViewTextBoxColumn();
            EjeY = new DataGridViewTextBoxColumn();
            X_Cuadrado = new DataGridViewTextBoxColumn();
            Y_Cuadrado = new DataGridViewTextBoxColumn();
            XPORY = new DataGridViewTextBoxColumn();
            label1 = new Label();
            btnCalcular = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btndelete = new Button();
            ListaImagenes = new ImageList(components);
            btnRegresar = new Button();
            tabPage3 = new TabPage();
            richTextBox1 = new RichTextBox();
            txtMin = new TextBox();
            txtMax = new TextBox();
            label8 = new Label();
            label7 = new Label();
            lblAnalisisb1 = new Label();
            label4 = new Label();
            Ttxt = new TextBox();
            label6 = new Label();
            Rtxt = new TextBox();
            label5 = new Label();
            b1txt = new TextBox();
            txttt = new Label();
            b0txt = new TextBox();
            label3 = new Label();
            Rcuadradotxt = new TextBox();
            label2 = new Label();
            RVtxt = new TextBox();
            tabPage2 = new TabPage();
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            panel_Titulo = new Panel();
            lblDatos = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage2.SuspendLayout();
            panel_Titulo.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToResizeColumns = false;
            dgvDatos.AllowUserToResizeRows = false;
            dgvDatos.BackgroundColor = Color.White;
            dgvDatos.BorderStyle = BorderStyle.None;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { EjeX, EjeY, X_Cuadrado, Y_Cuadrado, XPORY });
            dgvDatos.Location = new Point(6, 81);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.Size = new Size(678, 318);
            dgvDatos.TabIndex = 0;
            dgvDatos.CellContentClick += dgvDatos_CellContentClick;
            dgvDatos.CellValueChanged += dgvDatos_CellValueChanged;
            dgvDatos.ColumnAdded += dgvDatos_ColumnAdded;
            dgvDatos.RowsAdded += dgvDatos_RowsAdded;
            // 
            // EjeX
            // 
            EjeX.HeaderText = "X";
            EjeX.MinimumWidth = 6;
            EjeX.Name = "EjeX";
            EjeX.Width = 125;
            // 
            // EjeY
            // 
            EjeY.HeaderText = "Y";
            EjeY.MinimumWidth = 6;
            EjeY.Name = "EjeY";
            EjeY.Width = 125;
            // 
            // X_Cuadrado
            // 
            X_Cuadrado.HeaderText = "X^2";
            X_Cuadrado.MinimumWidth = 6;
            X_Cuadrado.Name = "X_Cuadrado";
            X_Cuadrado.ReadOnly = true;
            X_Cuadrado.Width = 125;
            // 
            // Y_Cuadrado
            // 
            Y_Cuadrado.HeaderText = "Y^2";
            Y_Cuadrado.MinimumWidth = 6;
            Y_Cuadrado.Name = "Y_Cuadrado";
            Y_Cuadrado.ReadOnly = true;
            Y_Cuadrado.Width = 125;
            // 
            // XPORY
            // 
            XPORY.HeaderText = "X*Y";
            XPORY.MinimumWidth = 6;
            XPORY.Name = "XPORY";
            XPORY.ReadOnly = true;
            XPORY.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 27);
            label1.Name = "label1";
            label1.Size = new Size(396, 18);
            label1.TabIndex = 1;
            label1.Text = "Por favor, Inserte Los datos del eje X y Y en el Panel";
            label1.Click += label1_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.FromArgb(104, 122, 177);
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalcular.ForeColor = Color.White;
            btnCalcular.Location = new Point(473, 22);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(97, 38);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += button1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 86);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(780, 536);
            tabControl1.TabIndex = 18;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            tabControl1.Selected += tabControl1_Selected;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btndelete);
            tabPage1.Controls.Add(btnRegresar);
            tabPage1.Controls.Add(dgvDatos);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(btnCalcular);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(772, 503);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Datos";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btndelete
            // 
            btndelete.ImageKey = "Icono_Eliminar.png";
            btndelete.ImageList = ListaImagenes;
            btndelete.Location = new Point(509, 417);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(75, 60);
            btndelete.TabIndex = 22;
            btndelete.Text = "Eliminar";
            btndelete.TextAlign = ContentAlignment.BottomCenter;
            btndelete.TextImageRelation = TextImageRelation.ImageAboveText;
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click_1;
            // 
            // ListaImagenes
            // 
            ListaImagenes.ColorDepth = ColorDepth.Depth32Bit;
            ListaImagenes.ImageStream = (ImageListStreamer)resources.GetObject("ListaImagenes.ImageStream");
            ListaImagenes.TransparentColor = Color.Transparent;
            ListaImagenes.Images.SetKeyName(0, "Icono_Eliminar.png");
            ListaImagenes.Images.SetKeyName(1, "Icono_Regresar.png");
            // 
            // btnRegresar
            // 
            btnRegresar.ImageKey = "Icono_Regresar.png";
            btnRegresar.ImageList = ListaImagenes;
            btnRegresar.Location = new Point(609, 417);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(75, 60);
            btnRegresar.TabIndex = 21;
            btnRegresar.Text = "Regresar";
            btnRegresar.TextAlign = ContentAlignment.BottomCenter;
            btnRegresar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click_1;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(richTextBox1);
            tabPage3.Controls.Add(txtMin);
            tabPage3.Controls.Add(txtMax);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(lblAnalisisb1);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(Ttxt);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(Rtxt);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(b1txt);
            tabPage3.Controls.Add(txttt);
            tabPage3.Controls.Add(b0txt);
            tabPage3.Controls.Add(label3);
            tabPage3.Controls.Add(Rcuadradotxt);
            tabPage3.Controls.Add(label2);
            tabPage3.Controls.Add(RVtxt);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(772, 503);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Calculos";
            tabPage3.UseVisualStyleBackColor = true;
            tabPage3.Click += tabPage3_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(270, 24);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(446, 283);
            richTextBox1.TabIndex = 35;
            richTextBox1.Text = "";
            // 
            // txtMin
            // 
            txtMin.Location = new Point(91, 400);
            txtMin.Name = "txtMin";
            txtMin.ReadOnly = true;
            txtMin.Size = new Size(125, 27);
            txtMin.TabIndex = 34;
            // 
            // txtMax
            // 
            txtMax.Location = new Point(91, 355);
            txtMax.Name = "txtMax";
            txtMax.ReadOnly = true;
            txtMax.Size = new Size(125, 27);
            txtMax.TabIndex = 33;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 400);
            label8.Name = "label8";
            label8.Size = new Size(60, 20);
            label8.TabIndex = 32;
            label8.Text = "Minimo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 358);
            label7.Name = "label7";
            label7.Size = new Size(63, 20);
            label7.TabIndex = 31;
            label7.Text = "Maximo";
            // 
            // lblAnalisisb1
            // 
            lblAnalisisb1.AutoSize = true;
            lblAnalisisb1.Location = new Point(26, 62);
            lblAnalisisb1.Name = "lblAnalisisb1";
            lblAnalisisb1.Size = new Size(99, 20);
            lblAnalisisb1.TabIndex = 30;
            lblAnalisisb1.Text = "lbl analisis b1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 302);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 29;
            label4.Text = "t-student";
            // 
            // Ttxt
            // 
            Ttxt.Location = new Point(91, 299);
            Ttxt.Name = "Ttxt";
            Ttxt.ReadOnly = true;
            Ttxt.Size = new Size(125, 27);
            Ttxt.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 209);
            label6.Name = "label6";
            label6.Size = new Size(18, 20);
            label6.TabIndex = 27;
            label6.Text = "R";
            // 
            // Rtxt
            // 
            Rtxt.Location = new Point(62, 209);
            Rtxt.Name = "Rtxt";
            Rtxt.ReadOnly = true;
            Rtxt.Size = new Size(125, 27);
            Rtxt.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 260);
            label5.Name = "label5";
            label5.Size = new Size(27, 20);
            label5.TabIndex = 26;
            label5.Text = "RV";
            // 
            // b1txt
            // 
            b1txt.Location = new Point(62, 21);
            b1txt.Name = "b1txt";
            b1txt.ReadOnly = true;
            b1txt.Size = new Size(92, 27);
            b1txt.TabIndex = 18;
            // 
            // txttt
            // 
            txttt.AutoSize = true;
            txttt.Location = new Point(16, 165);
            txttt.Name = "txttt";
            txttt.Size = new Size(36, 20);
            txttt.TabIndex = 25;
            txttt.Text = "R^2";
            // 
            // b0txt
            // 
            b0txt.Location = new Point(62, 110);
            b0txt.Name = "b0txt";
            b0txt.ReadOnly = true;
            b0txt.Size = new Size(92, 27);
            b0txt.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 113);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 24;
            label3.Text = "b0 = ";
            // 
            // Rcuadradotxt
            // 
            Rcuadradotxt.Location = new Point(62, 162);
            Rcuadradotxt.Name = "Rcuadradotxt";
            Rcuadradotxt.ReadOnly = true;
            Rcuadradotxt.Size = new Size(125, 27);
            Rcuadradotxt.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 24);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 23;
            label2.Text = "b1 =";
            label2.Click += label2_Click;
            // 
            // RVtxt
            // 
            RVtxt.Location = new Point(62, 253);
            RVtxt.Name = "RVtxt";
            RVtxt.ReadOnly = true;
            RVtxt.Size = new Size(125, 27);
            RVtxt.TabIndex = 22;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(formsPlot1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(772, 503);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Grafica";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // formsPlot1
            // 
            formsPlot1.DisplayScale = 1.25F;
            formsPlot1.Location = new Point(200, 64);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(350, 350);
            formsPlot1.TabIndex = 0;
            formsPlot1.Load += formsPlot1_Load;
            // 
            // panel_Titulo
            // 
            panel_Titulo.BackColor = Color.FromArgb(102, 102, 255);
            panel_Titulo.Controls.Add(lblDatos);
            panel_Titulo.Dock = DockStyle.Top;
            panel_Titulo.Location = new Point(0, 0);
            panel_Titulo.Name = "panel_Titulo";
            panel_Titulo.Size = new Size(802, 70);
            panel_Titulo.TabIndex = 19;
            // 
            // lblDatos
            // 
            lblDatos.AutoSize = true;
            lblDatos.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatos.ForeColor = SystemColors.ButtonHighlight;
            lblDatos.Location = new Point(16, 22);
            lblDatos.Name = "lblDatos";
            lblDatos.Size = new Size(174, 25);
            lblDatos.TabIndex = 0;
            lblDatos.Text = "Agregar Datos";
            // 
            // frmDatos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 628);
            Controls.Add(panel_Titulo);
            Controls.Add(tabControl1);
            Name = "frmDatos";
            Text = "frmDatos";
            Load += frmDatos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage2.ResumeLayout(false);
            panel_Titulo.ResumeLayout(false);
            panel_Titulo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDatos;
        private Label label1;
        private Button btnCalcular;
        private DataGridViewTextBoxColumn EjeX;
        private DataGridViewTextBoxColumn EjeY;
        private DataGridViewTextBoxColumn X_Cuadrado;
        private DataGridViewTextBoxColumn Y_Cuadrado;
        private DataGridViewTextBoxColumn XPORY;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panel_Titulo;
        private Label lblDatos;
        private ImageList ListaImagenes;
        private Button btndelete;
        private Button btnRegresar;
        private TabPage tabPage3;
        private Label label4;
        private TextBox Ttxt;
        private Label label6;
        private TextBox Rtxt;
        private Label label5;
        private TextBox b1txt;
        private Label txttt;
        private TextBox b0txt;
        private Label label3;
        private TextBox Rcuadradotxt;
        private Label label2;
        private TextBox RVtxt;
        private Label lblAnalisisb1;
        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private TextBox txtMin;
        private TextBox txtMax;
        private Label label8;
        private Label label7;
        private RichTextBox richTextBox1;
    }
}