namespace StudentProfile
{
    partial class Form1
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
            label1 = new Label();
            labelCurrent = new Label();
            txtPhone = new TextBox();
            btnSave = new Button();
            lblMessage = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(360, 37);
            label1.TabIndex = 0;
            label1.Text = "Student Profile — Emergency";
            // 
            // labelCurrent
            // 
            labelCurrent.AutoSize = true;
            labelCurrent.Location = new Point(25, 80);
            labelCurrent.Name = "labelCurrent";
            labelCurrent.Size = new Size(200, 15);
            labelCurrent.TabIndex = 1;
            labelCurrent.Text = "Current emergency contact: (not set)";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(25, 120);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(200, 23);
            txtPhone.TabIndex = 2;
            txtPhone.PlaceholderText = "+639XXXXXXXXX";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(240, 120);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 25);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.ForeColor = Color.Red;
            lblMessage.Location = new Point(25, 155);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 15);
            lblMessage.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 220);
            Controls.Add(label1);
            Controls.Add(labelCurrent);
            Controls.Add(txtPhone);
            Controls.Add(btnSave);
            Controls.Add(lblMessage);
            Name = "Form1";
            Text = "Student Profile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelCurrent;
        private TextBox txtPhone;
        private Button btnSave;
        private Label lblMessage;
    }
}
