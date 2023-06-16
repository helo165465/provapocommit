using System.Runtime.CompilerServices;

public class Funcionario
{
    public string matricula;
    public string cpf;
    public string nome;
    public string funcao;
    public double salario;
    public double salariofinal;
    public Funcionario(string matricula, string cpf, string nome, string funcao, double salario, double salariofinal)
    {
        this.matricula = matricula;
        this.cpf = cpf;
        this.nome = nome;
        this.funcao = funcao;
        this.salario = salario;
        this.salariofinal = salariofinal;
    }

    public (double a, double b, double c, double salario) CalcularSalario()
    {
        string funcao = this.funcao;
        string a = ("medico");
        string b = ("tecnico de informatica");
        string c = ("administrador");
        double salario = 2000.00;

        if (funcao ==  a)
        {
            salariofinal = salario + (2000 * 20 / 100);
            
        }
        if (funcao == b)
        {
            salariofinal = salario + (5600);
        }
        
        if (funcao == c)
        {
            salariofinal = salario + (2000 * 15 / 100) + 200;
        }

        else if (salariofinal > 5000)
        {
            salariofinal = salariofinal - (salariofinal * 17  / 100);
        }

        return CalcularSalario();
    }
}
