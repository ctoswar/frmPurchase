using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmPurchaseDiscountItem_1
{
    public partial class Form2 : Form
    {
        string name;
        string uName;
        string password;
        
        public Form2()
        {
            InitializeComponent();
        }

       
        private void Form2_Load(object sender, EventArgs e)
        {
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserAccount user = new UserAccount(name,uName,password);
            uName = uName1.Text.ToString();
            password = pass1.Text.ToString();
            this.Hide();
            user.ValidateLogin(uName,password);
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public class UserAccount
    {
        private string full_name;
        protected string user_name;
        protected string user_password;

        public UserAccount() {
        
        }
        public UserAccount(string name, string uName, string password)
        {
            this.full_name = name;
            this.user_name = uName;
            this.user_password = password;
        }
        public  bool ValidateLogin(string uName, string password)
        {
            if (uName == "JulieAnn")
            {
                if (password == "password")
                {
                    new frmDisplay().Show();
                    MessageBox.Show(getFullName());
                }
                else
                {
                    MessageBox.Show("No account available on with this username and passoword");
                    new Form2().Show();
                }
               return base.Equals(password);
            }
            else
            {
                MessageBox.Show("No account available on with this username and passoword");
                new Form2().Show();
            }
           
            return base.Equals(uName);
        }
        public string getFullName()
        {
            full_name = "welcome back! Julie Ann!";
            return full_name;
        }
      
    }

    public class Cashier : UserAccount
    {
        private string department;

        public Cashier()
        {

        }

        public Cashier(string name, string department, string uName,string password) : base(name, uName, password)
        {
            this.department = department;
        }

        public bool validateLogin(string uName, string password)
        {
            if(this.user_name.Equals(uName)&&this.user_password.Equals(password)) {
                MessageBox.Show(getDepartment());
                return true;
            }
            else
            {
                return false;
            }
        }

        public string getDepartment()
        {
            return this.department;
        }
    }
    
}
