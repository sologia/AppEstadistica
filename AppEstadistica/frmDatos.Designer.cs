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
            b1txt = new TextBox();
            b0txt = new TextBox();
            Rcuadradotxt = new TextBox();
            Rtxt = new TextBox();
            RVtxt = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txttt = new Label();
            label5 = new Label();
            label6 = new Label();
            Ttxt = new TextBox();
            label4 = new Label();
            txtprueba = new TextBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            panel_Titulo = new Panel();
            lblDatos = new Label();
            btnRegresar = new Button();
            btndelete = new Button();
            ListaImagenes = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
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
            btnCalcular.Location = new Point(473, 22);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += button1_Click;
            // 
            // b1txt
            // 
            b1txt.Location = new Point(804, 182);
            b1txt.Name = "b1txt";
            b1txt.Size = new Size(125, 27);
            b1txt.TabIndex = 4;
            // 
            // b0txt
            // 
            b0txt.Location = new Point(804, 253);
            b0txt.Name = "b0txt";
            b0txt.Size = new Size(125, 27);
            b0txt.TabIndex = 5;
            // 
            // Rcuadradotxt
            // 
            Rcuadradotxt.Location = new Point(804, 309);
            Rcuadradotxt.Name = "Rcuadradotxt";
            Rcuadradotxt.Size = new Size(125, 27);
            Rcuadradotxt.TabIndex = 6;
            // 
            // Rtxt
            // 
            Rtxt.Location = new Point(959, 309);
            Rtxt.Name = "Rtxt";
            Rtxt.Size = new Size(125, 27);
            Rtxt.TabIndex = 7;
            // 
            // RVtxt
            // 
            RVtxt.Location = new Point(804, 372);
            RVtxt.Name = "RVtxt";
            RVtxt.Size = new Size(125, 27);
            RVtxt.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(813, 158);
            label2.Name = "label2";
            label2.Size = new Size(26, 20);
            label2.TabIndex = 9;
            label2.Text = "b1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(813, 229);
            label3.Name = "label3";
            label3.Size = new Size(26, 20);
            label3.TabIndex = 10;
            label3.Text = "b0";
            // 
            // txttt
            // 
            txttt.AutoSize = true;
            txttt.Location = new Point(813, 285);
            txttt.Name = "txttt";
            txttt.Size = new Size(36, 20);
            txttt.TabIndex = 11;
            txttt.Text = "R^2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(813, 348);
            label5.Name = "label5";
            label5.Size = new Size(27, 20);
            label5.TabIndex = 12;
            label5.Text = "RV";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1005, 286);
            label6.Name = "label6";
            label6.Size = new Size(18, 20);
            label6.TabIndex = 13;
            label6.Text = "R";
            // 
            // Ttxt
            // 
            Ttxt.Location = new Point(959, 372);
            Ttxt.Name = "Ttxt";
            Ttxt.Size = new Size(125, 27);
            Ttxt.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(985, 349);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 15;
            label4.Text = "t-student";
            // 
            // txtprueba
            // 
            txtprueba.Location = new Point(831, 69);
            txtprueba.Name = "txtprueba";
            txtprueba.Size = new Size(125, 27);
            txtprueba.TabIndex = 17;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 86);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1069, 446);
            tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvDatos);
            tabPage1.Controls.Add(txtprueba);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(Ttxt);
            tabPage1.Controls.Add(btnCalcular);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(Rtxt);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(b1txt);
            tabPage1.Controls.Add(txttt);
            tabPage1.Controls.Add(b0txt);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(Rcuadradotxt);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(RVtxt);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1061, 413);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Datos";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1061, 491);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Grafica";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel_Titulo
            // 
            panel_Titulo.BackColor = Color.FromArgb(102, 102, 255);
            panel_Titulo.Controls.Add(lblDatos);
            panel_Titulo.Dock = DockStyle.Top;
            panel_Titulo.Location = new Point(0, 0);
            panel_Titulo.Name = "panel_Titulo";
            panel_Titulo.Size = new Size(1089, 70);
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
            // btnRegresar
            // 
            btnRegresar.Location = new Point(589, 568);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(111, 70);
            btnRegresar.TabIndex = 18;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            // 
            // btndelete
            // 
            btndelete.Location = new Point(448, 568);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(111, 70);
            btndelete.TabIndex = 20;
            btndelete.Text = "Eliminar";
            btndelete.UseVisualStyleBackColor = true;
            // 
            // ListaImagenes
            // 
            ListaImagenes.ColorDepth = ColorDepth.Depth32Bit;
            ListaImagenes.ImageStream = (ImageListStreamer)resources.GetObject("ListaImagenes.ImageStream");
            ListaImagenes.TransparentColor = Color.Transparent;
            ListaImagenes.Images.SetKeyName(0, "Icono_Eliminar.png");
            ListaImagenes.Images.SetKeyName(1, "Icono_Regresar.png");
            // 
            // frmDatos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 717);
            Controls.Add(btndelete);
            Controls.Add(btnRegresar);
            Controls.Add(panel_Titulo);
            Controls.Add(tabControl1);
            Name = "frmDatos";
            Text = "frmDatos";
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel_Titulo.ResumeLayout(false);
            panel_Titulo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDatos;
        private Label label1;
        private Button btnCalcular;
        private TextBox b1txt;
        private TextBox b0txt;
        private TextBox Rcuadradotxt;
        private TextBox Rtxt;
        private TextBox RVtxt;
        private Label label2;
        private Label label3;
        private Label txttt;
        private Label label5;
        private Label label6;
        private TextBox Ttxt;
        private Label label4;
        private DataGridViewTextBoxColumn EjeX;
        private DataGridViewTextBoxColumn EjeY;
        private DataGridViewTextBoxColumn X_Cuadrado;
        private DataGridViewTextBoxColumn Y_Cuadrado;
        private DataGridViewTextBoxColumn XPORY;
        private TextBox txtprueba;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panel_Titulo;
        private Label lblDatos;
        private Button btnRegresar;
        private Button btndelete;
        private ImageList ListaImagenes;
    }
}