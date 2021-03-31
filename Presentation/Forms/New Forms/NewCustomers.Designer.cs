
namespace Presentation.Forms.New_Forms
{
    partial class NewCustomers
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
            this.btnExit = new FontAwesome.Sharp.IconPictureBox();
            this.btnExitCusto = new FontAwesome.Sharp.IconButton();
            this.btnSaveCusto = new FontAwesome.Sharp.IconButton();
            this.upBarCli = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.btnMin = new FontAwesome.Sharp.IconPictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtCustoId = new System.Windows.Forms.TextBox();
            this.txtCustoName = new System.Windows.Forms.TextBox();
            this.txtCustoAddress = new System.Windows.Forms.TextBox();
            this.txtCustoCed = new System.Windows.Forms.TextBox();
            this.lbl5 = new System.Windows.Forms.Label();
            this.txtCustoPhone = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.upBarCli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 23;
            this.btnExit.Location = new System.Drawing.Point(328, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(29, 23);
            this.btnExit.TabIndex = 19;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnExitCusto
            // 
            this.btnExitCusto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(146)))), ((int)(((byte)(190)))));
            this.btnExitCusto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitCusto.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            this.btnExitCusto.ForeColor = System.Drawing.Color.White;
            this.btnExitCusto.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnExitCusto.IconColor = System.Drawing.Color.White;
            this.btnExitCusto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExitCusto.IconSize = 22;
            this.btnExitCusto.Location = new System.Drawing.Point(194, 338);
            this.btnExitCusto.Name = "btnExitCusto";
            this.btnExitCusto.Size = new System.Drawing.Size(100, 35);
            this.btnExitCusto.TabIndex = 29;
            this.btnExitCusto.Text = "Cancelar";
            this.btnExitCusto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExitCusto.UseVisualStyleBackColor = false;
            this.btnExitCusto.Click += new System.EventHandler(this.BtnExitCusto_Click);
            // 
            // btnSaveCusto
            // 
            this.btnSaveCusto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(146)))), ((int)(((byte)(190)))));
            this.btnSaveCusto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveCusto.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            this.btnSaveCusto.ForeColor = System.Drawing.Color.White;
            this.btnSaveCusto.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSaveCusto.IconColor = System.Drawing.Color.White;
            this.btnSaveCusto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSaveCusto.IconSize = 22;
            this.btnSaveCusto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveCusto.Location = new System.Drawing.Point(52, 338);
            this.btnSaveCusto.Name = "btnSaveCusto";
            this.btnSaveCusto.Size = new System.Drawing.Size(100, 35);
            this.btnSaveCusto.TabIndex = 28;
            this.btnSaveCusto.Text = "Guardar";
            this.btnSaveCusto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveCusto.UseVisualStyleBackColor = false;
            this.btnSaveCusto.Click += new System.EventHandler(this.BtnSaveCusto_Click);
            // 
            // upBarCli
            // 
            this.upBarCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.upBarCli.Controls.Add(this.label1);
            this.upBarCli.Controls.Add(this.iconPictureBox1);
            this.upBarCli.Controls.Add(this.btnExit);
            this.upBarCli.Controls.Add(this.btnMin);
            this.upBarCli.Dock = System.Windows.Forms.DockStyle.Top;
            this.upBarCli.Location = new System.Drawing.Point(0, 0);
            this.upBarCli.Name = "upBarCli";
            this.upBarCli.Size = new System.Drawing.Size(360, 46);
            this.upBarCli.TabIndex = 34;
            this.upBarCli.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpBarCli_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(153, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "Cliente";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpBarCli_MouseDown);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 37;
            this.iconPictureBox1.Location = new System.Drawing.Point(108, 7);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(37, 37);
            this.iconPictureBox1.TabIndex = 22;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpBarCli_MouseDown);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnMin.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMin.IconColor = System.Drawing.Color.White;
            this.btnMin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMin.IconSize = 23;
            this.btnMin.Location = new System.Drawing.Point(292, 5);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(29, 23);
            this.btnMin.TabIndex = 20;
            this.btnMin.TabStop = false;
            this.btnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 29;
            this.label4.Text = "Dirección:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(36, 71);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 15);
            this.lblName.TabIndex = 27;
            this.lblName.Text = "Nombre:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = "Cédula / R.U.C.:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(58, 290);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(67, 15);
            this.lblId.TabIndex = 32;
            this.lblId.Text = "IdCustomer";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblId.Visible = false;
            // 
            // txtCustoId
            // 
            this.txtCustoId.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoId.Location = new System.Drawing.Point(156, 290);
            this.txtCustoId.Name = "txtCustoId";
            this.txtCustoId.Size = new System.Drawing.Size(138, 23);
            this.txtCustoId.TabIndex = 33;
            this.txtCustoId.Visible = false;
            // 
            // txtCustoName
            // 
            this.txtCustoName.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoName.Location = new System.Drawing.Point(156, 70);
            this.txtCustoName.Name = "txtCustoName";
            this.txtCustoName.Size = new System.Drawing.Size(176, 23);
            this.txtCustoName.TabIndex = 24;
            this.txtCustoName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCustoName_KeyPress);
            // 
            // txtCustoAddress
            // 
            this.txtCustoAddress.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoAddress.Location = new System.Drawing.Point(156, 185);
            this.txtCustoAddress.Name = "txtCustoAddress";
            this.txtCustoAddress.Size = new System.Drawing.Size(176, 23);
            this.txtCustoAddress.TabIndex = 26;
            // 
            // txtCustoCed
            // 
            this.txtCustoCed.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoCed.Location = new System.Drawing.Point(156, 126);
            this.txtCustoCed.Name = "txtCustoCed";
            this.txtCustoCed.Size = new System.Drawing.Size(176, 23);
            this.txtCustoCed.TabIndex = 25;
            this.txtCustoCed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCustoCed_KeyPress);
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(36, 242);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(55, 15);
            this.lbl5.TabIndex = 30;
            this.lbl5.Text = "Teléfono:";
            // 
            // txtCustoPhone
            // 
            this.txtCustoPhone.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoPhone.Location = new System.Drawing.Point(156, 242);
            this.txtCustoPhone.Name = "txtCustoPhone";
            this.txtCustoPhone.Size = new System.Drawing.Size(176, 23);
            this.txtCustoPhone.TabIndex = 27;
            this.txtCustoPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCustoPhone_KeyPress);
            // 
            // NewCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 400);
            this.Controls.Add(this.txtCustoPhone);
            this.Controls.Add(this.btnExitCusto);
            this.Controls.Add(this.btnSaveCusto);
            this.Controls.Add(this.upBarCli);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtCustoId);
            this.Controls.Add(this.txtCustoName);
            this.Controls.Add(this.txtCustoAddress);
            this.Controls.Add(this.txtCustoCed);
            this.Controls.Add(this.lbl5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "NewCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewCustomers";
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.upBarCli.ResumeLayout(false);
            this.upBarCli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private FontAwesome.Sharp.IconPictureBox btnExit;
        private FontAwesome.Sharp.IconButton btnExitCusto;
        private FontAwesome.Sharp.IconButton btnSaveCusto;
        private System.Windows.Forms.Panel upBarCli;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox btnMin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblId;
        public System.Windows.Forms.TextBox txtCustoId;
        public System.Windows.Forms.TextBox txtCustoName;
        public System.Windows.Forms.TextBox txtCustoAddress;
        public System.Windows.Forms.TextBox txtCustoCed;
        private System.Windows.Forms.Label lbl5;
        public System.Windows.Forms.TextBox txtCustoPhone;
    }
}