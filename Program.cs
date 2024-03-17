
﻿using System;
﻿using System;

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

        // C. Panggil method PrintData() setelah mengisi "data" dengan NIM
        DataGeneric<string> data = new DataGeneric<string>("1302204032");
        data.PrintData();
    }
}



public class DataGeneric<T>
{
    // A. Property Data yang bertipe generic T
    public T Data { get; set; }

    // A. Konstruktor dengan parameter data
    public DataGeneric(T data)
    {
        this.Data = data;
    }

    // B. Method PrintData untuk mencetak nilai data ke console
    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + Data);
    }
}

