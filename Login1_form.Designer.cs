namespace User2
{
    partial class Login1_form
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
            UserTbox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            RegisterBTn = new Button();
            PassTbox = new TextBox();
            LoginBtn = new Button();
            SuspendLayout();
            // 
            // UserTbox
            // 
            UserTbox.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            UserTbox.Location = new Point(406, 84);
            UserTbox.Name = "UserTbox";
            UserTbox.Size = new Size(307, 39);
            UserTbox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Lime;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(183, 91);
            label1.Name = "label1";
            label1.Size = new Size(174, 32);
            label1.TabIndex = 1;
            label1.Text = "USERNAME";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(128, 255, 255);
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(185, 184);
            label2.Name = "label2";
            label2.Size = new Size(172, 32);
            label2.TabIndex = 2;
            label2.Text = "PASSWORD";
            // 
            // RegisterBTn
            // 
            RegisterBTn.BackColor = Color.DeepPink;
            RegisterBTn.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            RegisterBTn.Location = new Point(347, 300);
            RegisterBTn.Name = "RegisterBTn";
            RegisterBTn.Size = new Size(211, 53);
            RegisterBTn.TabIndex = 3;
            RegisterBTn.Text = "REGISTER";
            RegisterBTn.UseVisualStyleBackColor = false;
            RegisterBTn.Click += RegisterBTn_Click;
            // 
            // PassTbox
            // 
            PassTbox.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            PassTbox.Location = new Point(406, 177);
            PassTbox.Name = "PassTbox";
            PassTbox.Size = new Size(307, 39);
            PassTbox.TabIndex = 4;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.RoyalBlue;
            LoginBtn.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            LoginBtn.Location = new Point(597, 300);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(144, 53);
            LoginBtn.TabIndex = 5;
            LoginBtn.Text = "LOGIN";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // Login1_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Violet;
            ClientSize = new Size(800, 450);
            Controls.Add(LoginBtn);
            Controls.Add(PassTbox);
            Controls.Add(RegisterBTn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(UserTbox);
            Name = "Login1_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login1_form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UserTbox;
        private Label label1;
        private Label label2;
        private Button RegisterBTn;
        private TextBox PassTbox;
        private Button LoginBtn;
    }
}