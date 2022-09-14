namespace Presentacion
{
    partial class FRM_Lista__de_Clientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Dg2 = new System.Windows.Forms.DataGridView();
            this.BT_CLOSE = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.Dg2)).BeginInit();
            this.SuspendLayout();
            // 
            // Dg2
            // 
            this.Dg2.AllowUserToAddRows = false;
            this.Dg2.AllowUserToDeleteRows = false;
            this.Dg2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Dg2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Dg2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(68)))));
            this.Dg2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dg2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dg2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dg2.ColumnHeadersHeight = 20;
            this.Dg2.EnableHeadersVisualStyles = false;
            this.Dg2.GridColor = System.Drawing.Color.SteelBlue;
            this.Dg2.Location = new System.Drawing.Point(0, 38);
            this.Dg2.Name = "Dg2";
            this.Dg2.ReadOnly = true;
            this.Dg2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dg2.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dg2.RowHeadersVisible = false;
            this.Dg2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.Dg2.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Dg2.Size = new System.Drawing.Size(887, 413);
            this.Dg2.TabIndex = 55;
            this.Dg2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dg2_CellContentClick);
            this.Dg2.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dg2_CellMouseDown);
            this.Dg2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Dg2_MouseDown);
            // 
            // BT_CLOSE
            // 
            this.BT_CLOSE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_CLOSE.BackColor = System.Drawing.Color.Transparent;
            this.BT_CLOSE.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BT_CLOSE.FlatAppearance.BorderSize = 0;
            this.BT_CLOSE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.BT_CLOSE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BT_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_CLOSE.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BT_CLOSE.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.BT_CLOSE.IconColor = System.Drawing.Color.White;
            this.BT_CLOSE.IconSize = 30;
            this.BT_CLOSE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_CLOSE.Location = new System.Drawing.Point(844, 1);
            this.BT_CLOSE.Name = "BT_CLOSE";
            this.BT_CLOSE.Rotation = 0D;
            this.BT_CLOSE.Size = new System.Drawing.Size(45, 35);
            this.BT_CLOSE.TabIndex = 56;
            this.BT_CLOSE.UseVisualStyleBackColor = false;
            this.BT_CLOSE.Click += new System.EventHandler(this.BT_CLOSE_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.Location = new System.Drawing.Point(0, 1);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(187, 35);
            this.iconButton1.TabIndex = 57;
            this.iconButton1.Text = "iconButton1";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // FRM_Lista__de_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(889, 450);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.BT_CLOSE);
            this.Controls.Add(this.Dg2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Lista__de_Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Lista__de_Clientes";
            this.Load += new System.EventHandler(this.FRM_Lista__de_Clientes_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FRM_Lista__de_Clientes_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.Dg2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView Dg2;
        private FontAwesome.Sharp.IconButton BT_CLOSE;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}