
namespace Presentation.Forms.New_Forms
{
    partial class NewPurchase
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
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.btnExit = new FontAwesome.Sharp.IconPictureBox();
            this.btnMin = new FontAwesome.Sharp.IconPictureBox();
            this.BtnexitComp = new FontAwesome.Sharp.IconButton();
            this.BtnsaveComp = new FontAwesome.Sharp.IconButton();
            this.upBar = new System.Windows.Forms.Panel();
            this.lblId = new System.Windows.Forms.Label();
            this.txtIdProd_Comp = new System.Windows.Forms.TextBox();
            this.lbl5 = new System.Windows.Forms.Label();
            this.txtCodProdComp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtDateComp = new System.Windows.Forms.TextBox();
            this.txtNameProdComp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantComp = new System.Windows.Forms.TextBox();
            this.BtnEditComp = new FontAwesome.Sharp.IconButton();
            this.txtIdComp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            this.upBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(153, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "Compra";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpBar_MouseDown);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 37;
            this.iconPictureBox1.Location = new System.Drawing.Point(108, 7);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(37, 37);
            this.iconPictureBox1.TabIndex = 22;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UpBar_MouseDown);
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
            // BtnexitComp
            // 
            this.BtnexitComp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(146)))), ((int)(((byte)(190)))));
            this.BtnexitComp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnexitComp.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            this.BtnexitComp.ForeColor = System.Drawing.Color.White;
            this.BtnexitComp.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.BtnexitComp.IconColor = System.Drawing.Color.White;
            this.BtnexitComp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnexitComp.IconSize = 22;
            this.BtnexitComp.Location = new System.Drawing.Point(194, 352);
            this.BtnexitComp.Name = "BtnexitComp";
            this.BtnexitComp.Size = new System.Drawing.Size(100, 35);
            this.BtnexitComp.TabIndex = 36;
            this.BtnexitComp.Text = "Cancelar";
            this.BtnexitComp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnexitComp.UseVisualStyleBackColor = false;
            this.BtnexitComp.Click += new System.EventHandler(this.BtnexitComp_Click);
            // 
            // BtnsaveComp
            // 
            this.BtnsaveComp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(146)))), ((int)(((byte)(190)))));
            this.BtnsaveComp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnsaveComp.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            this.BtnsaveComp.ForeColor = System.Drawing.Color.White;
            this.BtnsaveComp.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.BtnsaveComp.IconColor = System.Drawing.Color.White;
            this.BtnsaveComp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnsaveComp.IconSize = 22;
            this.BtnsaveComp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnsaveComp.Location = new System.Drawing.Point(45, 352);
            this.BtnsaveComp.Name = "BtnsaveComp";
            this.BtnsaveComp.Size = new System.Drawing.Size(100, 35);
            this.BtnsaveComp.TabIndex = 35;
            this.BtnsaveComp.Text = "Guardar";
            this.BtnsaveComp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnsaveComp.UseVisualStyleBackColor = false;
            this.BtnsaveComp.Visible = false;
            this.BtnsaveComp.Click += new System.EventHandler(this.BtnsaveComp_Click);
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
            this.upBar.TabIndex = 34;
            this.upBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpBar_MouseDown);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(36, 310);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(78, 15);
            this.lblId.TabIndex = 32;
            this.lblId.Text = "IdProd_Comp";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblId.Visible = false;
            // 
            // txtIdProd_Comp
            // 
            this.txtIdProd_Comp.BackColor = System.Drawing.Color.White;
            this.txtIdProd_Comp.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProd_Comp.Location = new System.Drawing.Point(183, 307);
            this.txtIdProd_Comp.Name = "txtIdProd_Comp";
            this.txtIdProd_Comp.Size = new System.Drawing.Size(138, 23);
            this.txtIdProd_Comp.TabIndex = 33;
            this.txtIdProd_Comp.Visible = false;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(36, 259);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(57, 15);
            this.lbl5.TabIndex = 30;
            this.lbl5.Text = "Cantidad:";
            // 
            // txtCodProdComp
            // 
            this.txtCodProdComp.BackColor = System.Drawing.Color.White;
            this.txtCodProdComp.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodProdComp.Location = new System.Drawing.Point(183, 87);
            this.txtCodProdComp.Name = "txtCodProdComp";
            this.txtCodProdComp.ReadOnly = true;
            this.txtCodProdComp.Size = new System.Drawing.Size(138, 23);
            this.txtCodProdComp.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 29;
            this.label4.Text = "Fecha:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(36, 88);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 15);
            this.lblName.TabIndex = 27;
            this.lblName.Text = "Código Producto:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDateComp
            // 
            this.txtDateComp.BackColor = System.Drawing.Color.White;
            this.txtDateComp.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateComp.Location = new System.Drawing.Point(183, 206);
            this.txtDateComp.Name = "txtDateComp";
            this.txtDateComp.ReadOnly = true;
            this.txtDateComp.Size = new System.Drawing.Size(138, 23);
            this.txtDateComp.TabIndex = 25;
            // 
            // txtNameProdComp
            // 
            this.txtNameProdComp.BackColor = System.Drawing.Color.White;
            this.txtNameProdComp.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameProdComp.Location = new System.Drawing.Point(183, 143);
            this.txtNameProdComp.Name = "txtNameProdComp";
            this.txtNameProdComp.ReadOnly = true;
            this.txtNameProdComp.Size = new System.Drawing.Size(138, 23);
            this.txtNameProdComp.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = "Nombre Producto:";
            // 
            // txtCantComp
            // 
            this.txtCantComp.BackColor = System.Drawing.Color.White;
            this.txtCantComp.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantComp.Location = new System.Drawing.Point(183, 251);
            this.txtCantComp.Name = "txtCantComp";
            this.txtCantComp.Size = new System.Drawing.Size(138, 23);
            this.txtCantComp.TabIndex = 24;
            // 
            // BtnEditComp
            // 
            this.BtnEditComp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(146)))), ((int)(((byte)(190)))));
            this.BtnEditComp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditComp.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            this.BtnEditComp.ForeColor = System.Drawing.Color.White;
            this.BtnEditComp.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.BtnEditComp.IconColor = System.Drawing.Color.White;
            this.BtnEditComp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEditComp.IconSize = 22;
            this.BtnEditComp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditComp.Location = new System.Drawing.Point(54, 353);
            this.BtnEditComp.Name = "BtnEditComp";
            this.BtnEditComp.Size = new System.Drawing.Size(100, 35);
            this.BtnEditComp.TabIndex = 37;
            this.BtnEditComp.Text = "Guardar";
            this.BtnEditComp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEditComp.UseVisualStyleBackColor = false;
            this.BtnEditComp.Visible = false;
            this.BtnEditComp.Click += new System.EventHandler(this.BtnEditComp_Click);
            // 
            // txtIdComp
            // 
            this.txtIdComp.BackColor = System.Drawing.Color.White;
            this.txtIdComp.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdComp.Location = new System.Drawing.Point(194, 307);
            this.txtIdComp.Name = "txtIdComp";
            this.txtIdComp.Size = new System.Drawing.Size(138, 23);
            this.txtIdComp.TabIndex = 38;
            this.txtIdComp.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 39;
            this.label2.Text = "IdComp";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Visible = false;
            // 
            // NewPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(360, 400);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdComp);
            this.Controls.Add(this.BtnEditComp);
            this.Controls.Add(this.txtCantComp);
            this.Controls.Add(this.BtnexitComp);
            this.Controls.Add(this.BtnsaveComp);
            this.Controls.Add(this.upBar);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtIdProd_Comp);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.txtCodProdComp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtDateComp);
            this.Controls.Add(this.txtNameProdComp);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NewPurchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewPurchase";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            this.upBar.ResumeLayout(false);
            this.upBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox btnExit;
        private FontAwesome.Sharp.IconPictureBox btnMin;
        private FontAwesome.Sharp.IconButton BtnexitComp;
        private System.Windows.Forms.Panel upBar;
        private System.Windows.Forms.Label lblId;
        public System.Windows.Forms.TextBox txtIdProd_Comp;
        private System.Windows.Forms.Label lbl5;
        public System.Windows.Forms.TextBox txtCodProdComp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblName;
        public System.Windows.Forms.TextBox txtDateComp;
        public System.Windows.Forms.TextBox txtNameProdComp;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtCantComp;
        public System.Windows.Forms.TextBox txtIdComp;
        private System.Windows.Forms.Label label2;
        public FontAwesome.Sharp.IconButton BtnsaveComp;
        public FontAwesome.Sharp.IconButton BtnEditComp;
    }
}