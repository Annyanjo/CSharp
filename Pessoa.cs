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
