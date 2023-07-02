namespace frmPurchaseDiscountItem_1
{
    public partial class frmDisplay : Form
    {
        string name;
        double discount;
        double price;
        int quantity;
        int payment;
        
        public frmDisplay()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DiscountedItem i = new DiscountedItem(name, price, quantity, discount);
            i.setPayment(payment);
            Change.Text = i.getChange().ToString();

        }

        private void Compute_Click(object sender, EventArgs e)
        {
            name = Item_1.Text;
            price = Convert.ToDouble(Price_1.Text);
            discount = Convert.ToDouble(Discount_1.Text);
            payment = Convert.ToInt32(Recieve.Text);
            quantity = Convert.ToInt32(Quantity_1.Text);

            DiscountedItem i = new DiscountedItem(name,price,quantity,discount);
            Total_1.Text = i.getTotalPrice().ToString();
        }

        private void Item_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
    public class DiscountedItem : Item
    {
        private double item_discount;
        private double discounted_price;
        private double payment_amount;
        private double change;
        public DiscountedItem()
        {

        }

        public DiscountedItem(string name, double price, int quantity, double discount) : base(name, price, quantity)
        {
            this.item_discount = discount;

        }
        public  double getTotalPrice()
        {
            discounted_price = (item_price * item_quantity) - ((item_discount * 0.01) * (item_price * item_quantity));
            return discounted_price;
        }
   
        public void setPayment(double amount)
        {
            this.payment_amount = amount;
        }

        public double getChange()
        {
            change = payment_amount - ((item_price * item_quantity) - ((item_discount * 0.01) * (item_price * item_quantity)));
            return change;
        }
    }

    public class Item
    {
        protected string item_name;
        protected double item_price;
        protected int item_quantity;
        protected double total_amount;
        public Item()
        {

        }
        
        public Item(string name,double price,int quantity)
        {
            this.item_name = name;
            this.item_price = price;
            this.item_quantity = quantity;
        }

        public double getTotalPrice()
        {
            return this.total_amount;
        }

        public void setPayment(double amount)
        {
           amount = item_price * total_amount;
        }
    }
}