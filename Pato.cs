using System;

public class Pato {
    //Atributos
    private string nome;
    private string cor;
    private int idade;
    private double altura;
    private char genero;

    //Construtor
    public Pato(string nome, string cor, int idade, double altura, char genero) {
        this.nome = nome;
        this.cor = cor;
        this.idade = idade;
        this.altura = altura;
        this.genero = genero;
    }
    //Metodos
    public void infoPato(){
        Console.WriteLine($"Nome: {nome}, idade: {idade}, altura:{altura}, genero:{genero}");
    }
    private void correr(){
        Console.WriteLine(" Correndo. ");
    }
    private void pular(){
        Console.WriteLine(" Pulando. ")
    }
}

public class Super : Pato{

    public Super(){
        this.nome = "Super";
        this.cor = "Branco";
        this.idade = 3;
        this.altura = 7.0;
        this.genero = "F";

        public void SuperVelocidade(){
            Console.WriteLine{"Super está utilizando sua super velocidade."}
        }
    }
}

public class Vilao : Pato{

    public Vilao(){
        this.nome = "Vilao";
        this.cor = "Laranja";
        this.idade = 4;
        this.altura = 8.0;
        this.genero = "M";

        public void VilaoForca(){
            Console.WriteLine{"Vilao está utilizando sua super forca."}
        }
    }
}

class Progam{
    static void Main(string[] args){
        Super super = new Super();
        Vilao vilao = new Vilao();

        Console.WriteLine($"Nome: {super.Nome}, Cor: {super.Cor}, Idade: {super.Idade}, Altura:{super.Altura}, Genero:{super.Genero}");

        super.Correr();
        super.Pular();
        super.SuperVelocidade();

        Console.WriteLine();
        Console.WriteLine($"Nome: {vilao.Nome}, Cor: {vilao.Cor}, Idade: {vilao.Idade}, Altura:{vilao.Altura}, Genero:{vilao.Genero}");

        vilao.Correr();
        vilao.Pular();
        vilao.SuperForca();
    }
}