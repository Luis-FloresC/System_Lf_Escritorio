namespace Presentacion
{
    partial class FRM_PAGOS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_PAGOS));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.INFO_CLIENTE = new System.Windows.Forms.Panel();
            this.LB_DNI = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.LB_DIRECCION = new System.Windows.Forms.Label();
            this.LB_TELEFONO = new System.Windows.Forms.Label();
            this.LB_NOMBRE = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.INFO_PRESTAMO = new System.Windows.Forms.Panel();
            this.LB_FECHA_FIN = new System.Windows.Forms.Label();
            this.LB_CUOTA = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LB_PLAZO = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LB_FECHA_INI = new System.Windows.Forms.Label();
            this.LB_MONTO = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Dg2 = new System.Windows.Forms.DataGridView();
            this.BT_PAGAR = new System.Windows.Forms.Button();
            this.BT_CANCELAR = new System.Windows.Forms.Button();
            this.BTN_CERRAR = new System.Windows.Forms.PictureBox();
            this.LB_TOTAL = new System.Windows.Forms.Label();
            this.INFO_CLIENTE.SuspendLayout();
            this.panel2.SuspendLayout();
            this.INFO_PRESTAMO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_CERRAR)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Escribe tu numero de Identidad";
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // INFO_CLIENTE
            // 
            this.INFO_CLIENTE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.INFO_CLIENTE.Controls.Add(this.LB_DNI);
            this.INFO_CLIENTE.Controls.Add(this.label14);
            this.INFO_CLIENTE.Controls.Add(this.LB_DIRECCION);
            this.INFO_CLIENTE.Controls.Add(this.LB_TELEFONO);
            this.INFO_CLIENTE.Controls.Add(this.LB_NOMBRE);
            this.INFO_CLIENTE.Controls.Add(this.label6);
            this.INFO_CLIENTE.Controls.Add(this.label5);
            this.INFO_CLIENTE.Controls.Add(this.label4);
            this.INFO_CLIENTE.Controls.Add(this.label2);
            this.INFO_CLIENTE.Controls.Add(this.label17);
            this.INFO_CLIENTE.Controls.Add(this.label16);
            this.INFO_CLIENTE.Controls.Add(this.label15);
            this.INFO_CLIENTE.Controls.Add(this.label13);
            this.INFO_CLIENTE.Location = new System.Drawing.Point(12, 97);
            this.INFO_CLIENTE.Name = "INFO_CLIENTE";
            this.INFO_CLIENTE.Size = new System.Drawing.Size(377, 149);
            this.INFO_CLIENTE.TabIndex = 1;
            this.INFO_CLIENTE.Visible = false;
            // 
            // LB_DNI
            // 
            this.LB_DNI.AutoSize = true;
            this.LB_DNI.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_DNI.ForeColor = System.Drawing.Color.White;
            this.LB_DNI.Location = new System.Drawing.Point(156, 60);
            this.LB_DNI.Name = "LB_DNI";
            this.LB_DNI.Size = new System.Drawing.Size(28, 16);
            this.LB_DNI.TabIndex = 12;
            this.LB_DNI.Text = "****";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(84, 58);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 18);
            this.label14.TabIndex = 11;
            this.label14.Text = "Identidad";
            // 
            // LB_DIRECCION
            // 
            this.LB_DIRECCION.AutoSize = true;
            this.LB_DIRECCION.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_DIRECCION.ForeColor = System.Drawing.Color.White;
            this.LB_DIRECCION.Location = new System.Drawing.Point(156, 114);
            this.LB_DIRECCION.Name = "LB_DIRECCION";
            this.LB_DIRECCION.Size = new System.Drawing.Size(28, 16);
            this.LB_DIRECCION.TabIndex = 10;
            this.LB_DIRECCION.Text = "****";
            // 
            // LB_TELEFONO
            // 
            this.LB_TELEFONO.AutoSize = true;
            this.LB_TELEFONO.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_TELEFONO.ForeColor = System.Drawing.Color.White;
            this.LB_TELEFONO.Location = new System.Drawing.Point(156, 86);
            this.LB_TELEFONO.Name = "LB_TELEFONO";
            this.LB_TELEFONO.Size = new System.Drawing.Size(28, 16);
            this.LB_TELEFONO.TabIndex = 9;
            this.LB_TELEFONO.Text = "****";
            // 
            // LB_NOMBRE
            // 
            this.LB_NOMBRE.AutoSize = true;
            this.LB_NOMBRE.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_NOMBRE.ForeColor = System.Drawing.Color.White;
            this.LB_NOMBRE.Location = new System.Drawing.Point(156, 30);
            this.LB_NOMBRE.Name = "LB_NOMBRE";
            this.LB_NOMBRE.Size = new System.Drawing.Size(28, 16);
            this.LB_NOMBRE.TabIndex = 7;
            this.LB_NOMBRE.Text = "****";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(75, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Direccion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(84, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre del Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(111, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Informacion del Cliente";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(153, 120);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(199, 13);
            this.label17.TabIndex = 16;
            this.label17.Text = "________________________________";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(153, 92);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(199, 13);
            this.label16.TabIndex = 15;
            this.label16.Text = "________________________________";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(153, 66);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(199, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "________________________________";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(153, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(199, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "________________________________";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(195, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(416, 70);
            this.panel2.TabIndex = 2;
      
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Identidad";
            // 
            // INFO_PRESTAMO
            // 
            this.INFO_PRESTAMO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.INFO_PRESTAMO.Controls.Add(this.LB_FECHA_FIN);
            this.INFO_PRESTAMO.Controls.Add(this.LB_CUOTA);
            this.INFO_PRESTAMO.Controls.Add(this.label11);
            this.INFO_PRESTAMO.Controls.Add(this.LB_PLAZO);
            this.INFO_PRESTAMO.Controls.Add(this.label10);
            this.INFO_PRESTAMO.Controls.Add(this.LB_FECHA_INI);
            this.INFO_PRESTAMO.Controls.Add(this.LB_MONTO);
            this.INFO_PRESTAMO.Controls.Add(this.label9);
            this.INFO_PRESTAMO.Controls.Add(this.label8);
            this.INFO_PRESTAMO.Controls.Add(this.label7);
            this.INFO_PRESTAMO.Controls.Add(this.label3);
            this.INFO_PRESTAMO.Location = new System.Drawing.Point(395, 98);
            this.INFO_PRESTAMO.Name = "INFO_PRESTAMO";
            this.INFO_PRESTAMO.Size = new System.Drawing.Size(382, 148);
            this.INFO_PRESTAMO.TabIndex = 4;
            this.INFO_PRESTAMO.Visible = false;

            // 
            // LB_FECHA_FIN
            // 
            this.LB_FECHA_FIN.AutoSize = true;
            this.LB_FECHA_FIN.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_FECHA_FIN.ForeColor = System.Drawing.Color.White;
            this.LB_FECHA_FIN.Location = new System.Drawing.Point(209, 103);
            this.LB_FECHA_FIN.Name = "LB_FECHA_FIN";
            this.LB_FECHA_FIN.Size = new System.Drawing.Size(28, 16);
            this.LB_FECHA_FIN.TabIndex = 14;
            this.LB_FECHA_FIN.Text = "****";
            // 
            // LB_CUOTA
            // 
            this.LB_CUOTA.AutoSize = true;
            this.LB_CUOTA.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_CUOTA.ForeColor = System.Drawing.Color.White;
            this.LB_CUOTA.Location = new System.Drawing.Point(209, 67);
            this.LB_CUOTA.Name = "LB_CUOTA";
            this.LB_CUOTA.Size = new System.Drawing.Size(28, 16);
            this.LB_CUOTA.TabIndex = 13;
            this.LB_CUOTA.Text = "****";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(19, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(188, 18);
            this.label11.TabIndex = 11;
            this.label11.Text = "Fecha Cuando Terminara:";
            // 
            // LB_PLAZO
            // 
            this.LB_PLAZO.AutoSize = true;
            this.LB_PLAZO.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_PLAZO.ForeColor = System.Drawing.Color.White;
            this.LB_PLAZO.Location = new System.Drawing.Point(209, 49);
            this.LB_PLAZO.Name = "LB_PLAZO";
            this.LB_PLAZO.Size = new System.Drawing.Size(28, 16);
            this.LB_PLAZO.TabIndex = 12;
            this.LB_PLAZO.Text = "****";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(52, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 18);
            this.label10.TabIndex = 10;
            this.label10.Text = "Fecha Cuando Inicio:";
            // 
            // LB_FECHA_INI
            // 
            this.LB_FECHA_INI.AutoSize = true;
            this.LB_FECHA_INI.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_FECHA_INI.ForeColor = System.Drawing.Color.White;
            this.LB_FECHA_INI.Location = new System.Drawing.Point(209, 85);
            this.LB_FECHA_INI.Name = "LB_FECHA_INI";
            this.LB_FECHA_INI.Size = new System.Drawing.Size(28, 16);
            this.LB_FECHA_INI.TabIndex = 11;
            this.LB_FECHA_INI.Text = "****";
            // 
            // LB_MONTO
            // 
            this.LB_MONTO.AutoSize = true;
            this.LB_MONTO.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_MONTO.ForeColor = System.Drawing.Color.White;
            this.LB_MONTO.Location = new System.Drawing.Point(209, 29);
            this.LB_MONTO.Name = "LB_MONTO";
            this.LB_MONTO.Size = new System.Drawing.Size(28, 16);
            this.LB_MONTO.TabIndex = 8;
            this.LB_MONTO.Text = "****";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(153, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 18);
            this.label9.TabIndex = 9;
            this.label9.Text = "Cuota:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(156, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 18);
            this.label8.TabIndex = 8;
            this.label8.Text = "Plazo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(55, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Monto del Prestamo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(105, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Informacion del Prestamo";
            // 
            // Dg2
            // 
            this.Dg2.AllowUserToAddRows = false;
            this.Dg2.AllowUserToDeleteRows = false;
            this.Dg2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Dg2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Dg2.BackgroundColor = System.Drawing.Color.White;
            this.Dg2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dg2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dg2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Dg2.ColumnHeadersHeight = 20;
            this.Dg2.EnableHeadersVisualStyles = false;
            this.Dg2.GridColor = System.Drawing.Color.SteelBlue;
            this.Dg2.Location = new System.Drawing.Point(60, 252);
            this.Dg2.Name = "Dg2";
            this.Dg2.ReadOnly = true;
            this.Dg2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dg2.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Dg2.RowHeadersVisible = false;
            this.Dg2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.Dg2.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.Dg2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Dg2.Size = new System.Drawing.Size(670, 135);
            this.Dg2.TabIndex = 57;
            this.Dg2.Visible = false;
            this.Dg2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dg2_CellClick);
            this.Dg2.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.Dg2_CellFormatting);
            // 
            // BT_PAGAR
            // 
            this.BT_PAGAR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BT_PAGAR.Location = new System.Drawing.Point(216, 393);
            this.BT_PAGAR.Name = "BT_PAGAR";
            this.BT_PAGAR.Size = new System.Drawing.Size(173, 36);
            this.BT_PAGAR.TabIndex = 3;
            this.BT_PAGAR.Text = "Pagar";
            this.BT_PAGAR.UseVisualStyleBackColor = true;
            this.BT_PAGAR.Click += new System.EventHandler(this.BT_PAGAR_Click);
            // 
            // BT_CANCELAR
            // 
            this.BT_CANCELAR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BT_CANCELAR.Location = new System.Drawing.Point(395, 393);
            this.BT_CANCELAR.Name = "BT_CANCELAR";
            this.BT_CANCELAR.Size = new System.Drawing.Size(173, 36);
            this.BT_CANCELAR.TabIndex = 58;
            this.BT_CANCELAR.Text = "Cancelar";
            this.BT_CANCELAR.UseVisualStyleBackColor = true;
            // 
            // BTN_CERRAR
            // 
            this.BTN_CERRAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_CERRAR.BackColor = System.Drawing.Color.Transparent;
            this.BTN_CERRAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_CERRAR.Image = ((System.Drawing.Image)(resources.GetObject("BTN_CERRAR.Image")));
            this.BTN_CERRAR.Location = new System.Drawing.Point(-5, -6);
            this.BTN_CERRAR.Name = "BTN_CERRAR";
            this.BTN_CERRAR.Size = new System.Drawing.Size(52, 51);
            this.BTN_CERRAR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BTN_CERRAR.TabIndex = 59;
            this.BTN_CERRAR.TabStop = false;
            this.BTN_CERRAR.Click += new System.EventHandler(this.BTN_CERRAR_Click);
            // 
            // LB_TOTAL
            // 
            this.LB_TOTAL.AutoSize = true;
            this.LB_TOTAL.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_TOTAL.Location = new System.Drawing.Point(696, 249);
            this.LB_TOTAL.Name = "LB_TOTAL";
            this.LB_TOTAL.Size = new System.Drawing.Size(34, 23);
            this.LB_TOTAL.TabIndex = 11;
            this.LB_TOTAL.Text = "****";
            this.LB_TOTAL.Visible = false;
            // 
            // FRM_PAGOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 439);
            this.Controls.Add(this.LB_TOTAL);
            this.Controls.Add(this.BTN_CERRAR);
            this.Controls.Add(this.BT_CANCELAR);
            this.Controls.Add(this.BT_PAGAR);
            this.Controls.Add(this.Dg2);
            this.Controls.Add(this.INFO_PRESTAMO);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.INFO_CLIENTE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_PAGOS";
            this.Text = "FRM_PAGOS";
            this.Load += new System.EventHandler(this.FRM_PAGOS_Load);
            this.INFO_CLIENTE.ResumeLayout(false);
            this.INFO_CLIENTE.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.INFO_PRESTAMO.ResumeLayout(false);
            this.INFO_PRESTAMO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_CERRAR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel INFO_CLIENTE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel INFO_PRESTAMO;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.DataGridView Dg2;
        private System.Windows.Forms.Button BT_PAGAR;
        private System.Windows.Forms.Button BT_CANCELAR;
        private System.Windows.Forms.PictureBox BTN_CERRAR;
        private System.Windows.Forms.Label LB_DIRECCION;
        private System.Windows.Forms.Label LB_TELEFONO;
        private System.Windows.Forms.Label LB_NOMBRE;
        private System.Windows.Forms.Label LB_FECHA_FIN;
        private System.Windows.Forms.Label LB_CUOTA;
        private System.Windows.Forms.Label LB_PLAZO;
        private System.Windows.Forms.Label LB_FECHA_INI;
        private System.Windows.Forms.Label LB_MONTO;
        private System.Windows.Forms.Label LB_TOTAL;
        private System.Windows.Forms.Label LB_DNI;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
    }
}