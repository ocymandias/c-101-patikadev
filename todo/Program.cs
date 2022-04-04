using System;

namespace todo
{
    class Program
    {

        static void Main(string[] args)
        {
            Board _board = new();
            Card _card = new();

            bool flag = true;

            while (flag)
            {
                System.Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
                System.Console.WriteLine("*******************************************");
                System.Console.WriteLine("(1) Board Listelemek");
                System.Console.WriteLine("(2) Board'a Kart Eklemek");
                System.Console.WriteLine("(3) Board'dan Kart Silmek");
                System.Console.WriteLine("(4) Kart Taşımak");
                System.Console.WriteLine("(5) Kart Güncellemek");
                System.Console.WriteLine("(6) Çıkış");

                string kullanıcı = Console.ReadLine();
                if (kullanıcı == "1")
                    _board.GetLists();
                else if (kullanıcı == "2")
                    _board.Add();
                else if (kullanıcı == "3")
                    _board.Delete();
                else if (kullanıcı == "4")
                    _board.CardTransport();
                else if (kullanıcı == "5")
                    _board.Update();
                else if (kullanıcı == "6")
                    flag = false;
            }
        }
    }
}