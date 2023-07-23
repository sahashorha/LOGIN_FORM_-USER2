namespace User2
{
    partial class Register_form
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
            RegisterBTn = new Button();
            label2 = new Label();
            NameTbox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            PassTbox = new TextBox();
            label5 = new Label();
            label6 = new Label();
            GenderCbox = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            Registration = new Label();
            SuspendLayout();
            // 
            // UserTbox
            // 
            UserTbox.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            UserTbox.Location = new Point(386, 106);
            UserTbox.Name = "UserTbox";
            UserTbox.Size = new Size(307, 39);
            UserTbox.TabIndex = 10;
            // 
            // RegisterBTn
            // 
            RegisterBTn.BackColor = Color.Fuchsia;
            RegisterBTn.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            RegisterBTn.Location = new Point(640, 538);
            RegisterBTn.Name = "RegisterBTn";
            RegisterBTn.Size = new Size(211, 53);
            RegisterBTn.TabIndex = 9;
            RegisterBTn.Text = "REGISTER";
            RegisterBTn.UseVisualStyleBackColor = false;
            RegisterBTn.Click += RegisterBTn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 192, 192);
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(118, 113);
            label2.Name = "label2";
            label2.Size = new Size(174, 32);
            label2.TabIndex = 8;
            label2.Text = "USERNAME";
            // 
            // NameTbox
            // 
            NameTbox.BackColor = Color.GhostWhite;
            NameTbox.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            NameTbox.Location = new Point(386, 294);
            NameTbox.Name = "NameTbox";
            NameTbox.Size = new Size(307, 39);
            NameTbox.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(192, 255, 255);
            label3.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(128, 301);
            label3.Name = "label3";
            label3.Size = new Size(99, 32);
            label3.TabIndex = 14;
            label3.Text = "NAME";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.YellowGreen;
            label4.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(118, 218);
            label4.Name = "label4";
            label4.Size = new Size(163, 32);
            label4.TabIndex = 13;
            label4.Text = "PASSCODE";
            // 
            // PassTbox
            // 
            PassTbox.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            PassTbox.Location = new Point(386, 201);
            PassTbox.Name = "PassTbox";
            PassTbox.Size = new Size(307, 39);
            PassTbox.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(255, 128, 0);
            label5.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(118, 464);
            label5.Name = "label5";
            label5.Size = new Size(231, 32);
            label5.TabIndex = 18;
            label5.Text = "DATE OF BIRTH";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(0, 192, 192);
            label6.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(118, 371);
            label6.Name = "label6";
            label6.Size = new Size(134, 32);
            label6.TabIndex = 17;
            label6.Text = "GENDER";
            // 
            // GenderCbox
            // 
            GenderCbox.BackColor = SystemColors.HighlightText;
            GenderCbox.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            GenderCbox.FormattingEnabled = true;
            GenderCbox.Items.AddRange(new object[] { "MALE", "FEMALE", "OTHER" });
            GenderCbox.Location = new Point(386, 368);
            GenderCbox.Name = "GenderCbox";
            GenderCbox.Size = new Size(307, 39);
            GenderCbox.TabIndex = 19;
            GenderCbox.Text = "MALE";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(386, 464);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(307, 39);
            dateTimePicker1.TabIndex = 20;
            // 
            // Registration
            // 
            Registration.AutoSize = true;
            Registration.BackColor = Color.FromArgb(128, 255, 255);
            Registration.Font = new Font("Lucida Handwriting", 24F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            Registration.Location = new Point(210, 20);
            Registration.Name = "Registration";
            Registration.Size = new Size(469, 52);
            Registration.TabIndex = 21;
            Registration.Text = "Registration  Form";
            // 
            // Register_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(1011, 715);
            Controls.Add(Registration);
            Controls.Add(dateTimePicker1);
            Controls.Add(GenderCbox);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(NameTbox);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(PassTbox);
            Controls.Add(UserTbox);
            Controls.Add(RegisterBTn);
            Controls.Add(label2);
            Name = "Register_form";
            Text = "Register_form";
            Load += Register_form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox UserTbox;
        private Button RegisterBTn;
        private Label label2;
        private TextBox NameTbox;
        private Label label3;
        private Label label4;
        private TextBox PassTbox;
        private Label label5;
        private Label label6;
        private ComboBox GenderCbox;
        private DateTimePicker dateTimePicker1;
        private Label Registration;
    }
}