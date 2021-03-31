
namespace Presentation.Forms.New_Forms
{
    partial class NewProduct
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
            this.upBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.btnExit = new FontAwesome.Sharp.IconPictureBox();
            this.btnMin = new FontAwesome.Sharp.IconPictureBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtIdPro = new System.Windows.Forms.TextBox();
            this.lbl5 = new System.Windows.Forms.Label();
            this.txtCodPro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtMayPro = new System.Windows.Forms.TextBox();
            this.txtNamePro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMenPro = new System.Windows.Forms.TextBox();
            this.txtStockPro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbPrice = new System.Windows.Forms.GroupBox();
            this.BtnexitProduct = new FontAwesome.Sharp.IconButton();
            this.BtnsaveProduct = new FontAwesome.Sharp.IconButton();
            this.upBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            this.gbPrice.SuspendLayout();
            this.SuspendLayout();
            // 
            // upBar
            // 
            this.upBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.upBar.Controls.Add(this.label1);
            this.upBar.Controls.Add(this.iconPictureBox1);
            this.upBar.Controls.Add(this.btnExit);
            this.upBar.Controls.Add(this.btnMin);
            this.upBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.upBar.Location = new System.Drawing.Point(0, 0);
            this.upBar.Name = "upBar";
            this.upBar.Size = new System.Drawing.Size(360, 46);
            this.upBar.TabIndex = 33;
            this.upBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpBar_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(153, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "Producto";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpBar_MouseDown);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Boxes;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 37;
            this.iconPictureBox1.Location = new System.Drawing.Point(108, 7);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(37, 37);
            this.iconPictureBox1.TabIndex = 22;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpBar_MouseDown);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 23;
            this.btnExit.Location = new System.Drawing.Point(328, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(29, 23);
            this.btnExit.TabIndex = 19;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnMin.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMin.IconColor = System.Drawing.Color.White;
            this.btnMin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMin.IconSize = 23;
            this.btnMin.Location = new System.Drawing.Point(292, 3);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(29, 23);
            this.btnMin.TabIndex = 20;
            this.btnMin.TabStop = false;
            this.btnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(49, 331);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(40, 15);
            this.lblId.TabIndex = 31;
            this.lblId.Text = "IdUser";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblId.Visible = false;
            // 
            // txtIdPro
            // 
            this.txtIdPro.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPro.Location = new System.Drawing.Point(156, 323);
            this.txtIdPro.Name = "txtIdPro";
            this.txtIdPro.Size = new System.Drawing.Size(138, 23);
            this.txtIdPro.TabIndex = 32;
            this.txtIdPro.Visible = false;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(15, 78);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(45, 15);
            this.lbl5.TabIndex = 30;
            this.lbl5.Text = "Menor:";
            // 
            // txtCodPro
            // 
            this.txtCodPro.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodPro.Location = new System.Drawing.Point(130, 68);
            this.txtCodPro.Name = "txtCodPro";
            this.txtCodPro.Size = new System.Drawing.Size(176, 23);
            this.txtCodPro.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 29;
            this.label4.Text = "Mayor:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(40, 68);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 15);
            this.lblName.TabIndex = 27;
            this.lblName.Text = "Código:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMayPro
            // 
            this.txtMayPro.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMayPro.Location = new System.Drawing.Point(105, 26);
            this.txtMayPro.Name = "txtMayPro";
            this.txtMayPro.Size = new System.Drawing.Size(176, 23);
            this.txtMayPro.TabIndex = 27;
            // 
            // txtNamePro
            // 
            this.txtNamePro.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamePro.Location = new System.Drawing.Point(130, 118);
            this.txtNamePro.Name = "txtNamePro";
            this.txtNamePro.Size = new System.Drawing.Size(176, 23);
            this.txtNamePro.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = "Nombre:";
            // 
            // txtMenPro
            // 
            this.txtMenPro.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMenPro.Location = new System.Drawing.Point(105, 75);
            this.txtMenPro.Name = "txtMenPro";
            this.txtMenPro.Size = new System.Drawing.Size(176, 23);
            this.txtMenPro.TabIndex = 28;
            // 
            // txtStockPro
            // 
            this.txtStockPro.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockPro.Location = new System.Drawing.Point(132, 287);
            this.txtStockPro.Name = "txtStockPro";
            this.txtStockPro.Size = new System.Drawing.Size(176, 23);
            this.txtStockPro.TabIndex = 29;
            this.txtStockPro.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 37;
            this.label2.Text = "Cantidad:";
            // 
            // gbPrice
            // 
            this.gbPrice.Controls.Add(this.txtMenPro);
            this.gbPrice.Controls.Add(this.lbl5);
            this.gbPrice.Controls.Add(this.label4);
            this.gbPrice.Controls.Add(this.txtMayPro);
            this.gbPrice.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.gbPrice.Location = new System.Drawing.Point(25, 154);
            this.gbPrice.Name = "gbPrice";
            this.gbPrice.Size = new System.Drawing.Size(296, 115);
            this.gbPrice.TabIndex = 26;
            this.gbPrice.TabStop = false;
            this.gbPrice.Text = "Precio $";
            this.gbPrice.Paint += new System.Windows.Forms.PaintEventHandler(this.GbPrice_Paint);
            // 
            // BtnexitProduct
            // 
            this.BtnexitProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(146)))), ((int)(((byte)(190)))));
            this.BtnexitProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnexitProduct.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            this.BtnexitProduct.ForeColor = System.Drawing.Color.White;
            this.BtnexitProduct.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.BtnexitProduct.IconColor = System.Drawing.Color.White;
            this.BtnexitProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnexitProduct.IconSize = 22;
            this.BtnexitProduct.Location = new System.Drawing.Point(194, 352);
            this.BtnexitProduct.Name = "BtnexitProduct";
            this.BtnexitProduct.Size = new System.Drawing.Size(100, 35);
            this.BtnexitProduct.TabIndex = 35;
            this.BtnexitProduct.Text = "Cancelar";
            this.BtnexitProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnexitProduct.UseVisualStyleBackColor = false;
            this.BtnexitProduct.Click += new System.EventHandler(this.BtnexitProduct_Click);
            // 
            // BtnsaveProduct
            // 
            this.BtnsaveProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(146)))), ((int)(((byte)(190)))));
            this.BtnsaveProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnsaveProduct.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            this.BtnsaveProduct.ForeColor = System.Drawing.Color.White;
            this.BtnsaveProduct.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.BtnsaveProduct.IconColor = System.Drawing.Color.White;
            this.BtnsaveProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnsaveProduct.IconSize = 22;
            this.BtnsaveProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnsaveProduct.Location = new System.Drawing.Point(52, 352);
            this.BtnsaveProduct.Name = "BtnsaveProduct";
            this.BtnsaveProduct.Size = new System.Drawing.Size(100, 35);
            this.BtnsaveProduct.TabIndex = 34;
            this.BtnsaveProduct.Text = "Guardar";
            this.BtnsaveProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnsaveProduct.UseVisualStyleBackColor = false;
            this.BtnsaveProduct.Click += new System.EventHandler(this.BtnsaveProduct_Click);
            // 
            // NewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(360, 400);
            this.Controls.Add(this.gbPrice);
            this.Controls.Add(this.txtStockPro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.upBar);
            this.Controls.Add(this.BtnexitProduct);
            this.Controls.Add(this.BtnsaveProduct);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtIdPro);
            this.Controls.Add(this.txtCodPro);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtNamePro);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NewProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewProduct";
            this.upBar.ResumeLayout(false);
            this.upBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            this.gbPrice.ResumeLayout(false);
            this.gbPrice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel upBar;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox btnExit;
        private FontAwesome.Sharp.IconPictureBox btnMin;
        private FontAwesome.Sharp.IconButton BtnexitProduct;
        private FontAwesome.Sharp.IconButton BtnsaveProduct;
        private System.Windows.Forms.Label lblId;
        public System.Windows.Forms.TextBox txtIdPro;
        private System.Windows.Forms.Label lbl5;
        public System.Windows.Forms.TextBox txtCodPro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblName;
        public System.Windows.Forms.TextBox txtMayPro;
        public System.Windows.Forms.TextBox txtNamePro;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtMenPro;
        public System.Windows.Forms.TextBox txtStockPro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbPrice;
    }
}