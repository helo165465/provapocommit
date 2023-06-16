namespace provapocommit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string matricula = tx_matricula.Text;
            string cpf = tx_cpf.Text;
            string nome = tx_nome.Text;
            string funcao = tx_funcao.Text;
            string salario = tx_salario.Text;
            string salariofinal = lb_confirm.Text;

            Funcionario f = new Funcionario(matricula, cpf, nome, funcao, salario, salariofinal);
            lb_confirm.Text = $" SEU SALÁRIO É DE {f.CalcularSalario}";


        }

        private void tx_salario_TextChanged(object sender, EventArgs e)
        {


        }
    }
}