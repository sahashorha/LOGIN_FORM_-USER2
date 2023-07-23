namespace User2
{
    partial class AppForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppForm));
            imageList1 = new ImageList(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "HD-wallpaper-har-har-mahadev-trishul-shiv-thumbnail.jpg");
            imageList1.Images.SetKeyName(1, "HD-wallpaper-mahadev-ganesha-god-har-har-mahadev-mahakal-sayings-shankara-shivay.jpg");
            imageList1.Images.SetKeyName(2, "HD-wallpaper-mahadev-ganesha-god-har-har-mahadev-shankara-shiva-shivay-symbol-thumbnail.jpg");
            imageList1.Images.SetKeyName(3, "HD-wallpaper-mahadev-har-har-mahadev-lord-lord-shiv-lord-shiva-mahadec-shiji-shiv-shiva-shivay-thumbnail.jpg");
            imageList1.Images.SetKeyName(4, "HD-wallpaper-mahadev-har-har-mahadev-lord-shiva-mahadev-mahadeva-shiv-shivji-thumbnail.jpg");
            imageList1.Images.SetKeyName(5, "HD-wallpaper-mahadev-shiva-god-shivan-thumbnail.jpg");
            imageList1.Images.SetKeyName(6, "HD-wallpaper-mahadev-shiva-god-sulam-shivan-thumbnail.jpg");
            imageList1.Images.SetKeyName(7, "HD-wallpaper-mahadev-shiva-shiv-shivan-thumbnail.jpg");
            imageList1.Images.SetKeyName(8, "HD-wallpaper-har-har-mahadev-trishul-shiv-thumbnail.jpg");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Yellow;
            label1.Font = new Font("Lucida Handwriting", 48F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(13, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(1282, 104);
            label1.TabIndex = 0;
            label1.Text = "Welcome To The HomePage";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LavenderBlush;
            label2.Font = new Font("Lucida Handwriting", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.Location = new Point(57, 244);
            label2.Name = "label2";
            label2.Size = new Size(1166, 29);
            label2.TabIndex = 1;
            label2.Text = "\"Success is not final; failure is not fatal: It is the courage to continue that counts.\"";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Lime;
            label3.Font = new Font("Lucida Handwriting", 25.8000011F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label3.Location = new Point(457, 447);
            label3.Name = "label3";
            label3.Size = new Size(387, 57);
            label3.TabIndex = 2;
            label3.Text = "Thank You !!!!";
            // 
            // AppForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Fuchsia;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1315, 597);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Lucida Handwriting", 10.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "AppForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AppForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ImageList imageList1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}