namespace CombHomework1
{
    public partial class Form1 : Form
    {
        CombinationGenerator generator = new CombinationGenerator();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            generator.K = int.Parse(textBox2.Text);
            
            if (int.Parse(textBox2.Text) <= 1) {
                textBox1.AppendText($"Please enter value again to K >1");

                return;
            }
            
            textBox1.AppendText($"Entered value for K is {textBox2.Text}" + Environment.NewLine);
        }

      
        private void button3_Click(object sender, EventArgs e)
        {
            
            generator.Combinations(textBox1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            generator.AddElemets(textBox3.Text);
            
            textBox1.AppendText($"Entered value for the element is {textBox3.Text}"+Environment.NewLine);
        }
    }
}
