namespace OnlineShopping
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            tb_username = new TextBox();
            tb_pass = new TextBox();
            btn_login = new Button();
            lbl_username = new Label();
            lbl_pass = new Label();
            linkLabel1 = new LinkLabel();
            cb_role = new ComboBox();
            label1 = new Label();
            btn_exit = new Button();
            SuspendLayout();
            // 
            // tb_username
            // 
            tb_username.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb_username.Location = new Point(242, 138);
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(142, 29);
            tb_username.TabIndex = 0;
            tb_username.Text = "User";
            // 
            // tb_pass
            // 
            tb_pass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb_pass.Location = new Point(242, 183);
            tb_pass.Name = "tb_pass";
            tb_pass.Size = new Size(142, 29);
            tb_pass.TabIndex = 1;
            tb_pass.KeyDown += tb_pass_KeyDown;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.SteelBlue;
            btn_login.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_login.Location = new Point(225, 231);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(117, 38);
            btn_login.TabIndex = 2;
            btn_login.Text = "Log In";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_username.Location = new Point(138, 138);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(98, 25);
            lbl_username.TabIndex = 3;
            lbl_username.Text = "Username";
            // 
            // lbl_pass
            // 
            lbl_pass.AutoSize = true;
            lbl_pass.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_pass.Location = new Point(145, 183);
            lbl_pass.Name = "lbl_pass";
            lbl_pass.Size = new Size(91, 25);
            lbl_pass.TabIndex = 4;
            lbl_pass.Text = "Password";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel1.Location = new Point(212, 282);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(144, 25);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Create Account";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // cb_role
            // 
            cb_role.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cb_role.FormattingEnabled = true;
            cb_role.Items.AddRange(new object[] { "admin", "user" });
            cb_role.Location = new Point(242, 90);
            cb_role.Name = "cb_role";
            cb_role.Size = new Size(142, 29);
            cb_role.TabIndex = 6;
            cb_role.Text = "choose your role";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(182, 94);
            label1.Name = "label1";
            label1.Size = new Size(54, 25);
            label1.TabIndex = 7;
            label1.Text = "Role ";
            // 
            // btn_exit
            // 
            btn_exit.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_exit.ForeColor = Color.Red;
            btn_exit.Location = new Point(737, 12);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(51, 34);
            btn_exit.TabIndex = 8;
            btn_exit.Text = "X";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_exit);
            Controls.Add(label1);
            Controls.Add(cb_role);
            Controls.Add(linkLabel1);
            Controls.Add(lbl_pass);
            Controls.Add(lbl_username);
            Controls.Add(btn_login);
            Controls.Add(tb_pass);
            Controls.Add(tb_username);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_username;
        private TextBox tb_pass;
        private Button btn_login;
        private Label lbl_username;
        private Label lbl_pass;
        private LinkLabel linkLabel1;
        private ComboBox cb_role;
        private Label label1;
        private Button btn_exit;
    }
}