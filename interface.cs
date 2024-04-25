using System;
interface IAtaque{
    void Atacar();
}
public abstract class Heroi{
    private string nome;
    private int vida;
    public Heroi(string nome, int vida) {
        this.nome = nome;
        this.vida = vida;
    }
    public string GetNome(){
        return nome;
    }
    public void SetNome(string nome){
        this.nome = nome;
    }
    public int GetVida(){
        return vida;
    }
    public void SetVida(int vida){
        this.vida = vida;
    }
    public abstract void Especial();
    public void ReceberDano(int dano) {
        Vida -= dano;
        Console.WriteLine($"{Nome} perdeu {dano} de dano e agora tem {Vida} de vida.");
        if (Vida <= 0) {
            Morrer();
        }
    }
}

class Soldado : IAtaque, Heroi{
    public void Atacar(){
        public Soldado(string nome, int vida) : base(nome, vida) {}
        Console.WriteLine("Soldado ataca um pato!");
    }
    public override Especial(){
        Console.WriteLine("Com fogo!");
    }
}
class Feiticeira : IAtaque{
    public void Atacar(){
        public Feiticeira(string nome, int vida) : base(nome, vida) {}
        Console.WriteLine("Feiticeira ataca o soldado!");
    }
}
class Arqueiro : IAtaque{
    public void Atacar(){
        public Arqueiro(string nome, int vida) : base(nome, vida) {}
        Console.WriteLine("Arqueiro dispara flechas na Feiticeira!");
    }
}
class Program{
    static void Main(string[] args){
        IAtaque soldado = new Soldado();
        IAtaque feiticeira = new Feiticeira();
        IAtaque arqueira = new Arqueiro();

        soldado.Atacar();
        feiticeira.Atacar();
        arqueira.Atacar();
    }
}