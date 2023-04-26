namespace OnlineShopping
{
    partial class AdminPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPage));
            btn_addproduct = new Button();
            label4 = new Label();
            panel1 = new Panel();
            btn_show_products = new Button();
            tb_pId = new TextBox();
            label6 = new Label();
            btn_choose_image = new Button();
            label5 = new Label();
            tb_pcount = new TextBox();
            tb_price = new TextBox();
            tb_pname = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView = new DataGridView();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            linkLabel1 = new LinkLabel();
            btn_clearphoto = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_addproduct
            // 
            btn_addproduct.BackColor = Color.LightSteelBlue;
            btn_addproduct.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_addproduct.Location = new Point(179, 367);
            btn_addproduct.Name = "btn_addproduct";
            btn_addproduct.Size = new Size(103, 32);
            btn_addproduct.TabIndex = 0;
            btn_addproduct.Text = "Add Product";
            btn_addproduct.UseVisualStyleBackColor = false;
            btn_addproduct.Click += btn_addproduct_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Print", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(12, 22);
            label4.Name = "label4";
            label4.Size = new Size(177, 43);
            label4.TabIndex = 4;
            label4.Text = "Admin Panel";
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(btn_show_products);
            panel1.Controls.Add(tb_pId);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btn_choose_image);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(tb_pcount);
            panel1.Controls.Add(tb_price);
            panel1.Controls.Add(tb_pname);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 84);
            panel1.Name = "panel1";
            panel1.Size = new Size(379, 231);
            panel1.TabIndex = 5;
            // 
            // btn_show_products
            // 
            btn_show_products.BackColor = Color.PowderBlue;
            btn_show_products.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_show_products.Location = new Point(275, 9);
            btn_show_products.Name = "btn_show_products";
            btn_show_products.Size = new Size(72, 40);
            btn_show_products.TabIndex = 12;
            btn_show_products.Text = "Show Products";
            btn_show_products.UseVisualStyleBackColor = false;
            btn_show_products.Click += btn_show_products_Click;
            // 
            // tb_pId
            // 
            tb_pId.Location = new Point(161, 19);
            tb_pId.Name = "tb_pId";
            tb_pId.Size = new Size(108, 23);
            tb_pId.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(8, 14);
            label6.Name = "label6";
            label6.Size = new Size(111, 25);
            label6.TabIndex = 16;
            label6.Text = "Product Id :";
            // 
            // btn_choose_image
            // 
            btn_choose_image.BackColor = Color.Silver;
            btn_choose_image.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_choose_image.Location = new Point(159, 191);
            btn_choose_image.Name = "btn_choose_image";
            btn_choose_image.Size = new Size(132, 33);
            btn_choose_image.TabIndex = 15;
            btn_choose_image.Text = "Choose image";
            btn_choose_image.UseVisualStyleBackColor = false;
            btn_choose_image.Click += btn_choose_image_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(7, 193);
            label5.Name = "label5";
            label5.Size = new Size(141, 25);
            label5.TabIndex = 14;
            label5.Text = "Upload image :";
            // 
            // tb_pcount
            // 
            tb_pcount.Location = new Point(161, 149);
            tb_pcount.Name = "tb_pcount";
            tb_pcount.Size = new Size(208, 23);
            tb_pcount.TabIndex = 13;
            // 
            // tb_price
            // 
            tb_price.Location = new Point(161, 104);
            tb_price.Name = "tb_price";
            tb_price.Size = new Size(208, 23);
            tb_price.TabIndex = 12;
            // 
            // tb_pname
            // 
            tb_pname.Location = new Point(161, 59);
            tb_pname.Name = "tb_pname";
            tb_pname.Size = new Size(208, 23);
            tb_pname.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(7, 144);
            label3.Name = "label3";
            label3.Size = new Size(146, 25);
            label3.TabIndex = 10;
            label3.Text = "Product Count :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(8, 99);
            label2.Name = "label2";
            label2.Size = new Size(136, 25);
            label2.TabIndex = 9;
            label2.Text = "Product Price :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(7, 54);
            label1.Name = "label1";
            label1.Size = new Size(146, 25);
            label1.TabIndex = 8;
            label1.Text = "Product Name :";
            // 
            // dataGridView
            // 
            dataGridView.BackgroundColor = Color.WhiteSmoke;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(420, 32);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(322, 392);
            dataGridView.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(662, 431);
            button1.Name = "button1";
            button1.Size = new Size(80, 32);
            button1.TabIndex = 7;
            button1.Text = "Log out";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.WhiteSmoke;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(20, 330);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(146, 133);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Arial Narrow", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel1.Location = new Point(478, 436);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(178, 22);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Go to customers' orders";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // btn_clearphoto
            // 
            btn_clearphoto.BackColor = Color.MistyRose;
            btn_clearphoto.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_clearphoto.ForeColor = SystemColors.ActiveCaptionText;
            btn_clearphoto.Location = new Point(179, 405);
            btn_clearphoto.Name = "btn_clearphoto";
            btn_clearphoto.Size = new Size(102, 32);
            btn_clearphoto.TabIndex = 10;
            btn_clearphoto.Text = "Clear Photo";
            btn_clearphoto.UseVisualStyleBackColor = false;
            btn_clearphoto.Click += btn_clearphoto_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.MediumSpringGreen;
            btn_update.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_update.Location = new Point(288, 367);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(104, 32);
            btn_update.TabIndex = 11;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.LightCoral;
            btn_delete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_delete.Location = new Point(289, 405);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(103, 32);
            btn_delete.TabIndex = 12;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // AdminPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(765, 475);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_clearphoto);
            Controls.Add(linkLabel1);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(dataGridView);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(btn_addproduct);
            Name = "AdminPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminPage";
            Load += AdminPage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_addproduct;
        private Label label4;
        private Panel panel1;
        private TextBox tb_pcount;
        private TextBox tb_price;
        private TextBox tb_pname;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView;
        private Button button1;
        private Label label5;
        private Button btn_choose_image;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
        private LinkLabel linkLabel1;
        private Button btn_clearphoto;
        private TextBox tb_pId;
        private Label label6;
        private Button btn_update;
        private Button btn_show_products;
        private Button btn_delete;
    }
}