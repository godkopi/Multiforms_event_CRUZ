namespace Multiforms_event_CRUZ
{
    partial class Payment
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
            panel1 = new Panel();
            btn_close = new Button();
            btn_pay = new Button();
            label2 = new Label();
            txt_change = new TextBox();
            label1 = new Label();
            txt_payment = new TextBox();
            label5 = new Label();
            txt_total = new TextBox();
            label7 = new Label();
            panel2 = new Panel();
            txt_cus = new TextBox();
            txt_sum2 = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(92, 152, 128);
            panel1.Controls.Add(btn_close);
            panel1.Controls.Add(btn_pay);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txt_change);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txt_payment);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txt_total);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(35, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(537, 457);
            panel1.TabIndex = 0;
            // 
            // btn_close
            // 
            btn_close.BackColor = Color.FromArgb(255, 192, 192);
            btn_close.FlatAppearance.BorderSize = 0;
            btn_close.FlatStyle = FlatStyle.Flat;
            btn_close.Font = new Font("Noto Sans KR", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_close.ForeColor = Color.White;
            btn_close.Location = new Point(370, 381);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(114, 46);
            btn_close.TabIndex = 17;
            btn_close.Text = "Close";
            btn_close.UseVisualStyleBackColor = false;
            btn_close.Click += btn_close_Click;
            // 
            // btn_pay
            // 
            btn_pay.BackColor = Color.FromArgb(255, 192, 192);
            btn_pay.FlatAppearance.BorderSize = 0;
            btn_pay.FlatStyle = FlatStyle.Flat;
            btn_pay.Font = new Font("Noto Sans KR", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_pay.ForeColor = Color.White;
            btn_pay.Location = new Point(370, 149);
            btn_pay.Name = "btn_pay";
            btn_pay.Size = new Size(114, 46);
            btn_pay.TabIndex = 16;
            btn_pay.Text = "Checkout";
            btn_pay.UseVisualStyleBackColor = false;
            btn_pay.Click += btn_pay_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Noto Sans KR", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(324, 107);
            label2.Name = "label2";
            label2.Size = new Size(67, 24);
            label2.TabIndex = 15;
            label2.Text = "Change";
            // 
            // txt_change
            // 
            txt_change.BackColor = Color.White;
            txt_change.Location = new Point(407, 107);
            txt_change.Name = "txt_change";
            txt_change.ReadOnly = true;
            txt_change.Size = new Size(100, 23);
            txt_change.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Noto Sans KR", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(324, 78);
            label1.Name = "label1";
            label1.Size = new Size(76, 24);
            label1.TabIndex = 13;
            label1.Text = "Payment";
            // 
            // txt_payment
            // 
            txt_payment.BackColor = Color.White;
            txt_payment.Location = new Point(407, 78);
            txt_payment.Name = "txt_payment";
            txt_payment.Size = new Size(100, 23);
            txt_payment.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Noto Sans KR", 12F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(324, 49);
            label5.Name = "label5";
            label5.Size = new Size(49, 24);
            label5.TabIndex = 11;
            label5.Text = "Total";
            // 
            // txt_total
            // 
            txt_total.BackColor = Color.White;
            txt_total.Location = new Point(407, 49);
            txt_total.Name = "txt_total";
            txt_total.ReadOnly = true;
            txt_total.Size = new Size(100, 23);
            txt_total.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Noto Sans KR", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(62, 4);
            label7.Name = "label7";
            label7.Size = new Size(146, 39);
            label7.TabIndex = 9;
            label7.Text = "Summary";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(txt_cus);
            panel2.Controls.Add(txt_sum2);
            panel2.Location = new Point(21, 46);
            panel2.Name = "panel2";
            panel2.Size = new Size(264, 384);
            panel2.TabIndex = 8;
            // 
            // txt_cus
            // 
            txt_cus.BackColor = Color.White;
            txt_cus.BorderStyle = BorderStyle.None;
            txt_cus.Location = new Point(3, 3);
            txt_cus.Multiline = true;
            txt_cus.Name = "txt_cus";
            txt_cus.ReadOnly = true;
            txt_cus.Size = new Size(258, 50);
            txt_cus.TabIndex = 1;
            // 
            // txt_sum2
            // 
            txt_sum2.BackColor = Color.White;
            txt_sum2.BorderStyle = BorderStyle.None;
            txt_sum2.Location = new Point(3, 52);
            txt_sum2.Multiline = true;
            txt_sum2.Name = "txt_sum2";
            txt_sum2.ReadOnly = true;
            txt_sum2.Size = new Size(258, 329);
            txt_sum2.TabIndex = 0;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 153, 153);
            ClientSize = new Size(607, 517);
            Controls.Add(panel1);
            Name = "Payment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Payment";
            Load += Payment_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label7;
        private Panel panel2;
        public TextBox txt_sum2;
        public Panel panel1;
        private Label label5;
        public TextBox txt_total;
        private Label label1;
        public TextBox txt_payment;
        private Label label2;
        public TextBox txt_change;
        private Button btn_pay;
        public TextBox txt_cus;
        private Button btn_close;
    }
}