namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    // feito
    public class Iphone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        // feito
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        { }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Iphone: instalando o aplicativo {nomeApp}");
        }
    }
}