namespace Presentacion
{
    partial class FrmInventario
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
            this.pnlHeader = new ns1.BunifuCards();
            this.progressbar = new ns1.BunifuProgressBar();
            this.btnExcel = new ns1.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.GVBitacora = new ns1.BunifuCustomDataGrid();
            this.txtAutor = new ns1.BunifuMetroTextbox();
            this.txtLibro = new ns1.BunifuMetroTextbox();
            this.cbFecha = new ns1.BunifuCheckbox();
            this.cbAutor = new ns1.BunifuCheckbox();
            this.cbLibro = new ns1.BunifuCheckbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFiltrar = new ns1.BunifuFlatButton();
            this.dpFecha = new ns1.BunifuDatepicker();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVBitacora)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(28)))), ((int)(((byte)(35)))));
            this.pnlHeader.BorderRadius = 0;
            this.pnlHeader.BottomSahddow = true;
            this.pnlHeader.color = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(28)))), ((int)(((byte)(35)))));
            this.pnlHeader.Controls.Add(this.progressbar);
            this.pnlHeader.Controls.Add(this.btnExcel);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.LeftSahddow = false;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.RightSahddow = false;
            this.pnlHeader.ShadowDepth = 20;
            this.pnlHeader.Size = new System.Drawing.Size(880, 40);
            this.pnlHeader.TabIndex = 2;
            // 
            // progressbar
            // 
            this.progressbar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.progressbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.progressbar.BorderRadius = 5;
            this.progressbar.Location = new System.Drawing.Point(237, 16);
            this.progressbar.MaximumValue = 1;
            this.progressbar.Name = "progressbar";
            this.progressbar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(52)))), ((int)(((byte)(0)))));
            this.progressbar.Size = new System.Drawing.Size(497, 10);
            this.progressbar.TabIndex = 56;
            this.progressbar.Value = 0;
            this.progressbar.Visible = false;
            // 
            // btnExcel
            // 
            this.btnExcel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(52)))), ((int)(((byte)(0)))));
            this.btnExcel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(28)))), ((int)(((byte)(35)))));
            this.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcel.BorderRadius = 5;
            this.btnExcel.ButtonText = "     Exportar";
            this.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcel.DisabledColor = System.Drawing.Color.Gray;
            this.btnExcel.Iconcolor = System.Drawing.Color.Transparent;
            this.btnExcel.Iconimage = global::Presentacion.Properties.Resources.Microsoft_Excel_50px;
            this.btnExcel.Iconimage_right = null;
            this.btnExcel.Iconimage_right_Selected = null;
            this.btnExcel.Iconimage_Selected = null;
            this.btnExcel.IconMarginLeft = 0;
            this.btnExcel.IconMarginRight = 0;
            this.btnExcel.IconRightVisible = true;
            this.btnExcel.IconRightZoom = 0D;
            this.btnExcel.IconVisible = true;
            this.btnExcel.IconZoom = 50D;
            this.btnExcel.IsTab = false;
            this.btnExcel.Location = new System.Drawing.Point(745, 3);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(28)))), ((int)(((byte)(35)))));
            this.btnExcel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(52)))), ((int)(((byte)(0)))));
            this.btnExcel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnExcel.selected = false;
            this.btnExcel.Size = new System.Drawing.Size(120, 35);
            this.btnExcel.TabIndex = 36;
            this.btnExcel.TabStop = false;
            this.btnExcel.Text = "     Exportar";
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel.Textcolor = System.Drawing.Color.White;
            this.btnExcel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ubuntu", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "Control de Inventario";
            // 
            // GVBitacora
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            this.GVBitacora.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GVBitacora.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GVBitacora.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GVBitacora.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.GVBitacora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GVBitacora.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GVBitacora.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GVBitacora.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GVBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVBitacora.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(28)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GVBitacora.DefaultCellStyle = dataGridViewCellStyle3;
            this.GVBitacora.DoubleBuffered = true;
            this.GVBitacora.EnableHeadersVisualStyles = false;
            this.GVBitacora.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.GVBitacora.HeaderForeColor = System.Drawing.Color.White;
            this.GVBitacora.Location = new System.Drawing.Point(28, 138);
            this.GVBitacora.Name = "GVBitacora";
            this.GVBitacora.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GVBitacora.RowHeadersVisible = false;
            this.GVBitacora.Size = new System.Drawing.Size(824, 413);
            this.GVBitacora.TabIndex = 36;
            // 
            // txtAutor
            // 
            this.txtAutor.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(116)))), ((int)(((byte)(245)))));
            this.txtAutor.BorderColorIdle = System.Drawing.Color.White;
            this.txtAutor.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(116)))), ((int)(((byte)(245)))));
            this.txtAutor.BorderThickness = 3;
            this.txtAutor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAutor.Enabled = false;
            this.txtAutor.Font = new System.Drawing.Font("Ubuntu", 9.749999F);
            this.txtAutor.ForeColor = System.Drawing.Color.White;
            this.txtAutor.isPassword = false;
            this.txtAutor.Location = new System.Drawing.Point(255, 81);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(4);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(208, 36);
            this.txtAutor.TabIndex = 48;
            this.txtAutor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtLibro
            // 
            this.txtLibro.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(116)))), ((int)(((byte)(245)))));
            this.txtLibro.BorderColorIdle = System.Drawing.Color.White;
            this.txtLibro.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(116)))), ((int)(((byte)(245)))));
            this.txtLibro.BorderThickness = 3;
            this.txtLibro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLibro.Enabled = false;
            this.txtLibro.Font = new System.Drawing.Font("Ubuntu", 9.749999F);
            this.txtLibro.ForeColor = System.Drawing.Color.White;
            this.txtLibro.isPassword = false;
            this.txtLibro.Location = new System.Drawing.Point(28, 81);
            this.txtLibro.Margin = new System.Windows.Forms.Padding(4);
            this.txtLibro.Name = "txtLibro";
            this.txtLibro.Size = new System.Drawing.Size(207, 36);
            this.txtLibro.TabIndex = 49;
            this.txtLibro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cbFecha
            // 
            this.cbFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cbFecha.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cbFecha.Checked = false;
            this.cbFecha.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(116)))), ((int)(((byte)(245)))));
            this.cbFecha.ForeColor = System.Drawing.Color.White;
            this.cbFecha.Location = new System.Drawing.Point(492, 54);
            this.cbFecha.Name = "cbFecha";
            this.cbFecha.Size = new System.Drawing.Size(20, 20);
            this.cbFecha.TabIndex = 45;
            this.cbFecha.Tag = "Fecha";
            this.cbFecha.OnChange += new System.EventHandler(this.cbFecha_OnChange);
            // 
            // cbAutor
            // 
            this.cbAutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cbAutor.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cbAutor.Checked = false;
            this.cbAutor.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(116)))), ((int)(((byte)(245)))));
            this.cbAutor.ForeColor = System.Drawing.Color.White;
            this.cbAutor.Location = new System.Drawing.Point(266, 54);
            this.cbAutor.Name = "cbAutor";
            this.cbAutor.Size = new System.Drawing.Size(20, 20);
            this.cbAutor.TabIndex = 46;
            this.cbAutor.Tag = "Autor";
            this.cbAutor.OnChange += new System.EventHandler(this.cbAutor_OnChange);
            // 
            // cbLibro
            // 
            this.cbLibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cbLibro.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cbLibro.Checked = false;
            this.cbLibro.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(116)))), ((int)(((byte)(245)))));
            this.cbLibro.ForeColor = System.Drawing.Color.White;
            this.cbLibro.Location = new System.Drawing.Point(43, 54);
            this.cbLibro.Name = "cbLibro";
            this.cbLibro.Size = new System.Drawing.Size(20, 20);
            this.cbLibro.TabIndex = 47;
            this.cbLibro.Tag = "Libro";
            this.cbLibro.OnChange += new System.EventHandler(this.cbLibro_OnChange);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(518, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(292, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Autor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(69, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "Titulo";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(52)))), ((int)(((byte)(0)))));
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(28)))), ((int)(((byte)(35)))));
            this.btnFiltrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFiltrar.BorderRadius = 5;
            this.btnFiltrar.ButtonText = "     Filtrar";
            this.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrar.DisabledColor = System.Drawing.Color.Gray;
            this.btnFiltrar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnFiltrar.Iconimage = global::Presentacion.Properties.Resources.Filter_50px;
            this.btnFiltrar.Iconimage_right = null;
            this.btnFiltrar.Iconimage_right_Selected = null;
            this.btnFiltrar.Iconimage_Selected = null;
            this.btnFiltrar.IconMarginLeft = 0;
            this.btnFiltrar.IconMarginRight = 0;
            this.btnFiltrar.IconRightVisible = true;
            this.btnFiltrar.IconRightZoom = 0D;
            this.btnFiltrar.IconVisible = true;
            this.btnFiltrar.IconZoom = 50D;
            this.btnFiltrar.IsTab = false;
            this.btnFiltrar.Location = new System.Drawing.Point(732, 79);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(28)))), ((int)(((byte)(35)))));
            this.btnFiltrar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(52)))), ((int)(((byte)(0)))));
            this.btnFiltrar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnFiltrar.selected = false;
            this.btnFiltrar.Size = new System.Drawing.Size(120, 40);
            this.btnFiltrar.TabIndex = 42;
            this.btnFiltrar.TabStop = false;
            this.btnFiltrar.Text = "     Filtrar";
            this.btnFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltrar.Textcolor = System.Drawing.Color.White;
            this.btnFiltrar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // dpFecha
            // 
            this.dpFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.dpFecha.BorderRadius = 0;
            this.dpFecha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dpFecha.Enabled = false;
            this.dpFecha.ForeColor = System.Drawing.Color.White;
            this.dpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpFecha.FormatCustom = null;
            this.dpFecha.Location = new System.Drawing.Point(476, 81);
            this.dpFecha.Name = "dpFecha";
            this.dpFecha.Size = new System.Drawing.Size(213, 36);
            this.dpFecha.TabIndex = 41;
            this.dpFecha.Tag = "Fecha";
            this.dpFecha.Value = new System.DateTime(2018, 8, 15, 21, 23, 13, 0);
            // 
            // FrmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(880, 579);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtLibro);
            this.Controls.Add(this.cbFecha);
            this.Controls.Add(this.cbAutor);
            this.Controls.Add(this.cbLibro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.dpFecha);
            this.Controls.Add(this.GVBitacora);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInventario";
            this.Load += new System.EventHandler(this.FrmInventario_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVBitacora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuCards pnlHeader;
        private ns1.BunifuProgressBar progressbar;
        private ns1.BunifuFlatButton btnExcel;
        private System.Windows.Forms.Label label1;
        private ns1.BunifuCustomDataGrid GVBitacora;
        private ns1.BunifuMetroTextbox txtAutor;
        private ns1.BunifuMetroTextbox txtLibro;
        private ns1.BunifuCheckbox cbFecha;
        private ns1.BunifuCheckbox cbAutor;
        private ns1.BunifuCheckbox cbLibro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private ns1.BunifuFlatButton btnFiltrar;
        private ns1.BunifuDatepicker dpFecha;
    }
}