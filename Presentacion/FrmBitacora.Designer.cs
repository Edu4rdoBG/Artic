namespace Presentacion
{
    partial class FrmBitacora
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
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.pnlHeader = new ns1.BunifuCards();
            this.label1 = new System.Windows.Forms.Label();
            this.btncerrar = new ns1.BunifuImageButton();
            this.GVBitacora = new ns1.BunifuCustomDataGrid();
            this.DragC = new ns1.BunifuDragControl(this.components);
            this.dpFecha = new ns1.BunifuDatepicker();
            this.btnFiltrar = new ns1.BunifuFlatButton();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.cbAccion = new ns1.BunifuCheckbox();
            this.cbForm = new ns1.BunifuCheckbox();
            this.cbFecha = new ns1.BunifuCheckbox();
            this.cbUsuario = new ns1.BunifuCheckbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAccion = new ns1.BunifuMetroTextbox();
            this.txtFormulario = new ns1.BunifuMetroTextbox();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVBitacora)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(28)))), ((int)(((byte)(35)))));
            this.pnlHeader.BorderRadius = 0;
            this.pnlHeader.BottomSahddow = true;
            this.pnlHeader.color = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(28)))), ((int)(((byte)(35)))));
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Controls.Add(this.btncerrar);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.LeftSahddow = false;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.RightSahddow = false;
            this.pnlHeader.ShadowDepth = 20;
            this.pnlHeader.Size = new System.Drawing.Size(1105, 40);
            this.pnlHeader.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Bitacora de usuarios";
            // 
            // btncerrar
            // 
            this.btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btncerrar.BackColor = System.Drawing.Color.Transparent;
            this.btncerrar.Image = global::Presentacion.Properties.Resources.Multiply_50px;
            this.btncerrar.ImageActive = null;
            this.btncerrar.Location = new System.Drawing.Point(1068, 5);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(30, 30);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btncerrar.TabIndex = 5;
            this.btncerrar.TabStop = false;
            this.btncerrar.Zoom = 10;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // GVBitacora
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            this.GVBitacora.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GVBitacora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
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
            this.GVBitacora.Location = new System.Drawing.Point(12, 138);
            this.GVBitacora.Name = "GVBitacora";
            this.GVBitacora.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GVBitacora.RowHeadersVisible = false;
            this.GVBitacora.Size = new System.Drawing.Size(1081, 363);
            this.GVBitacora.TabIndex = 31;
            // 
            // DragC
            // 
            this.DragC.Fixed = true;
            this.DragC.Horizontal = true;
            this.DragC.TargetControl = this.pnlHeader;
            this.DragC.Vertical = true;
            // 
            // dpFecha
            // 
            this.dpFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.dpFecha.BorderRadius = 0;
            this.dpFecha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dpFecha.Enabled = false;
            this.dpFecha.ForeColor = System.Drawing.Color.White;
            this.dpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpFecha.FormatCustom = null;
            this.dpFecha.Location = new System.Drawing.Point(465, 84);
            this.dpFecha.Name = "dpFecha";
            this.dpFecha.Size = new System.Drawing.Size(308, 36);
            this.dpFecha.TabIndex = 32;
            this.dpFecha.Tag = "Fecha";
            this.dpFecha.Value = new System.DateTime(2018, 8, 15, 0, 0, 0, 0);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(52)))), ((int)(((byte)(0)))));
            this.btnFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnFiltrar.Location = new System.Drawing.Point(973, 80);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(28)))), ((int)(((byte)(35)))));
            this.btnFiltrar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(52)))), ((int)(((byte)(0)))));
            this.btnFiltrar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnFiltrar.selected = false;
            this.btnFiltrar.Size = new System.Drawing.Size(120, 40);
            this.btnFiltrar.TabIndex = 33;
            this.btnFiltrar.TabStop = false;
            this.btnFiltrar.Text = "     Filtrar";
            this.btnFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltrar.Textcolor = System.Drawing.Color.White;
            this.btnFiltrar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(28)))), ((int)(((byte)(35)))));
            this.cmbUsuario.Enabled = false;
            this.cmbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUsuario.ForeColor = System.Drawing.Color.White;
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(785, 85);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(175, 32);
            this.cmbUsuario.TabIndex = 34;
            // 
            // cbAccion
            // 
            this.cbAccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cbAccion.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cbAccion.Checked = false;
            this.cbAccion.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(116)))), ((int)(((byte)(245)))));
            this.cbAccion.ForeColor = System.Drawing.Color.White;
            this.cbAccion.Location = new System.Drawing.Point(32, 57);
            this.cbAccion.Name = "cbAccion";
            this.cbAccion.Size = new System.Drawing.Size(20, 20);
            this.cbAccion.TabIndex = 35;
            this.cbAccion.Tag = "Accion";
            this.cbAccion.OnChange += new System.EventHandler(this.cbAccion_OnChange);
            // 
            // cbForm
            // 
            this.cbForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cbForm.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cbForm.Checked = false;
            this.cbForm.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(116)))), ((int)(((byte)(245)))));
            this.cbForm.ForeColor = System.Drawing.Color.White;
            this.cbForm.Location = new System.Drawing.Point(255, 57);
            this.cbForm.Name = "cbForm";
            this.cbForm.Size = new System.Drawing.Size(20, 20);
            this.cbForm.TabIndex = 35;
            this.cbForm.Tag = "Form";
            this.cbForm.OnChange += new System.EventHandler(this.cbForm_OnChange);
            // 
            // cbFecha
            // 
            this.cbFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cbFecha.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cbFecha.Checked = false;
            this.cbFecha.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(116)))), ((int)(((byte)(245)))));
            this.cbFecha.ForeColor = System.Drawing.Color.White;
            this.cbFecha.Location = new System.Drawing.Point(481, 57);
            this.cbFecha.Name = "cbFecha";
            this.cbFecha.Size = new System.Drawing.Size(20, 20);
            this.cbFecha.TabIndex = 35;
            this.cbFecha.Tag = "Fecha";
            this.cbFecha.OnChange += new System.EventHandler(this.cbFecha_OnChange);
            // 
            // cbUsuario
            // 
            this.cbUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cbUsuario.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cbUsuario.Checked = false;
            this.cbUsuario.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(116)))), ((int)(((byte)(245)))));
            this.cbUsuario.ForeColor = System.Drawing.Color.White;
            this.cbUsuario.Location = new System.Drawing.Point(794, 57);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(20, 20);
            this.cbUsuario.TabIndex = 35;
            this.cbUsuario.Tag = "Usuario";
            this.cbUsuario.OnChange += new System.EventHandler(this.cbUsuario_OnChange);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(58, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Accion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(281, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Formulario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(507, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fecha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(820, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Usuario";
            // 
            // txtAccion
            // 
            this.txtAccion.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(116)))), ((int)(((byte)(245)))));
            this.txtAccion.BorderColorIdle = System.Drawing.Color.White;
            this.txtAccion.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(116)))), ((int)(((byte)(245)))));
            this.txtAccion.BorderThickness = 3;
            this.txtAccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccion.Enabled = false;
            this.txtAccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F);
            this.txtAccion.ForeColor = System.Drawing.Color.White;
            this.txtAccion.isPassword = false;
            this.txtAccion.Location = new System.Drawing.Point(17, 84);
            this.txtAccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtAccion.Name = "txtAccion";
            this.txtAccion.Size = new System.Drawing.Size(207, 36);
            this.txtAccion.TabIndex = 36;
            this.txtAccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtFormulario
            // 
            this.txtFormulario.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(116)))), ((int)(((byte)(245)))));
            this.txtFormulario.BorderColorIdle = System.Drawing.Color.White;
            this.txtFormulario.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(116)))), ((int)(((byte)(245)))));
            this.txtFormulario.BorderThickness = 3;
            this.txtFormulario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFormulario.Enabled = false;
            this.txtFormulario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F);
            this.txtFormulario.ForeColor = System.Drawing.Color.White;
            this.txtFormulario.isPassword = false;
            this.txtFormulario.Location = new System.Drawing.Point(244, 84);
            this.txtFormulario.Margin = new System.Windows.Forms.Padding(4);
            this.txtFormulario.Name = "txtFormulario";
            this.txtFormulario.Size = new System.Drawing.Size(208, 36);
            this.txtFormulario.TabIndex = 36;
            this.txtFormulario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // FrmBitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1105, 513);
            this.Controls.Add(this.txtFormulario);
            this.Controls.Add(this.txtAccion);
            this.Controls.Add(this.cbUsuario);
            this.Controls.Add(this.cbFecha);
            this.Controls.Add(this.cbForm);
            this.Controls.Add(this.cbAccion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbUsuario);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.dpFecha);
            this.Controls.Add(this.GVBitacora);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBitacora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBitacora";
            this.Load += new System.EventHandler(this.FrmBitacora_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVBitacora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuElipse bunifuElipse1;
        private ns1.BunifuCards pnlHeader;
        private ns1.BunifuImageButton btncerrar;
        private System.Windows.Forms.Label label1;
        private ns1.BunifuCustomDataGrid GVBitacora;
        private ns1.BunifuDragControl DragC;
        private ns1.BunifuDatepicker dpFecha;
        private ns1.BunifuFlatButton btnFiltrar;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private ns1.BunifuCheckbox cbUsuario;
        private ns1.BunifuCheckbox cbFecha;
        private ns1.BunifuCheckbox cbForm;
        private ns1.BunifuCheckbox cbAccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private ns1.BunifuMetroTextbox txtAccion;
        private ns1.BunifuMetroTextbox txtFormulario;
    }
}