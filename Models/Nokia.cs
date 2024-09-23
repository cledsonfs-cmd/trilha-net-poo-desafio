namespace DesafioPOO.Models
{
  public class Nokia : Smartphone
  {
    public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
    {
      this.Numero = numero;
      this.Modelo = modelo;
      this.IMEI = imei;
      this.Memoria = memoria;
    }
  
    public override void InstalarAplicativo(string nomeApp)
    {
      Console.WriteLine("Aplicativo "+nomeApp+" instalado no Nokia com sucesso!");
    }
  }
}