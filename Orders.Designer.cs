namespace OnlineShopping
{
    partial class Orders
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders));
            dataGridView1 = new DataGridView();
            label1 = new Label();
            btn_delete_order = new Button();
            lbl_getorders = new Label();
            comboBox1 = new ComboBox();
            btn_show = new Button();
            btn_exit = new Button();
            btn_back = new Button();
            cb_status = new ComboBox();
            tb_confirm = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Location = new Point(22, 86);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(465, 349);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.WhiteSmoke;
            label1.Font = new Font("Artifakt Element", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(22, 36);
            label1.Name = "label1";
            label1.Size = new Size(223, 33);
            label1.TabIndex = 1;
            label1.Text = "Customers' Orders";
            // 
            // btn_delete_order
            // 
            btn_delete_order.BackColor = Color.Red;
            btn_delete_order.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_delete_order.ForeColor = SystemColors.ButtonHighlight;
            btn_delete_order.Location = new Point(667, 192);
            btn_delete_order.Name = "btn_delete_order";
            btn_delete_order.Size = new Size(75, 29);
            btn_delete_order.TabIndex = 2;
            btn_delete_order.Text = "Delete";
            btn_delete_order.UseVisualStyleBackColor = false;
            btn_delete_order.Click += btn_delete_order_Click;
            // 
            // lbl_getorders
            // 
            lbl_getorders.AutoSize = true;
            lbl_getorders.BackColor = Color.WhiteSmoke;
            lbl_getorders.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_getorders.Location = new Point(519, 165);
            lbl_getorders.Name = "lbl_getorders";
            lbl_getorders.Size = new Size(207, 23);
            lbl_getorders.TabIndex = 3;
            lbl_getorders.Text = "Get orders by customer id";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.White;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(497, 191);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(83, 28);
            comboBox1.TabIndex = 4;
            // 
            // btn_show
            // 
            btn_show.BackColor = Color.MediumSeaGreen;
            btn_show.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_show.ForeColor = SystemColors.ButtonHighlight;
            btn_show.Location = new Point(586, 191);
            btn_show.Name = "btn_show";
            btn_show.Size = new Size(75, 30);
            btn_show.TabIndex = 5;
            btn_show.Text = "Show";
            btn_show.UseVisualStyleBackColor = false;
            btn_show.Click += btn_show_Click;
            // 
            // btn_exit
            // 
            btn_exit.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_exit.ForeColor = Color.Red;
            btn_exit.Location = new Point(718, 12);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(35, 32);
            btn_exit.TabIndex = 13;
            btn_exit.Text = "x";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // btn_back
            // 
            btn_back.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn_back.Location = new Point(676, 12);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(36, 32);
            btn_back.TabIndex = 14;
            btn_back.Text = "⬅";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // cb_status
            // 
            cb_status.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cb_status.FormattingEnabled = true;
            cb_status.Items.AddRange(new object[] { "Received", "Preparing", "On the way", "Delivered" });
            cb_status.Location = new Point(549, 298);
            cb_status.Name = "cb_status";
            cb_status.Size = new Size(149, 28);
            cb_status.TabIndex = 15;
            // 
            // tb_confirm
            // 
            tb_confirm.BackColor = Color.DarkTurquoise;
            tb_confirm.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tb_confirm.Location = new Point(575, 332);
            tb_confirm.Name = "tb_confirm";
            tb_confirm.Size = new Size(91, 30);
            tb_confirm.TabIndex = 17;
            tb_confirm.Text = "Confirm";
            tb_confirm.UseVisualStyleBackColor = false;
            tb_confirm.Click += tb_confirm_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(528, 270);
            label2.Name = "label2";
            label2.Size = new Size(184, 25);
            label2.TabIndex = 18;
            label2.Text = "Set status for orders";
            // 
            // Orders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(765, 475);
            Controls.Add(label2);
            Controls.Add(tb_confirm);
            Controls.Add(cb_status);
            Controls.Add(btn_back);
            Controls.Add(btn_exit);
            Controls.Add(btn_show);
            Controls.Add(comboBox1);
            Controls.Add(lbl_getorders);
            Controls.Add(btn_delete_order);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Orders";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Orders";
            Load += Orders_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button btn_delete_order;
        private Label lbl_getorders;
        private ComboBox comboBox1;
        private Button btn_show;
        private Button btn_exit;
        private Button btn_back;
        private ComboBox cb_status;
        private Button tb_confirm;
        private Label label2;
    }
}