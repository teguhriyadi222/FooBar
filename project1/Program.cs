namespace project1FooBar;

public class Program
{
    static void Main()
    {
        FooBar fooBar = null;
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("==========Selamat Datang di menu Foobar=========");
            Console.WriteLine("1. Set nilai n");
            Console.WriteLine("2. Tambah data ke dictionary");
            Console.WriteLine("3. Perbarui data dalam dictionary");
            Console.WriteLine("4. Hapus data dari dictionary");
            Console.WriteLine("5. Lihat data dari dictionary");
            Console.WriteLine("6. Keluar");
            Console.Write("Masukkan Pilihan Anda: ");

            int Option;
            if (int.TryParse(Console.ReadLine(), out Option))
            {
                switch (Option)
                {
                    case 1:
                        Console.Write("Masukkan nilai n: ");
                        int n = int.Parse(Console.ReadLine());
                        fooBar = new FooBar(n);
                        Console.WriteLine("\nHasil:");
                        string fooBarOutput = fooBar.Output();
                        Console.WriteLine(fooBarOutput);
                        break;
                    case 2:
                        if (fooBar != null)
                        {
                            Console.WriteLine("\nMenambahkan data ke dictionary:");
                            Console.Write("Masukkan nilai kunci: ");
                            int key = int.Parse(Console.ReadLine());
                            Console.Write("Masukkan nilai value: ");
                            string value = Console.ReadLine();
                            fooBar.Add(key, value);
                        }
                        else
                        {
                            Console.WriteLine("Silakan set nilai n terlebih dahulu.");
                        }
                        break;
                    case 3:
                        if (fooBar != null)
                        {
                            Console.WriteLine("\nMemperbarui data dalam dictionary:");
                            Console.Write("Masukkan nilai kunci: ");
                            int a = int.Parse(Console.ReadLine());
                            Console.Write("Masukkan nilai value yang baru: ");
                            string b = Console.ReadLine();
                            fooBar.Update(a, b);
                            Console.WriteLine("Data berhasil diperbarui dalam dictionary.");
                        }
                        else
                        {
                            Console.WriteLine("Silakan set nilai n terlebih dahulu.");
                        }
                        break;
                    case 4:
                        if (fooBar != null)
                        {
                            Console.WriteLine("\nMenghapus data dari dictionary:");
                            Console.Write("Masukkan nilai kunci yang akan dihapus: ");
                            int c = int.Parse(Console.ReadLine());
                            fooBar.Delete(c);
                            Console.WriteLine("Data berhasil dihapus dari dictionary.");
                        }
                        else
                        {
                            Console.WriteLine("Silakan set nilai n terlebih dahulu.");
                        }
                        break;
                    case 5:
                        if (fooBar != null)
                        {
                            string dataDictionary = FooBar.Read(fooBar.GetDictionary());
                            Console.WriteLine(dataDictionary);
                        }
                        else
                        {
                            Console.WriteLine("Silakan set nilai n terlebih dahulu.");
                        }
                        break;
                    case 6:
                        exit = true;
                        Console.WriteLine("Terima kasih telah menggunakan program Foobar.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Input tidak valid. Silakan masukkan angka sebagai pilihan.");
            }

            Console.WriteLine("Tekan ENTER untuk melanjutkan...");
            Console.ReadKey();
        }
    }
}