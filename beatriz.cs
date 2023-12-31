using System;


public class Veiculo // Abstração que é a representação de um objeto real
{
    public string Cor { get; set;} // Encapsulamento usando get e set
    public string Modelo { get; set;}
    public string Ano { get; set; }
    public string Marca { get; set; }
    public string Placa { get; set; }

    public virtual  void combustivelUsado()
    {
    }

}

public class Carro : Veiculo
{
    public override void combustivelUsado(){
        Console.WriteLine("Gasolina");
    }
}

public class Caminhao : Veiculo //Conceito de herança, aqui está herdando da classe Veiculo
{
    public override void combustivelUsado() //Polimorfismo a alteracao de um metodo herdado da classe pai
    {
          Console.WriteLine("Diesel");
    }
    

public static void Main()
{
    Caminhao caminhao = new Caminhao();
    caminhao.combustivelUsado();
    
    Carro carro = new Carro();
    carro.combustivelUsado();
}
}
