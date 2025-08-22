namespace GFT_DIO_D3.Models;

public abstract class Smartphone(string numero, string modelo, string imei, int memoria)
{
    public string Numero { get; set; } = numero;
    public string Modelo { get; set; } = modelo;
    public string IMEI { get; set; } = imei;
    public int Memoria { get; set; } = memoria;

    public virtual void Ligar()
    {
        Console.WriteLine("Ligando...");
    }

    public virtual void ReceberLigacao()
    {
        Console.WriteLine("Recebendo ligação...");
    }

    public abstract void InstalarAplicativo(string nomeApp);
}