public class Produto{
    private String nome;
    private decimal preco;
    private String descricao;
    private String categoria;
    //Construtor da classe Produto
    public Produto(string nome, decimal preco, string descricao, string categoria){
        Nome = nome;
        Preco = preco;
        Descricao = descricao;
        Categoria = categoria;
    }
    public string Nome{
        get { return nome; }
        set { nome = value; }
    }
    public decimal Preco{
        get { return preco; }
        set { preco = value; }
    }
    public string Descricao {
        get { return descricao; }
        set { descricao = value; }
    }
    public string Categoria{
        get { return categoria; }
        set { categoria = value; }
    }
}
public class ConsoleGame : Produto{
    private int capacidadeArmazenamento;
    //Construtor da classe Estudante
    public ConsoleGame (string nome, decimal preco, string descricao, string categoria, int capacidadeArmazenamento ) : base(nome, preco, descricao, categoria){
        CapacidadeArmazenamento = capacidadeArmazenamento ;
    }

    public int CapacidadeArmazenamento{
        get { return capacidadeArmazenamento; }
        set { capacidadeArmazenamento = value; }
    }
}
public class Jogo : Produto{
    private string genero;
    //Construtor da classe Estudante
    public Jogo (string nome, decimal preco, string descricao, string categoria, string genero ) : base(nome, preco, descricao, categoria){
        Genero = genero ;
    }

    public string Genero{
        get { return genero; }
        set { genero = value; }
    }
}
public class Acessorio : Produto{
    private string tipo;
    //Construtor da classe Estudante
    public Acessorio (string nome, decimal preco, string descricao, string categoria, string tipo ) : base(nome, preco, descricao, categoria){
        Tipo = tipo ;
    }

    public string Tipo{
        get { return tipo; }
        set { tipo = value; }
    }
}
public class Colecionavel : Produto{
    private bool edicaoLimitada;
    //Construtor da classe Estudante
    public Colecionavel (string nome, decimal preco, string descricao, string categoria, bool edicaoLimitada ) : base(nome, preco, descricao, categoria){
        EdicaoLimitada = edicaoLimitada ;
    }

    public bool EdicaoLimitada{
        get { return edicaoLimitada; }
        set { edicaoLimitada = value; }
    }
}
public class Colecionavel {...
    public class Program{
        public static void main (string[] args){

            Produto produto;
            produto = new ConsoleGame("PlayStation 4", 6.890,"Console de Video Game PlayStation 4 Slim com 2 Tera de armazenamento" , "Console", 1024000);

            Jogo jogo; 
            jogo = new Jogo("Dc's Supermen 2 PREMIUM", 388.8,"Jogo completo Dc's Supermen 2 para PS4." , "Jogo PS4", "Ação e Aventura");

            Acessorio acessorio;
            acessorio = new Acessorio("Oculo de sol", 40.0, "Oculo de sol" , "Acessorio", 2035000);

            Colecionavel colecionavel;
            colecionavel = new Colecionavel("Manga Onepiece", 499.9,"Manga Onepiece Capitulo 40" , "Colecionavel" , 3046000);
        }
    }
}