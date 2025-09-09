namespace Multiforms_event_CRUZ
{
    partial class Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            panel1 = new Panel();
            panel3 = new Panel();
            num_qtyp = new NumericUpDown();
            label6 = new Label();
            btn_clear = new Button();
            btn_addpastry = new Button();
            cb_pastry = new ComboBox();
            label4 = new Label();
            btn_adddrink = new Button();
            label2 = new Label();
            num_qty = new NumericUpDown();
            label3 = new Label();
            cb_size = new ComboBox();
            Type = new Label();
            cb_drink = new ComboBox();
            label1 = new Label();
            cb_type = new ComboBox();
            panel2 = new Panel();
            txt_sum = new TextBox();
            txt_total = new TextBox();
            label5 = new Label();
            label7 = new Label();
            btn_next = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_qtyp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_qty).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(12, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 536);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 192, 192);
            panel3.Controls.Add(num_qtyp);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(btn_clear);
            panel3.Controls.Add(btn_addpastry);
            panel3.Controls.Add(cb_pastry);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(btn_adddrink);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(num_qty);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(cb_size);
            panel3.Controls.Add(Type);
            panel3.Controls.Add(cb_drink);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(cb_type);
            panel3.Location = new Point(436, 36);
            panel3.Name = "panel3";
            panel3.Size = new Size(280, 464);
            panel3.TabIndex = 0;
            // 
            // num_qtyp
            // 
            num_qtyp.Location = new Point(133, 287);
            num_qtyp.Name = "num_qtyp";
            num_qtyp.Size = new Size(120, 23);
            num_qtyp.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Noto Sans KR", 9.75F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(22, 286);
            label6.Name = "label6";
            label6.Size = new Size(64, 19);
            label6.TabIndex = 13;
            label6.Text = "Quantity";
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.FromArgb(92, 152, 128);
            btn_clear.FlatAppearance.BorderSize = 0;
            btn_clear.FlatStyle = FlatStyle.Flat;
            btn_clear.Font = new Font("Noto Sans KR Medium", 9.75F, FontStyle.Bold);
            btn_clear.Location = new Point(10, 415);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(104, 29);
            btn_clear.TabIndex = 12;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_addpastry
            // 
            btn_addpastry.BackColor = Color.FromArgb(92, 152, 128);
            btn_addpastry.FlatAppearance.BorderSize = 0;
            btn_addpastry.FlatStyle = FlatStyle.Flat;
            btn_addpastry.Font = new Font("Noto Sans KR Medium", 9.75F, FontStyle.Bold);
            btn_addpastry.Location = new Point(104, 320);
            btn_addpastry.Name = "btn_addpastry";
            btn_addpastry.Size = new Size(90, 29);
            btn_addpastry.TabIndex = 11;
            btn_addpastry.Text = "Add Pastry";
            btn_addpastry.UseVisualStyleBackColor = false;
            btn_addpastry.Click += btn_addpastry_Click;
            // 
            // cb_pastry
            // 
            cb_pastry.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_pastry.FlatStyle = FlatStyle.Flat;
            cb_pastry.FormattingEnabled = true;
            cb_pastry.Items.AddRange(new object[] { "(--Select Pastry--)", "Choco Donut", "Sticky Cinnamon", "Pizza Slice", "Ham and Cheese Sandwich", "Chip Cookies", "Sliced Cake" });
            cb_pastry.Location = new Point(132, 252);
            cb_pastry.Name = "cb_pastry";
            cb_pastry.Size = new Size(121, 23);
            cb_pastry.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Noto Sans KR", 9.75F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(22, 252);
            label4.Name = "label4";
            label4.Size = new Size(50, 19);
            label4.TabIndex = 9;
            label4.Text = "Pastry";
            // 
            // btn_adddrink
            // 
            btn_adddrink.BackColor = Color.FromArgb(92, 152, 128);
            btn_adddrink.FlatAppearance.BorderSize = 0;
            btn_adddrink.FlatStyle = FlatStyle.Flat;
            btn_adddrink.Font = new Font("Noto Sans KR Medium", 9.75F, FontStyle.Bold);
            btn_adddrink.Location = new Point(104, 202);
            btn_adddrink.Name = "btn_adddrink";
            btn_adddrink.Size = new Size(90, 29);
            btn_adddrink.TabIndex = 8;
            btn_adddrink.Text = "Add Drink";
            btn_adddrink.UseVisualStyleBackColor = false;
            btn_adddrink.Click += btn_adddrink_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Noto Sans KR", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(22, 116);
            label2.Name = "label2";
            label2.Size = new Size(36, 19);
            label2.TabIndex = 7;
            label2.Text = "Size";
            // 
            // num_qty
            // 
            num_qty.Location = new Point(132, 160);
            num_qty.Name = "num_qty";
            num_qty.Size = new Size(120, 23);
            num_qty.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Noto Sans KR", 9.75F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(22, 159);
            label3.Name = "label3";
            label3.Size = new Size(64, 19);
            label3.TabIndex = 5;
            label3.Text = "Quantity";
            // 
            // cb_size
            // 
            cb_size.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_size.FlatStyle = FlatStyle.Flat;
            cb_size.FormattingEnabled = true;
            cb_size.Items.AddRange(new object[] { "(--Select Size--)", "Tall", "Grande", "Venti" });
            cb_size.Location = new Point(132, 116);
            cb_size.Name = "cb_size";
            cb_size.Size = new Size(121, 23);
            cb_size.TabIndex = 4;
            // 
            // Type
            // 
            Type.AutoSize = true;
            Type.Font = new Font("Noto Sans KR", 9.75F, FontStyle.Bold);
            Type.ForeColor = Color.White;
            Type.Location = new Point(22, 80);
            Type.Name = "Type";
            Type.Size = new Size(44, 19);
            Type.TabIndex = 3;
            Type.Text = "Drink";
            // 
            // cb_drink
            // 
            cb_drink.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_drink.FlatStyle = FlatStyle.Flat;
            cb_drink.FormattingEnabled = true;
            cb_drink.Items.AddRange(new object[] { "(--Select  Beverage--)", "Mocha", "Cappuccino", "Coffee", "Java Chip" });
            cb_drink.Location = new Point(132, 80);
            cb_drink.Name = "cb_drink";
            cb_drink.Size = new Size(121, 23);
            cb_drink.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Noto Sans KR", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(22, 40);
            label1.Name = "label1";
            label1.Size = new Size(104, 19);
            label1.TabIndex = 1;
            label1.Text = "Beverage Type";
            // 
            // cb_type
            // 
            cb_type.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_type.FlatStyle = FlatStyle.Flat;
            cb_type.FormattingEnabled = true;
            cb_type.Items.AddRange(new object[] { "(--Select Type--)", "Frappe", "Hot" });
            cb_type.Location = new Point(132, 40);
            cb_type.Name = "cb_type";
            cb_type.Size = new Size(121, 23);
            cb_type.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(txt_sum);
            panel2.Location = new Point(827, 52);
            panel2.Name = "panel2";
            panel2.Size = new Size(280, 480);
            panel2.TabIndex = 1;
            // 
            // txt_sum
            // 
            txt_sum.BackColor = Color.White;
            txt_sum.BorderStyle = BorderStyle.None;
            txt_sum.Location = new Point(3, 16);
            txt_sum.Multiline = true;
            txt_sum.Name = "txt_sum";
            txt_sum.ReadOnly = true;
            txt_sum.Size = new Size(274, 448);
            txt_sum.TabIndex = 0;
            // 
            // txt_total
            // 
            txt_total.BackColor = Color.White;
            txt_total.Location = new Point(872, 545);
            txt_total.Name = "txt_total";
            txt_total.ReadOnly = true;
            txt_total.Size = new Size(100, 23);
            txt_total.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(824, 545);
            label5.Name = "label5";
            label5.Size = new Size(42, 21);
            label5.TabIndex = 6;
            label5.Text = "Total";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Noto Sans KR", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(911, 10);
            label7.Name = "label7";
            label7.Size = new Size(108, 39);
            label7.TabIndex = 7;
            label7.Text = "Orders";
            // 
            // btn_next
            // 
            btn_next.BackColor = Color.FromArgb(255, 192, 192);
            btn_next.FlatAppearance.BorderSize = 0;
            btn_next.FlatStyle = FlatStyle.Flat;
            btn_next.Font = new Font("Noto Sans KR Medium", 9.75F, FontStyle.Bold);
            btn_next.Location = new Point(1000, 542);
            btn_next.Name = "btn_next";
            btn_next.Size = new Size(104, 29);
            btn_next.TabIndex = 13;
            btn_next.Text = "Submit";
            btn_next.UseVisualStyleBackColor = false;
            btn_next.Click += btn_next_Click;
            // 
            // Order
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(92, 152, 128);
            ClientSize = new Size(1124, 594);
            Controls.Add(btn_next);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(txt_total);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = Color.White;
            Name = "Order";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Order";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_qtyp).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_qty).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel3;
        private Label label2;
        private Label label5;
        private Label label7;
        public TextBox txt_sum;
        public TextBox txt_total;
        public Panel panel2;
        public Panel panel1;
        public NumericUpDown num_qty;
        public Label label3;
        public ComboBox cb_size;
        public Label Type;
        public ComboBox cb_drink;
        public Label label1;
        public ComboBox cb_type;
        public Button btn_adddrink;
        public Button btn_addpastry;
        public ComboBox cb_pastry;
        public Label label4;
        public Button btn_clear;
        public NumericUpDown num_qtyp;
        public Label label6;
        public Button btn_next;
    }
}