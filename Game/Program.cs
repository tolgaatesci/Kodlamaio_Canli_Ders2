using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            CampaignManager campaignManager = new CampaignManager();
            GamerManager gamerManager = new GamerManager();

            Gamers oyuncu1 = new Gamers();
            oyuncu1.Id = 1;
            oyuncu1.Ad = "Tolga";
            oyuncu1.SoyAd = "Atesci";
            oyuncu1.Cinsiyet = "E";
            oyuncu1.TcNo = "123";
            oyuncu1.DogumYili = "1992";
            Gamers oyuncu2 = new Gamers();
            oyuncu2.Id = 2;
            oyuncu2.Ad = "Ayşe";
            oyuncu2.SoyAd = "Fatma";
            oyuncu2.Cinsiyet = "K";
            oyuncu2.TcNo = "456";
            oyuncu2.DogumYili = "1995";

            Campaigns kampanya1 = new Campaigns();
            kampanya1.Id = 11;
            kampanya1.Ad = "A";
            kampanya1.Aciklama = "Multiplayer";
            kampanya1.Indirim = "%30";
            Campaigns kampanya2 = new Campaigns();
            kampanya2.Id = 22;
            kampanya2.Ad = "B";
            kampanya2.Aciklama = "Online";
            kampanya2.Indirim = "%20";

            campaignManager.Ekle(kampanya1);
            Console.WriteLine("---------------------------------------------------");
            campaignManager.Sil(kampanya2);
            Console.WriteLine("---------------------------------------------------");
            gamerManager.Ekle(oyuncu1);
            Console.WriteLine("---------------------------------------------------");
            gamerManager.Sil(oyuncu2);
            Console.WriteLine("---------------------------------------------------");
        }
    }
}
