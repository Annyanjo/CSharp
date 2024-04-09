public class Pessoa{
    private String nome;
    private int idade;
    private String Altura;
    //Construtor da classe Pessoa
    public Pessoa(string nome, int idade, string altura){
        Nome = nome;
        idade = idade;
        Altura = altura; 
    }
    public string Nome{
        get { return nome; }
        set { nome = value; }
    }
    public int idade{
        get { return idade; }
        set { idade = value; }
    }
    public string Altura {
        get { return altura; }
        set { altura = value; }
    }

    public virtual void Pular(){
        Console.WriteLine{"Pular alto"};
    }
    public virtual void Atacar(){
        Console.WriteLine{"Atacar alguem"};
    }
    public virtual void Assassinar(){
        Console.WriteLine{"Assassinar pessoa"}
    }
}
public class Estudante : Pessoa{
    private String curso;

    //Construtor da classe Estudante
    public Estudante(string nome, int idade, string altura, string curso) : base(nome, idade, altura){
        Curso = curso;
    }

    public string Curso{
        get { return curso; }
        set { curso = value; }
    }

    public override void Pular(){
        Console.WriteLine("Estudante pulou alto");
    }
}

public class Funcionario : Pessoa{
    private double salario;

    //Metodo para calcular o bônus
    public double Bonus(){
        return salario * 0.1; //10% de bônus padrão sobre o salario
    }

    //Construtor da classe Funcionario
    public Funcionario(string nome, int idade, string altura, double salario) : base(nome, idade, altura){
        salario = salario;
    }

    //Propriedades da classe Funcionario que permite acesso controlado a um campo privado
    public string Salario {
        get { return salario; }
        set { salario = value; }
    }

    public override void Atacar(){
        Console.WriteLine("Funcionario atacou o chefe");
    }
}

public class Diretor : Funcionario{

    //Construtor da classe Gerente
    public Diretor(string nome, int idade, string altura, double salario) : base(nome, idade, altura, salario){
        //
    }

    public override double Bonus{
        return base.Bonus() + 1000;
    }

    public override void Assassinar(){
        Console.WriteLine("Assassinou o funcionario")
    }
}