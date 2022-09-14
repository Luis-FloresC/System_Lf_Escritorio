namespace Presentacion
{
    partial class FRM_CLIENTES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_CLIENTES));
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_ape = new System.Windows.Forms.TextBox();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.txt_dire = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Guardar = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.Lb_error_DND = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CMB_GEN = new System.Windows.Forms.ComboBox();
            this.LB_ERROR_NOMBRE = new System.Windows.Forms.Label();
            this.LB_ERROR_APE = new System.Windows.Forms.Label();
            this.LB_ERROR_DIRE = new System.Windows.Forms.Label();
            this.LB_ERROR_GEN = new System.Windows.Forms.Label();
            this.NUEVO = new FontAwesome.Sharp.IconButton();
            this.Actualizar = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BUSCAR = new FontAwesome.Sharp.IconPictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.IC_LIMPIAR = new FontAwesome.Sharp.IconButton();
            this.IC_CANCELAR = new FontAwesome.Sharp.IconButton();
            this.MOSTRAR = new FontAwesome.Sharp.IconButton();
            this.BTN_CERRAR = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BUSCAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_CERRAR)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_dni
            // 
            this.txt_dni.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_dni.Enabled = false;
            this.txt_dni.Location = new System.Drawing.Point(16, 107);
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(172, 20);
            this.txt_dni.TabIndex = 0;
            this.txt_dni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dni_KeyPress);
            // 
            // txt_nom
            // 
            this.txt_nom.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_nom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_nom.Enabled = false;
            this.txt_nom.Location = new System.Drawing.Point(211, 107);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(255, 20);
            this.txt_nom.TabIndex = 1;
            // 
            // txt_ape
            // 
            this.txt_ape.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_ape.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_ape.Enabled = false;
            this.txt_ape.Location = new System.Drawing.Point(499, 107);
            this.txt_ape.Name = "txt_ape";
            this.txt_ape.Size = new System.Drawing.Size(255, 20);
            this.txt_ape.TabIndex = 2;
            // 
            // txt_tel
            // 
            this.txt_tel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_tel.Enabled = false;
            this.txt_tel.Location = new System.Drawing.Point(211, 168);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(258, 20);
            this.txt_tel.TabIndex = 4;
            // 
            // txt_dire
            // 
            this.txt_dire.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_dire.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_dire.Enabled = false;
            this.txt_dire.Location = new System.Drawing.Point(17, 234);
            this.txt_dire.Multiline = true;
            this.txt_dire.Name = "txt_dire";
            this.txt_dire.Size = new System.Drawing.Size(453, 58);
            this.txt_dire.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nº DE IDENTIDAD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(208, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "NOMBRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(496, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "APELLIDO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(17, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "GENERO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(208, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "TELEFONO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(17, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "DIRECCION";
            // 
            // Guardar
            // 
            this.Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(196)))));
            this.Guardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Guardar.FlatAppearance.BorderSize = 2;
            this.Guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.Guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(68)))));
            this.Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Guardar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Guardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardar.ForeColor = System.Drawing.Color.White;
            this.Guardar.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            this.Guardar.IconColor = System.Drawing.Color.White;
            this.Guardar.IconSize = 40;
            this.Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardar.Location = new System.Drawing.Point(247, 394);
            this.Guardar.Name = "Guardar";
            this.Guardar.Rotation = 0D;
            this.Guardar.Size = new System.Drawing.Size(267, 46);
            this.Guardar.TabIndex = 15;
            this.Guardar.Text = "Registrar Cliente";
            this.Guardar.UseVisualStyleBackColor = false;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(224, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(296, 36);
            this.label7.TabIndex = 16;
            this.label7.Text = "Registro De Clientes";
            // 
            // Lb_error_DND
            // 
            this.Lb_error_DND.AutoSize = true;
            this.Lb_error_DND.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_error_DND.ForeColor = System.Drawing.Color.Red;
            this.Lb_error_DND.Image = ((System.Drawing.Image)(resources.GetObject("Lb_error_DND.Image")));
            this.Lb_error_DND.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lb_error_DND.Location = new System.Drawing.Point(13, 130);
            this.Lb_error_DND.Name = "Lb_error_DND";
            this.Lb_error_DND.Size = new System.Drawing.Size(175, 16);
            this.Lb_error_DND.TabIndex = 17;
            this.Lb_error_DND.Text = "     CAMPO_OBLIGATORIO";
            this.Lb_error_DND.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(13, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 18);
            this.label8.TabIndex = 19;
            this.label8.Visible = false;
            // 
            // CMB_GEN
            // 
            this.CMB_GEN.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CMB_GEN.Enabled = false;
            this.CMB_GEN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CMB_GEN.FormattingEnabled = true;
            this.CMB_GEN.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMENINO"});
            this.CMB_GEN.Location = new System.Drawing.Point(16, 168);
            this.CMB_GEN.Name = "CMB_GEN";
            this.CMB_GEN.Size = new System.Drawing.Size(172, 21);
            this.CMB_GEN.TabIndex = 20;
            this.CMB_GEN.Text = "SELECCIONE";
            // 
            // LB_ERROR_NOMBRE
            // 
            this.LB_ERROR_NOMBRE.AutoSize = true;
            this.LB_ERROR_NOMBRE.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ERROR_NOMBRE.ForeColor = System.Drawing.Color.Red;
            this.LB_ERROR_NOMBRE.Image = ((System.Drawing.Image)(resources.GetObject("LB_ERROR_NOMBRE.Image")));
            this.LB_ERROR_NOMBRE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LB_ERROR_NOMBRE.Location = new System.Drawing.Point(208, 130);
            this.LB_ERROR_NOMBRE.Name = "LB_ERROR_NOMBRE";
            this.LB_ERROR_NOMBRE.Size = new System.Drawing.Size(175, 16);
            this.LB_ERROR_NOMBRE.TabIndex = 21;
            this.LB_ERROR_NOMBRE.Text = "     CAMPO_OBLIGATORIO";
            this.LB_ERROR_NOMBRE.Visible = false;
            // 
            // LB_ERROR_APE
            // 
            this.LB_ERROR_APE.AutoSize = true;
            this.LB_ERROR_APE.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ERROR_APE.ForeColor = System.Drawing.Color.Red;
            this.LB_ERROR_APE.Image = ((System.Drawing.Image)(resources.GetObject("LB_ERROR_APE.Image")));
            this.LB_ERROR_APE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LB_ERROR_APE.Location = new System.Drawing.Point(496, 132);
            this.LB_ERROR_APE.Name = "LB_ERROR_APE";
            this.LB_ERROR_APE.Size = new System.Drawing.Size(175, 16);
            this.LB_ERROR_APE.TabIndex = 22;
            this.LB_ERROR_APE.Text = "     CAMPO_OBLIGATORIO";
            this.LB_ERROR_APE.Visible = false;
            // 
            // LB_ERROR_DIRE
            // 
            this.LB_ERROR_DIRE.AutoSize = true;
            this.LB_ERROR_DIRE.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ERROR_DIRE.ForeColor = System.Drawing.Color.Red;
            this.LB_ERROR_DIRE.Image = ((System.Drawing.Image)(resources.GetObject("LB_ERROR_DIRE.Image")));
            this.LB_ERROR_DIRE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LB_ERROR_DIRE.Location = new System.Drawing.Point(16, 295);
            this.LB_ERROR_DIRE.Name = "LB_ERROR_DIRE";
            this.LB_ERROR_DIRE.Size = new System.Drawing.Size(175, 16);
            this.LB_ERROR_DIRE.TabIndex = 23;
            this.LB_ERROR_DIRE.Text = "     CAMPO_OBLIGATORIO";
            this.LB_ERROR_DIRE.Visible = false;
            // 
            // LB_ERROR_GEN
            // 
            this.LB_ERROR_GEN.AutoSize = true;
            this.LB_ERROR_GEN.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ERROR_GEN.ForeColor = System.Drawing.Color.Red;
            this.LB_ERROR_GEN.Image = ((System.Drawing.Image)(resources.GetObject("LB_ERROR_GEN.Image")));
            this.LB_ERROR_GEN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LB_ERROR_GEN.Location = new System.Drawing.Point(17, 192);
            this.LB_ERROR_GEN.Name = "LB_ERROR_GEN";
            this.LB_ERROR_GEN.Size = new System.Drawing.Size(175, 16);
            this.LB_ERROR_GEN.TabIndex = 24;
            this.LB_ERROR_GEN.Text = "     CAMPO_OBLIGATORIO";
            this.LB_ERROR_GEN.Visible = false;
            // 
            // NUEVO
            // 
            this.NUEVO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(196)))));
            this.NUEVO.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.NUEVO.FlatAppearance.BorderSize = 2;
            this.NUEVO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.NUEVO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(68)))));
            this.NUEVO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NUEVO.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.NUEVO.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUEVO.ForeColor = System.Drawing.Color.White;
            this.NUEVO.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.NUEVO.IconColor = System.Drawing.Color.White;
            this.NUEVO.IconSize = 40;
            this.NUEVO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NUEVO.Location = new System.Drawing.Point(11, 394);
            this.NUEVO.Name = "NUEVO";
            this.NUEVO.Rotation = 0D;
            this.NUEVO.Size = new System.Drawing.Size(230, 46);
            this.NUEVO.TabIndex = 25;
            this.NUEVO.Text = "NUEVO REGISTRO";
            this.NUEVO.UseVisualStyleBackColor = false;
            this.NUEVO.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // Actualizar
            // 
            this.Actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(196)))));
            this.Actualizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Actualizar.FlatAppearance.BorderSize = 2;
            this.Actualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.Actualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(68)))));
            this.Actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Actualizar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Actualizar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Actualizar.ForeColor = System.Drawing.Color.White;
            this.Actualizar.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.Actualizar.IconColor = System.Drawing.Color.White;
            this.Actualizar.IconSize = 40;
            this.Actualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Actualizar.Location = new System.Drawing.Point(520, 394);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Rotation = 0D;
            this.Actualizar.Size = new System.Drawing.Size(244, 46);
            this.Actualizar.TabIndex = 26;
            this.Actualizar.Text = "         EDITAR CLIENTE";
            this.Actualizar.UseVisualStyleBackColor = false;
            this.Actualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.BUSCAR);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(499, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 140);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(8, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Filtro de Busqueda";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nº DE IDENTIDAD",
            "CODIGO DE CLIENTE",
            "NOMBRE"});
            this.comboBox1.Location = new System.Drawing.Point(11, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(229, 21);
            this.comboBox1.TabIndex = 28;
            this.comboBox1.Text = "SELECCIONE";
            // 
            // BUSCAR
            // 
            this.BUSCAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(196)))));
            this.BUSCAR.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.BUSCAR.IconColor = System.Drawing.Color.White;
            this.BUSCAR.IconSize = 39;
            this.BUSCAR.Location = new System.Drawing.Point(196, 79);
            this.BUSCAR.Name = "BUSCAR";
            this.BUSCAR.Size = new System.Drawing.Size(53, 39);
            this.BUSCAR.TabIndex = 20;
            this.BUSCAR.TabStop = false;
            this.BUSCAR.Click += new System.EventHandler(this.BUSCAR_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(8, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Nº DE IDENTIDAD";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(9, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 20);
            this.textBox1.TabIndex = 18;
            // 
            // IC_LIMPIAR
            // 
            this.IC_LIMPIAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(196)))));
            this.IC_LIMPIAR.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.IC_LIMPIAR.FlatAppearance.BorderSize = 2;
            this.IC_LIMPIAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.IC_LIMPIAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(68)))));
            this.IC_LIMPIAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IC_LIMPIAR.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.IC_LIMPIAR.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IC_LIMPIAR.ForeColor = System.Drawing.Color.White;
            this.IC_LIMPIAR.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.IC_LIMPIAR.IconColor = System.Drawing.Color.White;
            this.IC_LIMPIAR.IconSize = 40;
            this.IC_LIMPIAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IC_LIMPIAR.Location = new System.Drawing.Point(11, 342);
            this.IC_LIMPIAR.Name = "IC_LIMPIAR";
            this.IC_LIMPIAR.Rotation = 0D;
            this.IC_LIMPIAR.Size = new System.Drawing.Size(230, 46);
            this.IC_LIMPIAR.TabIndex = 28;
            this.IC_LIMPIAR.Text = "LIMPIAR";
            this.IC_LIMPIAR.UseVisualStyleBackColor = false;
            this.IC_LIMPIAR.Click += new System.EventHandler(this.IC_LIMPIAR_Click);
            // 
            // IC_CANCELAR
            // 
            this.IC_CANCELAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(196)))));
            this.IC_CANCELAR.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.IC_CANCELAR.FlatAppearance.BorderSize = 2;
            this.IC_CANCELAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.IC_CANCELAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(68)))));
            this.IC_CANCELAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IC_CANCELAR.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.IC_CANCELAR.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IC_CANCELAR.ForeColor = System.Drawing.Color.White;
            this.IC_CANCELAR.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.IC_CANCELAR.IconColor = System.Drawing.Color.White;
            this.IC_CANCELAR.IconSize = 40;
            this.IC_CANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IC_CANCELAR.Location = new System.Drawing.Point(247, 342);
            this.IC_CANCELAR.Name = "IC_CANCELAR";
            this.IC_CANCELAR.Rotation = 0D;
            this.IC_CANCELAR.Size = new System.Drawing.Size(267, 46);
            this.IC_CANCELAR.TabIndex = 29;
            this.IC_CANCELAR.Text = "CANCELAR";
            this.IC_CANCELAR.UseVisualStyleBackColor = false;
            this.IC_CANCELAR.Click += new System.EventHandler(this.IC_CANCELAR_Click);
            // 
            // MOSTRAR
            // 
            this.MOSTRAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(196)))));
            this.MOSTRAR.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.MOSTRAR.FlatAppearance.BorderSize = 2;
            this.MOSTRAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.MOSTRAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(68)))));
            this.MOSTRAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MOSTRAR.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.MOSTRAR.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MOSTRAR.ForeColor = System.Drawing.Color.White;
            this.MOSTRAR.IconChar = FontAwesome.Sharp.IconChar.Readme;
            this.MOSTRAR.IconColor = System.Drawing.Color.White;
            this.MOSTRAR.IconSize = 40;
            this.MOSTRAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MOSTRAR.Location = new System.Drawing.Point(520, 342);
            this.MOSTRAR.Name = "MOSTRAR";
            this.MOSTRAR.Rotation = 0D;
            this.MOSTRAR.Size = new System.Drawing.Size(244, 46);
            this.MOSTRAR.TabIndex = 30;
            this.MOSTRAR.Text = "CLIENTES";
            this.MOSTRAR.UseVisualStyleBackColor = false;
            this.MOSTRAR.Click += new System.EventHandler(this.MOSTRAR_Click);
            // 
            // BTN_CERRAR
            // 
            this.BTN_CERRAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_CERRAR.BackColor = System.Drawing.Color.Transparent;
            this.BTN_CERRAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_CERRAR.Image = ((System.Drawing.Image)(resources.GetObject("BTN_CERRAR.Image")));
            this.BTN_CERRAR.Location = new System.Drawing.Point(-4, -4);
            this.BTN_CERRAR.Name = "BTN_CERRAR";
            this.BTN_CERRAR.Size = new System.Drawing.Size(52, 51);
            this.BTN_CERRAR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BTN_CERRAR.TabIndex = 60;
            this.BTN_CERRAR.TabStop = false;
            this.BTN_CERRAR.Click += new System.EventHandler(this.BTN_CERRAR_Click);
            // 
            // FRM_CLIENTES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(777, 449);
            this.Controls.Add(this.BTN_CERRAR);
            this.Controls.Add(this.MOSTRAR);
            this.Controls.Add(this.IC_CANCELAR);
            this.Controls.Add(this.IC_LIMPIAR);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Actualizar);
            this.Controls.Add(this.NUEVO);
            this.Controls.Add(this.LB_ERROR_GEN);
            this.Controls.Add(this.LB_ERROR_DIRE);
            this.Controls.Add(this.LB_ERROR_APE);
            this.Controls.Add(this.LB_ERROR_NOMBRE);
            this.Controls.Add(this.CMB_GEN);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Lb_error_DND);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_dire);
            this.Controls.Add(this.txt_tel);
            this.Controls.Add(this.txt_ape);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.txt_dni);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_CLIENTES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_CLIENTES";
            this.Load += new System.EventHandler(this.FRM_CLIENTES_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BUSCAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_CERRAR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_ape;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.TextBox txt_dire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton Guardar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Lb_error_DND;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CMB_GEN;
        private System.Windows.Forms.Label LB_ERROR_NOMBRE;
        private System.Windows.Forms.Label LB_ERROR_APE;
        private System.Windows.Forms.Label LB_ERROR_DIRE;
        private System.Windows.Forms.Label LB_ERROR_GEN;
        private FontAwesome.Sharp.IconButton NUEVO;
        private FontAwesome.Sharp.IconButton Actualizar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private FontAwesome.Sharp.IconPictureBox BUSCAR;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private FontAwesome.Sharp.IconButton IC_LIMPIAR;
        private FontAwesome.Sharp.IconButton IC_CANCELAR;
        private FontAwesome.Sharp.IconButton MOSTRAR;
        private System.Windows.Forms.PictureBox BTN_CERRAR;
    }
}