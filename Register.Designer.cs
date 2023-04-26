namespace OnlineShopping
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            lbl_name = new Label();
            lbl_pass = new Label();
            lbl_confirmpass = new Label();
            btn_submit = new Button();
            tb_name = new TextBox();
            tb_pass = new TextBox();
            tb_confirmpass = new TextBox();
            link = new LinkLabel();
            SuspendLayout();
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_name.Location = new Point(152, 81);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(126, 30);
            lbl_name.TabIndex = 0;
            lbl_name.Text = "Username : ";
            // 
            // lbl_pass
            // 
            lbl_pass.AutoSize = true;
            lbl_pass.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_pass.Location = new Point(152, 125);
            lbl_pass.Name = "lbl_pass";
            lbl_pass.Size = new Size(114, 30);
            lbl_pass.TabIndex = 1;
            lbl_pass.Text = "Password :";
            // 
            // lbl_confirmpass
            // 
            lbl_confirmpass.AutoSize = true;
            lbl_confirmpass.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_confirmpass.Location = new Point(81, 166);
            lbl_confirmpass.Name = "lbl_confirmpass";
            lbl_confirmpass.Size = new Size(197, 30);
            lbl_confirmpass.TabIndex = 2;
            lbl_confirmpass.Text = "Confirm Password :";
            // 
            // btn_submit
            // 
            btn_submit.BackColor = Color.SteelBlue;
            btn_submit.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn_submit.Location = new Point(242, 211);
            btn_submit.Name = "btn_submit";
            btn_submit.Size = new Size(132, 41);
            btn_submit.TabIndex = 3;
            btn_submit.Text = "Submit";
            btn_submit.UseVisualStyleBackColor = false;
            btn_submit.Click += btn_submit_Click;
            // 
            // tb_name
            // 
            tb_name.Location = new Point(284, 81);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(198, 23);
            tb_name.TabIndex = 4;
            // 
            // tb_pass
            // 
            tb_pass.Location = new Point(284, 125);
            tb_pass.Name = "tb_pass";
            tb_pass.Size = new Size(198, 23);
            tb_pass.TabIndex = 5;
            // 
            // tb_confirmpass
            // 
            tb_confirmpass.Location = new Point(284, 166);
            tb_confirmpass.Name = "tb_confirmpass";
            tb_confirmpass.Size = new Size(198, 23);
            tb_confirmpass.TabIndex = 6;
            // 
            // link
            // 
            link.AutoSize = true;
            link.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            link.Location = new Point(114, 267);
            link.Name = "link";
            link.Size = new Size(368, 25);
            link.TabIndex = 8;
            link.TabStop = true;
            link.Text = "If you have already account, please Log In!";
            link.Visible = false;
            link.LinkClicked += link_LinkClicked;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(link);
            Controls.Add(tb_confirmpass);
            Controls.Add(tb_pass);
            Controls.Add(tb_name);
            Controls.Add(btn_submit);
            Controls.Add(lbl_confirmpass);
            Controls.Add(lbl_pass);
            Controls.Add(lbl_name);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_name;
        private Label lbl_pass;
        private Label lbl_confirmpass;
        private Button btn_submit;
        private TextBox tb_name;
        private TextBox tb_pass;
        private TextBox tb_confirmpass;
        private LinkLabel link;
    }
}