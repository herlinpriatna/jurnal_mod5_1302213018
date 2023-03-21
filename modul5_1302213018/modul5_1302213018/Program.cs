public class Penjumlahan
{
    
    public static T JumlahTigaAngka<T>(T input1, T input2, T input3)
    {
        dynamic jml = input1;
        dynamic jml2 = input2;
        dynamic jml3 = input3;

        return jml + jml2+ jml3;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Penjumlahan jml = new Penjumlahan();
        Console.WriteLine(Penjumlahan.JumlahTigaAngka(12, 13, 14));
    }
}