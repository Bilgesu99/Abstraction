using Abstraction;
using System.Net.Sockets;

Calisan yazilimci = new YazilimGeliştirici
{
    Ad = "aa",
    Soyad = "bb",
    Departman = "Yazılım Geliştirme"
};
yazilimci.Gorev();

// Proje Yöneticisi örneği
Calisan yonetici = new ProjeYöneticisi
{
    Ad = "dd",
    Soyad = "kk",
    Departman = "Proje Yönetimi"
};
yonetici.Gorev();

// Satış Temsilcisi örneği
Calisan satici = new SatisTemsilcisi
{
    Ad = "ff",
    Soyad = "ss",
    Departman = "Satış"
};
satici.Gorev();
