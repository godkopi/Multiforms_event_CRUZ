namespace Multiforms_event_CRUZ
{
    partial class Landing_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Landing_Page));
            button1 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(92, 152, 128);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(440, 492);
            button1.Name = "button1";
            button1.Size = new Size(133, 49);
            button1.TabIndex = 1;
            button1.TabStop = false;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            // 
            // Landing_Page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(984, 594);
            Controls.Add(button1);
            DoubleBuffered = true;
            ForeColor = SystemColors.Control;
            Name = "Landing_Page";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Landing Page";
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
    }
}
