namespace Presentacion
{
    partial class FrmReporte
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new ns1.BunifuCards();
            this.progressbar = new ns1.BunifuProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.dpFechaini = new ns1.BunifuDatepicker();
            this.dpFechafin = new ns1.BunifuDatepicker();
            this.GVReporte = new ns1.BunifuCustomDataGrid();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbCategoria = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbAutor = new System.Windows.Forms.RadioButton();
            this.rbBitacora = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnGenerar = new ns1.BunifuFlatButton();
            this.btnExcel = new ns1.BunifuFlatButton();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVReporte)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.pnlHeader.TabIndex = 1;
            // 
            // progressbar
            // 
            this.progressbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.progressbar.BorderRadius = 5;
            this.progressbar.Location = new System.Drawing.Point(230, 16);
            this.progressbar.MaximumValue = 1;
            this.progressbar.Name = "progressbar";
            this.progressbar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(52)))), ((int)(((byte)(0)))));
            this.progressbar.Size = new System.Drawing.Size(497, 10);
            this.progressbar.TabIndex = 56;
            this.progressbar.Value = 0;
            this.progressbar.Visible = false;
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
            this.label1.Size = new System.Drawing.Size(212, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "Reportes Semanales";
            // 
            // dpFechaini
            // 
            this.dpFechaini.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.dpFechaini.BorderRadius = 0;
            this.dpFechaini.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dpFechaini.ForeColor = System.Drawing.Color.White;
            this.dpFechaini.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpFechaini.FormatCustom = null;
            this.dpFechaini.Location = new System.Drawing.Point(299, 86);
            this.dpFechaini.Name = "dpFechaini";
            this.dpFechaini.Size = new System.Drawing.Size(201, 36);
            this.dpFechaini.TabIndex = 33;
            this.dpFechaini.Tag = "Fecha";
            this.dpFechaini.Value = new System.DateTime(2018, 8, 15, 0, 0, 0, 0);
            this.dpFechaini.onValueChanged += new System.EventHandler(this.dpFechaini_onValueChanged_1);
            // 
            // dpFechafin
            // 
            this.dpFechafin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.dpFechafin.BorderRadius = 0;
            this.dpFechafin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dpFechafin.ForeColor = System.Drawing.Color.White;
            this.dpFechafin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpFechafin.FormatCustom = null;
            this.dpFechafin.Location = new System.Drawing.Point(515, 86);
            this.dpFechafin.Name = "dpFechafin";
            this.dpFechafin.Size = new System.Drawing.Size(201, 36);
            this.dpFechafin.TabIndex = 34;
            this.dpFechafin.Tag = "Fecha";
            this.dpFechafin.Value = new System.DateTime(2018, 8, 15, 0, 0, 0, 0);
            this.dpFechafin.onValueChanged += new System.EventHandler(this.dpFechafin_onValueChanged);
            // 
            // GVReporte
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            this.GVReporte.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GVReporte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GVReporte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GVReporte.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.GVReporte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GVReporte.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GVReporte.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GVReporte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GVReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVReporte.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(28)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GVReporte.DefaultCellStyle = dataGridViewCellStyle3;
            this.GVReporte.DoubleBuffered = true;
            this.GVReporte.EnableHeadersVisualStyles = false;
            this.GVReporte.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.GVReporte.HeaderForeColor = System.Drawing.Color.White;
            this.GVReporte.Location = new System.Drawing.Point(29, 143);
            this.GVReporte.Name = "GVReporte";
            this.GVReporte.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GVReporte.RowHeadersVisible = false;
            this.GVReporte.Size = new System.Drawing.Size(824, 333);
            this.GVReporte.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(520, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Hasta el:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(305, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Desde el:";
            // 
            // rbCategoria
            // 
            this.rbCategoria.AutoSize = true;
            this.rbCategoria.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.rbCategoria.ForeColor = System.Drawing.Color.White;
            this.rbCategoria.Location = new System.Drawing.Point(6, 16);
            this.rbCategoria.Name = "rbCategoria";
            this.rbCategoria.Size = new System.Drawing.Size(162, 24);
            this.rbCategoria.TabIndex = 38;
            this.rbCategoria.TabStop = true;
            this.rbCategoria.Tag = "CategoriaReport";
            this.rbCategoria.Text = "Categoria de libros";
            this.rbCategoria.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbAutor);
            this.groupBox1.Controls.Add(this.rbCategoria);
            this.groupBox1.Controls.Add(this.rbBitacora);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 69);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Solicitar reporte por";
            // 
            // rbAutor
            // 
            this.rbAutor.AutoSize = true;
            this.rbAutor.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.rbAutor.ForeColor = System.Drawing.Color.White;
            this.rbAutor.Location = new System.Drawing.Point(6, 40);
            this.rbAutor.Name = "rbAutor";
            this.rbAutor.Size = new System.Drawing.Size(138, 24);
            this.rbAutor.TabIndex = 38;
            this.rbAutor.TabStop = true;
            this.rbAutor.Tag = "AutorReport";
            this.rbAutor.Text = "Libro por Autor";
            this.rbAutor.UseVisualStyleBackColor = true;
            // 
            // rbBitacora
            // 
            this.rbBitacora.AutoSize = true;
            this.rbBitacora.Font = new System.Drawing.Font("Ubuntu", 11F);
            this.rbBitacora.ForeColor = System.Drawing.Color.White;
            this.rbBitacora.Location = new System.Drawing.Point(178, 40);
            this.rbBitacora.Name = "rbBitacora";
            this.rbBitacora.Size = new System.Drawing.Size(101, 23);
            this.rbBitacora.TabIndex = 38;
            this.rbBitacora.TabStop = true;
            this.rbBitacora.Tag = "BitacoraReport";
            this.rbBitacora.Text = "Actividad...";
            this.rbBitacora.UseVisualStyleBackColor = true;
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(28)))), ((int)(((byte)(35)))));
            this.toolTip1.ForeColor = System.Drawing.Color.White;
            this.toolTip1.IsBalloon = true;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(52)))), ((int)(((byte)(0)))));
            this.btnGenerar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(28)))), ((int)(((byte)(35)))));
            this.btnGenerar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGenerar.BorderRadius = 5;
            this.btnGenerar.ButtonText = "     Generar";
            this.btnGenerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerar.DisabledColor = System.Drawing.Color.Gray;
            this.btnGenerar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGenerar.Iconimage = global::Presentacion.Properties.Resources.Accounting_50px;
            this.btnGenerar.Iconimage_right = null;
            this.btnGenerar.Iconimage_right_Selected = null;
            this.btnGenerar.Iconimage_Selected = null;
            this.btnGenerar.IconMarginLeft = 0;
            this.btnGenerar.IconMarginRight = 0;
            this.btnGenerar.IconRightVisible = true;
            this.btnGenerar.IconRightZoom = 0D;
            this.btnGenerar.IconVisible = true;
            this.btnGenerar.IconZoom = 50D;
            this.btnGenerar.IsTab = false;
            this.btnGenerar.Location = new System.Drawing.Point(733, 85);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(28)))), ((int)(((byte)(35)))));
            this.btnGenerar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(52)))), ((int)(((byte)(0)))));
            this.btnGenerar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGenerar.selected = false;
            this.btnGenerar.Size = new System.Drawing.Size(120, 40);
            this.btnGenerar.TabIndex = 36;
            this.btnGenerar.TabStop = false;
            this.btnGenerar.Text = "     Generar";
            this.btnGenerar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerar.Textcolor = System.Drawing.Color.White;
            this.btnGenerar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(52)))), ((int)(((byte)(0)))));
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.toolTip1.SetToolTip(this.btnExcel, "Exportar reporte a Excel");
            this.btnExcel.Visible = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // FrmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(880, 579);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.GVReporte);
            this.Controls.Add(this.dpFechafin);
            this.Controls.Add(this.dpFechaini);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReporte";
            this.Load += new System.EventHandler(this.FrmReporte_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVReporte)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuCards pnlHeader;
        private System.Windows.Forms.Label label1;
        private ns1.BunifuDatepicker dpFechaini;
        private ns1.BunifuDatepicker dpFechafin;
        private ns1.BunifuCustomDataGrid GVReporte;
        private ns1.BunifuFlatButton btnGenerar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbCategoria;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbAutor;
        private System.Windows.Forms.RadioButton rbBitacora;
        private System.Windows.Forms.ToolTip toolTip1;
        private ns1.BunifuFlatButton btnExcel;
        private ns1.BunifuProgressBar progressbar;
    }
}