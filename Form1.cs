namespace js2gumjs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            text = text.Replace("\"", "'");
            string[] lines = text.Split('\n');
            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = $"\"{lines[i].TrimEnd()}\\n\"";
            }
            text = string.Join("\r\n", lines);
            textBox2.Text = text;
        }
    }
}