namespace classe.Models;

public class ContaPoupanca : Conta
{
    /*
    public int Numero { get; set; }
    public double Saldo { get; set; }
    public int JurosMensais { get; set; }
    */
    public int JurosMensais { get; set; }

    public ContaPoupanca(double  saldo, int numero, int jurosMensais)
    {
        Saldo = saldo;
        Numero = numero;
        JurosMensais = jurosMensais;
    }
    public double CalculoMensais()
    {
        return Convert.ToDouble(Saldo * JurosMensais);
    }

    public void VerSaldo()
    {
         Console.WriteLine(Saldo);
    }
}