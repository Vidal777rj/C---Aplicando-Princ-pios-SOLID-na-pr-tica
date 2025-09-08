namespace classe.Models;

public class Pessoa
{
    public string? Name { get; set; }
    public int Idade { get; set; }
    public char? Genero { get; set; }
    
    //Construtor
    public Pessoa(string ? name, int idade, char? genero)
    {
        Name = name;
        Idade = idade;
        Genero = genero;    
    }

    public Pessoa(string? name)
    {
        Name = name;
    }
    //Métodos
    public void Identificar(string? name, int idade, char? genero)
    {
         Console.WriteLine($"Olá sou o {name}, tenho {idade} anos e sou do sexo {genero}");
    }
}