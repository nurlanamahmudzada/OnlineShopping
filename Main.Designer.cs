namespace OnlineShopping
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            btn_register = new Button();
            btn_login = new Button();
            SuspendLayout();
            // 
            // btn_register
            // 
            btn_register.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btn_register.BackColor = Color.SeaShell;
            btn_register.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_register.ForeColor = SystemColors.HotTrack;
            btn_register.Location = new Point(164, 233);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(132, 45);
            btn_register.TabIndex = 0;
            btn_register.Text = "Register";
            btn_register.UseVisualStyleBackColor = false;
            btn_register.Click += btn_register_Click;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.SeaShell;
            btn_login.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_login.ForeColor = SystemColors.HotTrack;
            btn_login.Location = new Point(164, 284);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(132, 45);
            btn_login.TabIndex = 1;
            btn_login.Text = "Log In";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_login);
            Controls.Add(btn_register);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Page";
            Load += Main_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_register;
        private Button btn_login;
    }
}