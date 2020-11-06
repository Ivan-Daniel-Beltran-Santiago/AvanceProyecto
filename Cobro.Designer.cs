namespace AvanceProyecto
{
    partial class Cobro
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
            this.pTitleBar = new System.Windows.Forms.Panel();
            this.pbxMaximize = new System.Windows.Forms.PictureBox();
            this.pbxMinimize = new System.Windows.Forms.PictureBox();
            this.pbxRestore = new System.Windows.Forms.PictureBox();
            this.pbxClose = new System.Windows.Forms.PictureBox();
            this.pVertMenu = new System.Windows.Forms.Panel();
            this.pbxExit = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnBuy = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnInventory = new System.Windows.Forms.Button();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.pContainer = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRestore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClose)).BeginInit();
            this.pVertMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.pContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pTitleBar
            // 
            this.pTitleBar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pTitleBar.Controls.Add(this.pbxMaximize);
            this.pTitleBar.Controls.Add(this.pbxMinimize);
            this.pTitleBar.Controls.Add(this.pbxRestore);
            this.pTitleBar.Controls.Add(this.pbxClose);
            this.pTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pTitleBar.Name = "pTitleBar";
            this.pTitleBar.Size = new System.Drawing.Size(1024, 44);
            this.pTitleBar.TabIndex = 1;
            this.pTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pTitleBar_MouseDown);
            // 
            // pbxMaximize
            // 
            this.pbxMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxMaximize.Image = global::AvanceProyecto.Properties.Resources.maximize_window;
            this.pbxMaximize.Location = new System.Drawing.Point(934, 4);
            this.pbxMaximize.Name = "pbxMaximize";
            this.pbxMaximize.Size = new System.Drawing.Size(36, 36);
            this.pbxMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMaximize.TabIndex = 5;
            this.pbxMaximize.TabStop = false;
            this.pbxMaximize.Click += new System.EventHandler(this.pbxMaximize_Click);
            // 
            // pbxMinimize
            // 
            this.pbxMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxMinimize.Image = global::AvanceProyecto.Properties.Resources.kisspng_computer_icons_window_free_files_minimize_5ab137710e9725_5982463615215635050598;
            this.pbxMinimize.Location = new System.Drawing.Point(892, 3);
            this.pbxMinimize.Name = "pbxMinimize";
            this.pbxMinimize.Size = new System.Drawing.Size(36, 36);
            this.pbxMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMinimize.TabIndex = 4;
            this.pbxMinimize.TabStop = false;
            this.pbxMinimize.Click += new System.EventHandler(this.pbxMinimize_Click);
            // 
            // pbxRestore
            // 
            this.pbxRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxRestore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxRestore.Image = global::AvanceProyecto.Properties.Resources.restore_window;
            this.pbxRestore.Location = new System.Drawing.Point(934, 3);
            this.pbxRestore.Name = "pbxRestore";
            this.pbxRestore.Size = new System.Drawing.Size(36, 36);
            this.pbxRestore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxRestore.TabIndex = 3;
            this.pbxRestore.TabStop = false;
            this.pbxRestore.Visible = false;
            this.pbxRestore.Click += new System.EventHandler(this.pbxRestore_Click);
            // 
            // pbxClose
            // 
            this.pbxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxClose.Image = global::AvanceProyecto.Properties.Resources.images__1_;
            this.pbxClose.Location = new System.Drawing.Point(976, 4);
            this.pbxClose.Name = "pbxClose";
            this.pbxClose.Size = new System.Drawing.Size(36, 36);
            this.pbxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxClose.TabIndex = 0;
            this.pbxClose.TabStop = false;
            this.pbxClose.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pVertMenu
            // 
            this.pVertMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pVertMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pVertMenu.Controls.Add(this.pbxExit);
            this.pVertMenu.Controls.Add(this.panel4);
            this.pVertMenu.Controls.Add(this.btnBuy);
            this.pVertMenu.Controls.Add(this.panel2);
            this.pVertMenu.Controls.Add(this.btnInventory);
            this.pVertMenu.Controls.Add(this.pbxLogo);
            this.pVertMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pVertMenu.Location = new System.Drawing.Point(0, 44);
            this.pVertMenu.Name = "pVertMenu";
            this.pVertMenu.Size = new System.Drawing.Size(240, 724);
            this.pVertMenu.TabIndex = 2;
            // 
            // pbxExit
            // 
            this.pbxExit.Image = global::AvanceProyecto.Properties.Resources._25706;
            this.pbxExit.Location = new System.Drawing.Point(10, 656);
            this.pbxExit.Name = "pbxExit";
            this.pbxExit.Size = new System.Drawing.Size(56, 56);
            this.pbxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxExit.TabIndex = 11;
            this.pbxExit.TabStop = false;
            this.pbxExit.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MediumBlue;
            this.panel4.Location = new System.Drawing.Point(0, 246);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 48);
            this.panel4.TabIndex = 6;
            // 
            // btnBuy
            // 
            this.btnBuy.FlatAppearance.BorderSize = 0;
            this.btnBuy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuy.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBuy.ForeColor = System.Drawing.Color.White;
            this.btnBuy.Image = global::AvanceProyecto.Properties.Resources._1078311;
            this.btnBuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuy.Location = new System.Drawing.Point(10, 246);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(230, 48);
            this.btnBuy.TabIndex = 5;
            this.btnBuy.Text = "Compras";
            this.btnBuy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumBlue;
            this.panel2.Location = new System.Drawing.Point(0, 300);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 48);
            this.panel2.TabIndex = 4;
            // 
            // btnInventory
            // 
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnInventory.ForeColor = System.Drawing.Color.White;
            this.btnInventory.Image = global::AvanceProyecto.Properties.Resources.box_cash;
            this.btnInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.Location = new System.Drawing.Point(10, 300);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(230, 48);
            this.btnInventory.TabIndex = 3;
            this.btnInventory.Text = "Inventario";
            this.btnInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::AvanceProyecto.Properties.Resources.plantilla_logotipo_tema_tienda_videojuegos_1056_347;
            this.pbxLogo.Location = new System.Drawing.Point(0, 0);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(240, 240);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 0;
            this.pbxLogo.TabStop = false;
            this.pbxLogo.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pContainer
            // 
            this.pContainer.BackColor = System.Drawing.SystemColors.ControlText;
            this.pContainer.Controls.Add(this.pictureBox3);
            this.pContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContainer.Location = new System.Drawing.Point(240, 44);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(784, 724);
            this.pContainer.TabIndex = 3;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = global::AvanceProyecto.Properties.Resources.plantilla_logotipo_tema_tienda_videojuegos_1056_347;
            this.pictureBox3.Location = new System.Drawing.Point(207, 153);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(400, 400);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // Cobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.pContainer);
            this.Controls.Add(this.pVertMenu);
            this.Controls.Add(this.pTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "Cobro";
            this.Text = "Cobro";
            this.pTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRestore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClose)).EndInit();
            this.pVertMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.pContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pTitleBar;
        private System.Windows.Forms.Panel pVertMenu;
        private System.Windows.Forms.PictureBox pbxClose;
        private System.Windows.Forms.PictureBox pbxRestore;
        private System.Windows.Forms.PictureBox pbxMinimize;
        private System.Windows.Forms.PictureBox pbxMaximize;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.PictureBox pbxExit;
        private System.Windows.Forms.Panel pContainer;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}