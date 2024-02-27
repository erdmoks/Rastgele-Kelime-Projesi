using System;
using System.IO;
using System.Linq;

public class Kelimeler
{
    static void Main(string[] args)
    {
        string kelimelerDosyasi = @" "; // kelimelerin cekilecegi dosyanin yolu
        string sonucDosyasi = @" "; // Ciktinin dosya yolu

        string[] kelimeler = File.ReadAllLines(kelimelerDosyasi);

        Random rastgele = new Random();

        bool devamEt = true;

        while (devamEt)
        {
            // rastgele sayi sec.
            int secilenSayi = rastgele.Next(0, kelimeler.Length);

            if (kelimeler[secilenSayi] != "NULL")
            {
                // random secilenSayi'nin belirttigi indexe sahip olan string'i, belirtilen sonucDosyasina yazdir.
                File.AppendAllText(sonucDosyasi, kelimeler[secilenSayi] + Environment.NewLine);

                // secilen kelimenin yerine NULL yazdir. Ayni kelimenin tekrar etmemesi icin kullanilan bir yontem.
                kelimeler[secilenSayi] = "NULL";
            }
            // Tum kelimeler NULL olana kadar devam et.
            devamEt = kelimeler.Any(kelime => kelime != "NULL");
        }

    }
}
