using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
// feito
class Program
{
    public static void Main()
    {
        Smartphone nokia = new Nokia(numero: "2020-1010", modelo: "M1", imei: "10101010", memoria: 32);
        Smartphone iphone = new Iphone(numero: "1010-2020", modelo: "M2", imei: "20202020", memoria: 64);

        Console.WriteLine("Nokia:");
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("youtube");

        Console.WriteLine("\nIphone:");
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("whatsapp");
    }
}