using HMS_Automation.Test.Cases;
using OpenQA.Selenium;

namespace HMS_Automation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string enteredUsername = textBox1.Text;
            string enteredPassword = textBox2.Text;


            Login_Page login_Page = new Login_Page();
            if (comboBox1.Text == "Google Chrome")
            {
                var result = CreateDriver.GetChromeDriver();
                login_Page.login(enteredUsername, enteredPassword, result);                                            // Use 'result' as needed
            }
            /*if (comboBox1.Text == "Edge")
            {
                var result=CreateDriver.GetEdgeDriver;
                login_Page.login(enteredUsername, enteredPassword, result);
            }
            if (comboBox1.Text == "Firefox")
            {
               var result = CreateDriver.GetFireFoxDriver;
                login_Page.login(enteredUsername, enteredPassword, result);
            }
            if (comboBox1.Text == "IE")
            {
             var result=CreateDriver.GetIEDriver;
                login_Page.login(enteredUsername, enteredPassword, result);
            }*/



            if (IsValidCredentials(enteredUsername, enteredPassword))
            {

                // Valid credentials, close this form and show the next one
                this.Hide(); // Hide the login form
                             //NextForm nextForm = new NextForm();
                             // nextForm.ShowDialog(); // Show the next form as a dialog
                this.Close(); // Close the login form
            }
            else
            {
                // Invalid credentials, display an error message
                MessageBox.Show("Invalid username or password. Please try again.");
            }

        }
        private bool IsValidCredentials(string username, string password)
        {
            // Define a list of valid usernames and corresponding passwords
            Dictionary<string, string> validCredentials = new Dictionary<string, string>
            {
                {"user1", "password1"},
                {"user2", "password2"},
        // Add more valid credentials as needed
            };

            // Check if the entered username exists in the valid credentials dictionary
            if (validCredentials.ContainsKey(username))
            {
                // If the username exists, check if the entered password matches
                string storedPassword = validCredentials[username];
                if (password == storedPassword)
                {
                    // Username and password are valid
                    return true;
                }
            }

            // If no match was found or the password is incorrect, return false
            return false;
        }




        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "Select Browser";
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}