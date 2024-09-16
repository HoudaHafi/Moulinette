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
            var reason = "Le texte et le mot ne sont pas de la m�me longueur.";
            if (textBox1.Text.Length == textBox2.Text.Length)
            {
                for (; i < textBox2.Text.Length; i++)
                {
                    reason = $"(Caract�re {i})";
                    richTextBox2.Text += $"Caract�re {i}";
                    if (textBox2.Text[i] != textBox1.Text[i])
                    {
                        richTextBox2.Text += $" : NOT OK\n";
                        break;
                    }
                    richTextBox2.Text += $" : OK\n";
                }
                if (i == textBox2.Text.Length)
                {
                    MessageBox.Show(caption: "Accept�", text: "Le mot est accept�.", icon: MessageBoxIcon.Asterisk, buttons: MessageBoxButtons.OK);
                    return;
                }
            }
            MessageBox.Show(caption: "Refus�", text: $"Le mot est refus�. {reason}", icon: MessageBoxIcon.Stop, buttons: MessageBoxButtons.OK);
        }
    }
}