public class Pessoa{
    private String nome;
    private int idade;
    private String cpf;
    //Construtor da classe Pessoa
    public Pessoa(string nome, int idade, string cpf){
        Nome = nome;
        idade = idade;
        CPF = cpf; 
    }
    public string Nome{
        get { return nome; }
        set { nome = value; }
    }
    public int Idade{
        get { return idade; }
        set { idade = value; }
    }
    public string CPF {
        get { return cpf; }
        set { cpf = value; }
    }
}
public class Estudante ; Pessoa{
    private String curso;

    //Construtor da classe Estudante
    public Estudante(string nome, int idade, string cpf, string curso) : base(nome, idade, cpf){
        Curso = curso;
    }

    public string Curso{
        get { return curso; }
        set { curso = value; }
    }
}

public class Funcionario : Pessoa{
    private double salario;

    //Metodo para calcular o bônus
    public double Bonus(){
        return salario * 0.1; //10% de bônus padrão sobre o salario
    }

    //Construtor da classe Funcionario
    public Funcionario(string nome, int idade, string cpf, double salario) : base(nome, idade, cpf){
        salario = salario;
    }

    //Propriedades da classe Funcionario que permite acesso controlado a um campo privado
    public string Salario {
        get { return salario; }
        set { salario = value; }
    }
}

public class Diretor : Funcionario{

    //Construtor da classe Gerente
    public Diretor(string nome, int idade, string cpf, double salario) : base(nome, idade, cpf, salario){
        //
    }

    public override double Bonus{
        return base.Bonus() + 1000;
    }
}
