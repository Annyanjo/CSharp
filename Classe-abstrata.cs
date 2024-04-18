public abstract class Animal{
    private string nome;
    private int vida;
    public Animal(string nome, int vida) {
        this.nome = nome;
        this.vida = vida;
    }
    public string GetNome(){
        return nome;
    }
    //Setter para o nome
    public void SetNome(string nome){
        this.nome = nome;
    }
    //Getter para o nivel
    public int GetVida(){
        return vida;
    }
    //Setter para o nivel
    public void SetVida(int vida){
        this.vida = vida;
    }
    public abstract void Morder();
    public void ReceberDano(int dano) {
        Vida -= dano;
        Console.WriteLine($"{Nome} perdeu {dano} de dano e agora tem {Vida} de vida.");
        if (Vida <= 0) {
            Morrer();
        }
    }
    public void Morrer(){
        Console.WriteLine($"{Nome} morreu!");
    }

    public abstract void Morreu();
    public void ReceberDano(int dano) {
        Vida -= dano;
        Console.WriteLine($"{Nome} perdeu {dano} de dano e agora tem {Vida} de vida.");
        if (Vida <= 0) {
            Morder();
        }
    }
    public void Morder(){
        Console.WriteLine($"{Nome} morreu!");
    }
}
public class Corggi : Animal {
    public Corggi(string nome, int vida) : base(nome, vida) {}
    public override void Morder(){
        Console.WriteLine($"{Nome} mordeu Avestruz!");
    }
}
public class Avestruz : Animal {
    public Avestruz(string nome, int vida) : base(nome, vida) {}

    public override void Morder() {
        Console.WriteLine($"{Nome} morde o Corggi!");
    }
}
public class Porco : Animal {
    public Porco(string nome, int vida) : base(nome, vida) {}
    public override void Morreu(){
        Console.WriteLine($"{Nome} morte do Porco!");
    }
}
public class Galinha : Animal {
    public Galinha(string nome, int vida) : base(nome, vida) {}

    public override void Morreu() {
        Console.WriteLine($"{Nome} matou o Porco!");
    }
}