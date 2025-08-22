namespace GFT_DIO_D3.Models;

public class Nokia : Smartphone
{
    public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria) { }

    public override void InstalarAplicativo(string nomeApp)
    {
        Console.WriteLine($"Instalando {nomeApp} no Nokia.");
    }
}