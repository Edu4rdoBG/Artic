namespace Presentacion
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.pnlheader = new System.Windows.Forms.Panel();
            this.bunifuImageButton3 = new ns1.BunifuImageButton();
            this.btncerrar = new ns1.BunifuImageButton();
            this.pnltools = new System.Windows.Forms.Panel();
            this.bunifuCards1 = new ns1.BunifuCards();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.bunifuImageButton1 = new ns1.BunifuImageButton();
            this.btnLogout = new ns1.BunifuTileButton();
            this.bunifuTileButton2 = new ns1.BunifuTileButton();
            this.btnAdmin = new ns1.BunifuTileButton();
            this.bunifuGradientPanel1 = new ns1.BunifuGradientPanel();
            this.btnsystem = new ns1.BunifuFlatButton();
            this.bunifuFlatButton5 = new ns1.BunifuFlatButton();
            this.btnMiembros = new ns1.BunifuFlatButton();
            this.btnLibros = new ns1.BunifuFlatButton();
            this.btnInventario = new ns1.BunifuFlatButton();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.dchead = new ns1.BunifuDragControl(this.components);
            this.btnMax = new ns1.BunifuImageButton();
            this.pnlheader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            this.pnltools.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnlheader
            // 
            this.pnlheader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(52)))), ((int)(((byte)(0)))));
            this.pnlheader.Controls.Add(this.bunifuImageButton3);
            this.pnlheader.Controls.Add(this.btnMax);
            this.pnlheader.Controls.Add(this.btncerrar);
            this.pnlheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlheader.Location = new System.Drawing.Point(0, 0);
            this.pnlheader.Name = "pnlheader";
            this.pnlheader.Size = new System.Drawing.Size(1080, 40);
            this.pnlheader.TabIndex = 0;
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton3.Image = global::Presentacion.Properties.Resources.Menu_50px;
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(9, 7);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(35, 26);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 5;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            // 
            // btncerrar
            // 
            this.btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncerrar.BackColor = System.Drawing.Color.Transparent;
            this.btncerrar.Image = global::Presentacion.Properties.Resources.Multiply_50px;
            this.btncerrar.ImageActive = null;
            this.btncerrar.Location = new System.Drawing.Point(1034, 3);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(35, 35);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btncerrar.TabIndex = 4;
            this.btncerrar.TabStop = false;
            this.btncerrar.Zoom = 10;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // pnltools
            // 
            this.pnltools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.pnltools.Controls.Add(this.bunifuCards1);
            this.pnltools.Controls.Add(this.btnsystem);
            this.pnltools.Controls.Add(this.bunifuFlatButton5);
            this.pnltools.Controls.Add(this.btnMiembros);
            this.pnltools.Controls.Add(this.btnLibros);
            this.pnltools.Controls.Add(this.btnInventario);
            this.pnltools.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnltools.Location = new System.Drawing.Point(0, 40);
            this.pnltools.Name = "pnltools";
            this.pnltools.Size = new System.Drawing.Size(200, 579);
            this.pnltools.TabIndex = 1;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(28)))), ((int)(((byte)(35)))));
            this.bunifuCards1.BorderRadius = 0;
            this.bunifuCards1.BottomSahddow = false;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(28)))), ((int)(((byte)(35)))));
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuCards1.Controls.Add(this.bunifuImageButton1);
            this.bunifuCards1.Controls.Add(this.btnLogout);
            this.bunifuCards1.Controls.Add(this.bunifuTileButton2);
            this.bunifuCards1.Controls.Add(this.btnAdmin);
            this.bunifuCards1.Controls.Add(this.bunifuGradientPanel1);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 436);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = false;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(200, 143);
            this.bunifuCards1.TabIndex = 1;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Ubuntu", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(7, 114);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(98, 19);
            this.bunifuCustomLabel1.TabIndex = 4;
            this.bunifuCustomLabel1.Text = "Usuario: root";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::Presentacion.Properties.Resources.Login_As_User_50px;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(12, 77);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(35, 35);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 3;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(28)))), ((int)(((byte)(35)))));
            this.btnLogout.color = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(28)))), ((int)(((byte)(35)))));
            this.btnLogout.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(52)))), ((int)(((byte)(0)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Font = new System.Drawing.Font("Ubuntu Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::Presentacion.Properties.Resources.Logout_Rounded_Down_50px;
            this.btnLogout.ImagePosition = 5;
            this.btnLogout.ImageZoom = 40;
            this.btnLogout.LabelPosition = 27;
            this.btnLogout.LabelText = "Log out";
            this.btnLogout.Location = new System.Drawing.Point(137, 13);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(62, 62);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // bunifuTileButton2
            // 
            this.bunifuTileButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(28)))), ((int)(((byte)(35)))));
            this.bunifuTileButton2.color = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(28)))), ((int)(((byte)(35)))));
            this.bunifuTileButton2.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(52)))), ((int)(((byte)(0)))));
            this.bunifuTileButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton2.Font = new System.Drawing.Font("Ubuntu Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTileButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton2.Image = global::Presentacion.Properties.Resources.Change_Theme_50px;
            this.bunifuTileButton2.ImagePosition = 5;
            this.bunifuTileButton2.ImageZoom = 40;
            this.bunifuTileButton2.LabelPosition = 27;
            this.bunifuTileButton2.LabelText = "Tema";
            this.bunifuTileButton2.Location = new System.Drawing.Point(70, 13);
            this.bunifuTileButton2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuTileButton2.Name = "bunifuTileButton2";
            this.bunifuTileButton2.Size = new System.Drawing.Size(62, 62);
            this.bunifuTileButton2.TabIndex = 2;
            this.bunifuTileButton2.Click += new System.EventHandler(this.bunifuTileButton2_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(28)))), ((int)(((byte)(35)))));
            this.btnAdmin.color = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(28)))), ((int)(((byte)(35)))));
            this.btnAdmin.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(52)))), ((int)(((byte)(0)))));
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.Font = new System.Drawing.Font("Ubuntu Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.Image = global::Presentacion.Properties.Resources.Administrative_Tools_50px;
            this.btnAdmin.ImagePosition = 5;
            this.btnAdmin.ImageZoom = 40;
            this.btnAdmin.LabelPosition = 27;
            this.btnAdmin.LabelText = "Admin...";
            this.btnAdmin.Location = new System.Drawing.Point(3, 13);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(62, 62);
            this.btnAdmin.TabIndex = 2;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(52)))), ((int)(((byte)(0)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(36)))), ((int)(((byte)(149)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(52)))), ((int)(((byte)(0)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(1, 3);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(201, 3);
            this.bunifuGradientPanel1.TabIndex = 1;
            // 
            // btnsystem
            // 
            this.btnsystem.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(52)))), ((int)(((byte)(0)))));
            this.btnsystem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnsystem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsystem.BorderRadius = 0;
            this.btnsystem.ButtonText = "     System";
            this.btnsystem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsystem.DisabledColor = System.Drawing.Color.Gray;
            this.btnsystem.Iconcolor = System.Drawing.Color.Transparent;
            this.btnsystem.Iconimage = global::Presentacion.Properties.Resources.Support_50px;
            this.btnsystem.Iconimage_right = null;
            this.btnsystem.Iconimage_right_Selected = null;
            this.btnsystem.Iconimage_Selected = null;
            this.btnsystem.IconMarginLeft = 0;
            this.btnsystem.IconMarginRight = 0;
            this.btnsystem.IconRightVisible = true;
            this.btnsystem.IconRightZoom = 0D;
            this.btnsystem.IconVisible = true;
            this.btnsystem.IconZoom = 70D;
            this.btnsystem.IsTab = true;
            this.btnsystem.Location = new System.Drawing.Point(0, 188);
            this.btnsystem.Name = "btnsystem";
            this.btnsystem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnsystem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(52)))), ((int)(((byte)(0)))));
            this.btnsystem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnsystem.selected = false;
            this.btnsystem.Size = new System.Drawing.Size(201, 48);
            this.btnsystem.TabIndex = 0;
            this.btnsystem.TabStop = false;
            this.btnsystem.Text = "     System";
            this.btnsystem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsystem.Textcolor = System.Drawing.Color.White;
            this.btnsystem.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsystem.Click += new System.EventHandler(this.btnsystem_Click);
            // 
            // bunifuFlatButton5
            // 
            this.bunifuFlatButton5.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(52)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.bunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton5.BorderRadius = 0;
            this.bunifuFlatButton5.ButtonText = "     Reportes";
            this.bunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.Iconimage = global::Presentacion.Properties.Resources.Combo_Chart_50px;
            this.bunifuFlatButton5.Iconimage_right = null;
            this.bunifuFlatButton5.Iconimage_right_Selected = null;
            this.bunifuFlatButton5.Iconimage_Selected = null;
            this.bunifuFlatButton5.IconMarginLeft = 0;
            this.bunifuFlatButton5.IconMarginRight = 0;
            this.bunifuFlatButton5.IconRightVisible = true;
            this.bunifuFlatButton5.IconRightZoom = 0D;
            this.bunifuFlatButton5.IconVisible = true;
            this.bunifuFlatButton5.IconZoom = 70D;
            this.bunifuFlatButton5.IsTab = true;
            this.bunifuFlatButton5.Location = new System.Drawing.Point(0, 141);
            this.bunifuFlatButton5.Name = "bunifuFlatButton5";
            this.bunifuFlatButton5.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.bunifuFlatButton5.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(52)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton5.selected = false;
            this.bunifuFlatButton5.Size = new System.Drawing.Size(201, 48);
            this.bunifuFlatButton5.TabIndex = 0;
            this.bunifuFlatButton5.TabStop = false;
            this.bunifuFlatButton5.Text = "     Reportes";
            this.bunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton5.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton5.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton5.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnMiembros
            // 
            this.btnMiembros.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(52)))), ((int)(((byte)(0)))));
            this.btnMiembros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnMiembros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMiembros.BorderRadius = 0;
            this.btnMiembros.ButtonText = "     Miembros";
            this.btnMiembros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMiembros.DisabledColor = System.Drawing.Color.Gray;
            this.btnMiembros.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMiembros.Iconimage = global::Presentacion.Properties.Resources.Conference_Call_50px;
            this.btnMiembros.Iconimage_right = null;
            this.btnMiembros.Iconimage_right_Selected = null;
            this.btnMiembros.Iconimage_Selected = null;
            this.btnMiembros.IconMarginLeft = 0;
            this.btnMiembros.IconMarginRight = 0;
            this.btnMiembros.IconRightVisible = true;
            this.btnMiembros.IconRightZoom = 0D;
            this.btnMiembros.IconVisible = true;
            this.btnMiembros.IconZoom = 70D;
            this.btnMiembros.IsTab = true;
            this.btnMiembros.Location = new System.Drawing.Point(0, 94);
            this.btnMiembros.Name = "btnMiembros";
            this.btnMiembros.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnMiembros.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(52)))), ((int)(((byte)(0)))));
            this.btnMiembros.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMiembros.selected = false;
            this.btnMiembros.Size = new System.Drawing.Size(201, 48);
            this.btnMiembros.TabIndex = 0;
            this.btnMiembros.TabStop = false;
            this.btnMiembros.Text = "     Miembros";
            this.btnMiembros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMiembros.Textcolor = System.Drawing.Color.White;
            this.btnMiembros.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMiembros.Click += new System.EventHandler(this.btnMiembros_Click);
            // 
            // btnLibros
            // 
            this.btnLibros.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(52)))), ((int)(((byte)(0)))));
            this.btnLibros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnLibros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLibros.BorderRadius = 0;
            this.btnLibros.ButtonText = "     Calificadores";
            this.btnLibros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLibros.DisabledColor = System.Drawing.Color.Gray;
            this.btnLibros.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLibros.Iconimage = global::Presentacion.Properties.Resources.Categorize_50px;
            this.btnLibros.Iconimage_right = null;
            this.btnLibros.Iconimage_right_Selected = null;
            this.btnLibros.Iconimage_Selected = null;
            this.btnLibros.IconMarginLeft = 0;
            this.btnLibros.IconMarginRight = 0;
            this.btnLibros.IconRightVisible = true;
            this.btnLibros.IconRightZoom = 0D;
            this.btnLibros.IconVisible = true;
            this.btnLibros.IconZoom = 70D;
            this.btnLibros.IsTab = true;
            this.btnLibros.Location = new System.Drawing.Point(0, 47);
            this.btnLibros.Name = "btnLibros";
            this.btnLibros.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnLibros.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(52)))), ((int)(((byte)(0)))));
            this.btnLibros.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLibros.selected = false;
            this.btnLibros.Size = new System.Drawing.Size(201, 48);
            this.btnLibros.TabIndex = 0;
            this.btnLibros.TabStop = false;
            this.btnLibros.Text = "     Calificadores";
            this.btnLibros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLibros.Textcolor = System.Drawing.Color.White;
            this.btnLibros.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibros.Click += new System.EventHandler(this.btnLibros_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(52)))), ((int)(((byte)(0)))));
            this.btnInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInventario.BorderRadius = 0;
            this.btnInventario.ButtonText = "     Inventario";
            this.btnInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventario.DisabledColor = System.Drawing.Color.Gray;
            this.btnInventario.Iconcolor = System.Drawing.Color.Transparent;
            this.btnInventario.Iconimage = global::Presentacion.Properties.Resources.Book_Shelf_50px;
            this.btnInventario.Iconimage_right = null;
            this.btnInventario.Iconimage_right_Selected = null;
            this.btnInventario.Iconimage_Selected = null;
            this.btnInventario.IconMarginLeft = 0;
            this.btnInventario.IconMarginRight = 0;
            this.btnInventario.IconRightVisible = true;
            this.btnInventario.IconRightZoom = 0D;
            this.btnInventario.IconVisible = true;
            this.btnInventario.IconZoom = 70D;
            this.btnInventario.IsTab = true;
            this.btnInventario.Location = new System.Drawing.Point(0, 0);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnInventario.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(52)))), ((int)(((byte)(0)))));
            this.btnInventario.OnHoverTextColor = System.Drawing.Color.White;
            this.btnInventario.selected = false;
            this.btnInventario.Size = new System.Drawing.Size(201, 48);
            this.btnInventario.TabIndex = 0;
            this.btnInventario.TabStop = false;
            this.btnInventario.Text = "     Inventario";
            this.btnInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.Textcolor = System.Drawing.Color.White;
            this.btnInventario.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(200, 40);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(880, 579);
            this.panelContenedor.TabIndex = 2;
            // 
            // dchead
            // 
            this.dchead.Fixed = true;
            this.dchead.Horizontal = true;
            this.dchead.TargetControl = this.pnlheader;
            this.dchead.Vertical = true;
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.BackColor = System.Drawing.Color.Transparent;
            this.btnMax.Image = global::Presentacion.Properties.Resources.maximize2;
            this.btnMax.ImageActive = null;
            this.btnMax.Location = new System.Drawing.Point(993, 3);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(35, 35);
            this.btnMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMax.TabIndex = 4;
            this.btnMax.TabStop = false;
            this.btnMax.Zoom = 10;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 619);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.pnltools);
            this.Controls.Add(this.pnlheader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.pnlheader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            this.pnltools.ResumeLayout(false);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel pnltools;
        private System.Windows.Forms.Panel pnlheader;
        private ns1.BunifuFlatButton btnsystem;
        private ns1.BunifuFlatButton bunifuFlatButton5;
        private ns1.BunifuFlatButton btnMiembros;
        private ns1.BunifuFlatButton btnLibros;
        private ns1.BunifuFlatButton btnInventario;
        private ns1.BunifuCards bunifuCards1;
        private ns1.BunifuGradientPanel bunifuGradientPanel1;
        private ns1.BunifuDragControl dchead;
        private ns1.BunifuTileButton bunifuTileButton2;
        private ns1.BunifuTileButton btnAdmin;
        private ns1.BunifuTileButton btnLogout;
        private ns1.BunifuImageButton bunifuImageButton1;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private ns1.BunifuImageButton btncerrar;
        private ns1.BunifuImageButton bunifuImageButton3;
        private ns1.BunifuImageButton btnMax;
    }
}