using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vigenere_Sifreleme
{
    class Vigenere_Sifreleme
    {
        private string anahtar_kelime;
        private int anahtar_kelime_length;
        private int anahtar_kelime_sayac;
        private string kullanici_yazi;
        private string sifre_yazi;
        
        public Vigenere_Sifreleme(string anahtar_kelime, string sifre_yazi)
        {
            this.anahtar_kelime = anahtar_kelime;
            this.kullanici_yazi = sifre_yazi;
            this.anahtar_kelime_length = anahtar_kelime.Length;
        }
        
        private bool Turkce(char karakter)
        {
            if (karakter == 'ç' || karakter == 'Ç' || karakter == 'ğ' || karakter == 'Ğ' || karakter == 'ı' || karakter == 'İ' || karakter == 'ö' || karakter == 'Ö' || karakter == 'ş' || karakter == 'Ş' || karakter == 'ü' || karakter == 'Ü')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public bool Alfabetik_sorgu()
        {
            bool sonuc = true;
            for (int i = 0, s = anahtar_kelime_length; i < s; i++)
            {
                if (char.IsLetter(anahtar_kelime[i]) && !Turkce(anahtar_kelime[i]))
                {
                    continue;
                }
                else
                {
                    sonuc = false;
                    break;
                }
            }
            return sonuc;
        }
        
        public string Sifrele()
        {
            sifre_yazi = "";
            anahtar_kelime_sayac = 0;
            for (int i = 0, s = kullanici_yazi.Length; i < s; i++)
            {
                if (char.IsLetter(kullanici_yazi[i]) && !Turkce(kullanici_yazi[i]))
                {
                    int formul;
                    
                    if (char.IsUpper(kullanici_yazi[i]))
                    {
                        formul = ((kullanici_yazi[i] - 65) + (char.ToUpper(anahtar_kelime[anahtar_kelime_sayac % anahtar_kelime_length]) - 65)) % 26;
                        sifre_yazi += (char)(formul + 65);
                        anahtar_kelime_sayac++;
                    }
                    else
                    {
                        formul = ((kullanici_yazi[i] - 97) + (char.ToLower(anahtar_kelime[anahtar_kelime_sayac % anahtar_kelime_length]) - 97)) % 26;
                        sifre_yazi += (char)(formul + 97);
                        anahtar_kelime_sayac++;
                    }
                }
                else
                {
                    sifre_yazi += kullanici_yazi[i];
                }
            }
            return sifre_yazi;
        }
        
        public string DesifreEt()
        {
            sifre_yazi = "";
            anahtar_kelime_sayac = 0;

            for (int i = 0, s = kullanici_yazi.Length; i < s; i++)
            {
                if (char.IsLetter(kullanici_yazi[i]) && !Turkce(kullanici_yazi[i]))
                {
                    int formul;
                    
                    if (char.IsUpper(kullanici_yazi[i]))
                    {
                        formul = ((kullanici_yazi[i] - 65) - (char.ToUpper(anahtar_kelime[anahtar_kelime_sayac % anahtar_kelime_length]) - 65)) % 26;
                        if (formul < 0)
                        {
                            formul += 26;
                        }
                        sifre_yazi += (char)(formul + 65);
                        anahtar_kelime_sayac++;
                    }
                    else
                    {
                        formul = ((kullanici_yazi[i] - 97) - (char.ToLower(anahtar_kelime[anahtar_kelime_sayac % anahtar_kelime_length]) - 97)) % 26;
                        if (formul < 0)
                        {
                            formul += 26;
                        }

                        sifre_yazi += (char)(formul + 97);
                        anahtar_kelime_sayac++;
                    }
                }
                else
                {
                    sifre_yazi += kullanici_yazi[i];
                }
            }
            return sifre_yazi;
        }


    }
}
