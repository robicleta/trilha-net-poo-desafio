namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
       

        public Iphone(string numero) : base(numero)
        {
      Console.WriteLine($"Instalando {nomeApp} na Nokia...");
        }
            

        public override void InstalarAplicativo(string nomeApp)
        {
             Console.WriteLine($"Instalando {nomeApp} no iPhone...");
        }
    }
}