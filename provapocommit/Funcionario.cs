using System.Runtime.CompilerServices;

public class Funcionario
{
    public string matricula;
    public string cpf;
    public string nome;
    public string funcao;
    public double salario;
    public Funcionario(string matricula, string cpf, string nome, string funcao, double salario)
    {
        this.matricula = matricula;
        this.cpf = cpf;
        this.nome = nome;
        this.funcao = funcao;
        this.salario = salario;
    }

    public (string, string, string, string, double) CalcularSalario()
    {
        

    }
}
