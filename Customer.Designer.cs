namespace Multiforms_event_CRUZ
{
    partial class Customer
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
            dateTimePicker1 = new DateTimePicker();
            cb_ct = new ComboBox();
            txt_name = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(92, 152, 128);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(cb_ct);
            panel1.Controls.Add(txt_name);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(77, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(435, 215);
            panel1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(225, 160);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(182, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // cb_ct
            // 
            cb_ct.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_ct.FlatStyle = FlatStyle.Flat;
            cb_ct.FormattingEnabled = true;
            cb_ct.Items.AddRange(new object[] { "(Select Customer Type)", "Student", "Regular", "VIP" });
            cb_ct.Location = new Point(225, 104);
            cb_ct.Name = "cb_ct";
            cb_ct.Size = new Size(182, 23);
            cb_ct.TabIndex = 4;
            // 
            // txt_name
            // 
            txt_name.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_name.Location = new Point(225, 32);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(182, 27);
            txt_name.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Noto Sans KR", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(30, 153);
            label3.Name = "label3";
            label3.Size = new Size(128, 30);
            label3.TabIndex = 2;
            label3.Text = "Date Stamp";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Noto Sans KR", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(30, 95);
            label2.Name = "label2";
            label2.Size = new Size(162, 30);
            label2.TabIndex = 1;
            label2.Text = "Customer Type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Noto Sans KR", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 29);
            label1.Name = "label1";
            label1.Size = new Size(172, 30);
            label1.TabIndex = 0;
            label1.Text = "Customer Name";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(92, 152, 128);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(227, 324);
            button1.Name = "button1";
            button1.Size = new Size(133, 49);
            button1.TabIndex = 2;
            button1.TabStop = false;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(589, 424);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "Customer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        public Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
        public ComboBox cb_ct;
        public TextBox txt_name;
        public DateTimePicker dateTimePicker1;
    }
}