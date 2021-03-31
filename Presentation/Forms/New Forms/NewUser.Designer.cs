
namespace Presentation.Forms.New_Forms
{
    partial class NewUser
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
            this.txt_user_Type = new System.Windows.Forms.ComboBox();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_user_Passwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_user_Name = new System.Windows.Forms.TextBox();
            this.txt_user_Ced = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnMin = new FontAwesome.Sharp.IconPictureBox();
            this.btnExit = new FontAwesome.Sharp.IconPictureBox();
            this.upBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.btnexitUser = new FontAwesome.Sharp.IconButton();
            this.btnsaveUser = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.upBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_user_Type
            // 
            this.txt_user_Type.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user_Type.FormattingEnabled = true;
            this.txt_user_Type.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.txt_user_Type.Location = new System.Drawing.Point(156, 240);
            this.txt_user_Type.Name = "txt_user_Type";
            this.txt_user_Type.Size = new System.Drawing.Size(176, 23);
            this.txt_user_Type.TabIndex = 17;
            this.txt_user_Type.Tag = "";
            this.txt_user_Type.Text = "Seleccione";
            this.txt_user_Type.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_user_Type_KeyPress);
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(36, 245);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(91, 15);
            this.lbl5.TabIndex = 9;
            this.lbl5.Text = "Tipo de usuario:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(36, 74);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 15);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Nombre:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Contraseña:";
            // 
            // txt_user_Passwd
            // 
            this.txt_user_Passwd.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user_Passwd.Location = new System.Drawing.Point(156, 192);
            this.txt_user_Passwd.Name = "txt_user_Passwd";
            this.txt_user_Passwd.PasswordChar = '*';
            this.txt_user_Passwd.Size = new System.Drawing.Size(176, 23);
            this.txt_user_Passwd.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cédula / R.U.C.:";
            // 
            // txt_user_Name
            // 
            this.txt_user_Name.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user_Name.Location = new System.Drawing.Point(156, 73);
            this.txt_user_Name.Name = "txt_user_Name";
            this.txt_user_Name.Size = new System.Drawing.Size(176, 23);
            this.txt_user_Name.TabIndex = 1;
            this.txt_user_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_user_Name_KeyPress);
            // 
            // txt_user_Ced
            // 
            this.txt_user_Ced.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user_Ced.Location = new System.Drawing.Point(156, 129);
            this.txt_user_Ced.Name = "txt_user_Ced";
            this.txt_user_Ced.Size = new System.Drawing.Size(176, 23);
            this.txt_user_Ced.TabIndex = 2;
            this.txt_user_Ced.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_user_Ced_KeyPress);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(156, 293);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(138, 23);
            this.txtID.TabIndex = 18;
            this.txtID.Visible = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(58, 293);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(40, 15);
            this.lblId.TabIndex = 18;
            this.lblId.Text = "IdUser";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblId.Visible = false;
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
            this.upBar.TabIndex = 21;
            this.upBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpBar_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(153, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "Usuario";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpBar_MouseDown);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
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
            // btnexitUser
            // 
            this.btnexitUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(146)))), ((int)(((byte)(190)))));
            this.btnexitUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexitUser.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            this.btnexitUser.ForeColor = System.Drawing.Color.White;
            this.btnexitUser.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnexitUser.IconColor = System.Drawing.Color.White;
            this.btnexitUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnexitUser.IconSize = 22;
            this.btnexitUser.Location = new System.Drawing.Point(194, 338);
            this.btnexitUser.Name = "btnexitUser";
            this.btnexitUser.Size = new System.Drawing.Size(100, 35);
            this.btnexitUser.TabIndex = 23;
            this.btnexitUser.Text = "Cancelar";
            this.btnexitUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnexitUser.UseVisualStyleBackColor = false;
            this.btnexitUser.Click += new System.EventHandler(this.BtnexitUser_Click);
            // 
            // btnsaveUser
            // 
            this.btnsaveUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(146)))), ((int)(((byte)(190)))));
            this.btnsaveUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsaveUser.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            this.btnsaveUser.ForeColor = System.Drawing.Color.White;
            this.btnsaveUser.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnsaveUser.IconColor = System.Drawing.Color.White;
            this.btnsaveUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnsaveUser.IconSize = 22;
            this.btnsaveUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsaveUser.Location = new System.Drawing.Point(52, 338);
            this.btnsaveUser.Name = "btnsaveUser";
            this.btnsaveUser.Size = new System.Drawing.Size(100, 35);
            this.btnsaveUser.TabIndex = 22;
            this.btnsaveUser.Text = "Guardar";
            this.btnsaveUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsaveUser.UseVisualStyleBackColor = false;
            this.btnsaveUser.Click += new System.EventHandler(this.SaveUser_Click);
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(360, 400);
            this.Controls.Add(this.btnexitUser);
            this.Controls.Add(this.btnsaveUser);
            this.Controls.Add(this.upBar);
            this.Controls.Add(this.txt_user_Type);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.txt_user_Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txt_user_Passwd);
            this.Controls.Add(this.txt_user_Ced);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewUser";
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.upBar.ResumeLayout(false);
            this.upBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_user_Name;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.ComboBox txt_user_Type;
        public System.Windows.Forms.TextBox txt_user_Passwd;
        public System.Windows.Forms.TextBox txt_user_Ced;
        private System.Windows.Forms.Label lblId;
        private FontAwesome.Sharp.IconPictureBox btnMin;
        private FontAwesome.Sharp.IconPictureBox btnExit;
        private System.Windows.Forms.Panel upBar;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnexitUser;
        private FontAwesome.Sharp.IconButton btnsaveUser;
    }
}