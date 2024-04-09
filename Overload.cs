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
}
    public void Pular(){
        Console.WriteLine{"Pular"};
    }
    public void Pular(string rapido){
        Console.WriteLine("Pular"+ rapido);
    }
    public virtual void Atacar(){
        Console.WriteLine{"Atacar"};
    }
    public void Atacar(string alguem){
        Console.WriteLine("Atacar"+ alguem);
    }
    public virtual void Assassinar(){
        Console.WriteLine{"Assassinar"}
    }
    public void Assassinar(string pessoa){
        Console.WriteLine("Assassinar"+ pessoa);
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

    public void Pular(){
        Console.WriteLine("Estudante pulou alto");
    }
    public void Pular(string rapido){
        Console.WriteLine("Estudante pulou alto"+ rapido);
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
     public void Atacar(string alguem){
        Console.WriteLine("Funcionario atacou o chefe"+ alguem);
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
        Console.WriteLine("Assassinou o funcionario");
    }
    public override void Assassinar(string pessoa){
        Console.WriteLine("Assassinou o funcionario"+ pessoa);
    }
}