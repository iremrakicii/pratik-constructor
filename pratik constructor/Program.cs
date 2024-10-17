using pratik_constructor;

class Program
{
    static void Main(string[] args)
    {
        //// Parametreli constructor ile nesne oluşturma
        BabyClass bebek = new BabyClass("Ayşe", "Öztürk");
        Console.WriteLine($"Bebeğin adı : {bebek.AddName}, Bebeğin soyadı: {bebek.AddSurname}");
        Console.WriteLine("--------------------------------------");
        // // Default constructor ile nesne oluşturma
        BabyClass bebek1 = new BabyClass();
        bebek1.AddName = "Ahmet";
        bebek1.AddSurname = "Ertürk";
        Console.WriteLine($"Bebeğin adı: {bebek1.AddName}, Bebeğin soyadı: {bebek1.AddSurname}");

    }
}