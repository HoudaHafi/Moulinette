namespace Moulinette
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text = "Moulinette";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
            int i = 0;
            var reason = "Le texte et le mot ne sont pas de la même longueur.";
            if (textBox1.Text.Length == textBox2.Text.Length)
            {
                for (; i < textBox2.Text.Length; i++)
                {
                    reason = $"(Caractère {i})";
                    richTextBox2.Text += $"Caractère {i}";
                    if (textBox2.Text[i] != textBox1.Text[i])
                    {
                        richTextBox2.Text += $" : NOT OK\n";
                        break;
                    }
                    richTextBox2.Text += $" : OK\n";
                }
                if (i == textBox2.Text.Length)
                {
                    MessageBox.Show(caption: "Accepté", text: "Le mot est accepté.", icon: MessageBoxIcon.Asterisk, buttons: MessageBoxButtons.OK);
                    return;
                }
            }
            MessageBox.Show(caption: "Refusé", text: $"Le mot est refusé. {reason}", icon: MessageBoxIcon.Stop, buttons: MessageBoxButtons.OK);
        }
    }
}