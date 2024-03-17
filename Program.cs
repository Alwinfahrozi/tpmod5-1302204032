using System;

public class HaloGeneric
{
    // B. Method SapaUser dengan generic parameter T
    public void SapaUser<T>(T user)
    {
        Console.WriteLine("Halo  " + user);
    }
}

class Program
{
    static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();

        // C. Panggil method SapaUser dengan input nama panggilan praktikan (String)
        string namaPanggilan = "Alwin";
        halo.SapaUser(namaPanggilan);

        // Contoh penggunaan dengan tipe data yang berbeda
        int nomorPengguna = 1302204032;
        halo.SapaUser(nomorPengguna);
    }
}