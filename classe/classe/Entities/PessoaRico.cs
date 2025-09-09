namespace classe.Models;

public class PessoaRico
{
    public int Id { get; private set; }
    public string? Nome { get; private set; }
    public string? Endereco { get; private set; }

    public PessoaRico(int id, string nome, string endereco)
    {
        if(id < 0)
            throw new InvalidOperationException("id invalida");
        if(string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(endereco))
            throw new InvalidOperationException("nome invalida");
        Id = id;
        Nome = nome;
        Endereco = endereco;
    }
}