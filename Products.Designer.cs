namespace OnlineShopping
{
    partial class Products
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
            lbl_products = new Label();
            btn_orders = new Button();
            openFileDialog1 = new OpenFileDialog();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            cb_products = new ComboBox();
            btn_buy = new Button();
            btn_show = new Button();
            btn_clear = new Button();
            btn_exit = new Button();
            label1 = new Label();
            tb_productItems = new TextBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            dataGridView_basket = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_basket).BeginInit();
            SuspendLayout();
            // 
            // lbl_products
            // 
            lbl_products.AutoSize = true;
            lbl_products.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_products.Location = new Point(29, 19);
            lbl_products.Name = "lbl_products";
            lbl_products.Size = new Size(89, 25);
            lbl_products.TabIndex = 1;
            lbl_products.Text = "Products";
            // 
            // btn_orders
            // 
            btn_orders.BackColor = Color.ForestGreen;
            btn_orders.BackgroundImageLayout = ImageLayout.Stretch;
            btn_orders.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_orders.ForeColor = SystemColors.ButtonHighlight;
            btn_orders.Location = new Point(638, 392);
            btn_orders.Name = "btn_orders";
            btn_orders.Size = new Size(98, 36);
            btn_orders.TabIndex = 3;
            btn_orders.Text = "Order";
            btn_orders.UseVisualStyleBackColor = false;
            btn_orders.Click += btn_orders_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 61);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(450, 216);
            dataGridView1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.WhiteSmoke;
            pictureBox1.Location = new Point(485, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 149);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // cb_products
            // 
            cb_products.BackColor = Color.WhiteSmoke;
            cb_products.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cb_products.FormattingEnabled = true;
            cb_products.Location = new Point(540, 301);
            cb_products.Name = "cb_products";
            cb_products.Size = new Size(92, 29);
            cb_products.TabIndex = 7;
            // 
            // btn_buy
            // 
            btn_buy.BackColor = Color.Gold;
            btn_buy.Font = new Font("Arial Narrow", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_buy.Location = new Point(597, 334);
            btn_buy.Name = "btn_buy";
            btn_buy.Size = new Size(114, 29);
            btn_buy.TabIndex = 8;
            btn_buy.Text = "Add to basket";
            btn_buy.UseVisualStyleBackColor = false;
            btn_buy.Click += btn_buy_Click;
            // 
            // btn_show
            // 
            btn_show.BackColor = SystemColors.ScrollBar;
            btn_show.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_show.Location = new Point(485, 216);
            btn_show.Name = "btn_show";
            btn_show.Size = new Size(107, 32);
            btn_show.TabIndex = 9;
            btn_show.Text = "Show product";
            btn_show.UseVisualStyleBackColor = false;
            btn_show.Click += btn_show_Click;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.LightCoral;
            btn_clear.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_clear.ForeColor = Color.Black;
            btn_clear.Location = new Point(509, 392);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(123, 36);
            btn_clear.TabIndex = 11;
            btn_clear.Text = "Clear the basket";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_exit
            // 
            btn_exit.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_exit.ForeColor = Color.Red;
            btn_exit.Location = new Point(718, 12);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(35, 32);
            btn_exit.TabIndex = 12;
            btn_exit.Text = "x";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(521, 267);
            label1.Name = "label1";
            label1.Size = new Size(218, 20);
            label1.TabIndex = 13;
            label1.Text = "choose product and items by id";
            // 
            // tb_productItems
            // 
            tb_productItems.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb_productItems.Location = new Point(638, 301);
            tb_productItems.Name = "tb_productItems";
            tb_productItems.Size = new Size(85, 29);
            tb_productItems.TabIndex = 14;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(555, 334);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 27);
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(29, 291);
            label2.Name = "label2";
            label2.Size = new Size(114, 25);
            label2.TabIndex = 1;
            label2.Text = "Your basket";
            // 
            // dataGridView_basket
            // 
            dataGridView_basket.BackgroundColor = Color.WhiteSmoke;
            dataGridView_basket.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_basket.Location = new Point(29, 324);
            dataGridView_basket.Name = "dataGridView_basket";
            dataGridView_basket.RowTemplate.Height = 25;
            dataGridView_basket.Size = new Size(450, 139);
            dataGridView_basket.TabIndex = 16;
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(765, 475);
            Controls.Add(dataGridView_basket);
            Controls.Add(pictureBox2);
            Controls.Add(tb_productItems);
            Controls.Add(label1);
            Controls.Add(btn_exit);
            Controls.Add(btn_clear);
            Controls.Add(btn_show);
            Controls.Add(btn_buy);
            Controls.Add(cb_products);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(btn_orders);
            Controls.Add(label2);
            Controls.Add(lbl_products);
            Name = "Products";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Products";
            Load += Products_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_basket).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_products;
        private Button btn_orders;
        private OpenFileDialog openFileDialog1;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private ComboBox cb_products;
        private Button btn_buy;
        private Button btn_show;
        private Button btn_clear;
        private Button btn_exit;
        private Label label1;
        private TextBox tb_productItems;
        private PictureBox pictureBox2;
        private Label label2;
        private DataGridView dataGridView_basket;
    }
}