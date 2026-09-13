using System.Text.RegularExpressions;
using System.Drawing;

namespace StudentProfile
{
    public partial class Form1 : Form
    {
        // stores the current emergency contact phone number
        private string currentPhone = "+639123456789"; // example initial value

        public Form1()
        {
            InitializeComponent();
            // show current phone on load
            labelCurrent.Text = $"Current emergency contact: {currentPhone}";
            // set the AcceptButton so Enter triggers save
            AcceptButton = btnSave;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            lblMessage.ForeColor = Color.Red;
            var input = txtPhone.Text?.Trim() ?? string.Empty;

            if (string.IsNullOrEmpty(input))
            {
                lblMessage.Text = "Phone number is required.";
                return;
            }

            // Validate +63 followed by exactly 10 digits (e.g. +639123456789)
            var pattern = "^\\+63\\d{10}$";
            if (!Regex.IsMatch(input, pattern))
            {
                lblMessage.Text = "Invalid phone format. Use +63 followed by 10 digits, e.g. +639123456789.";
                return;
            }

            // success
            currentPhone = input;
            labelCurrent.Text = $"Current emergency contact: {currentPhone}";
            lblMessage.ForeColor = Color.Green;
            lblMessage.Text = "Emergency contact updated successfully.";
        }
    }
}
