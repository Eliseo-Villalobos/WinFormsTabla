namespace WinFormsTabla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonver_Click(object sender, EventArgs e)
        {
            this.muestraTabla();
        }
        private void muestraTabla()
        {
            int num = Convert.ToInt32(this.textBoxnum.Text);
            string tabla = "";
            for (int i = 1; i <= 10; i++)
            {
                tabla = tabla + num + "x" + i + "=" + (num * i) + "\n";
            }
            this.richTextBoxresultados.AppendText(tabla);
        }
    }
}
