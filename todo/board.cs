using System;
using System.Collections;
using System.Collections.Generic;


namespace todo
{
    class Board : ICrud
    {

        static List<Card> cardList = new();





        public Board()
        {
            cardList.AddRange(defaultCard);

        }

        static List<Card> defaultCard = new()
        {
            new Card("Classlar", "Card,employee,board klassalrını oluştur.", Employee.employee[0], Card.Size.XS, Card.State.TODO_LINE),
            new Card("İnterface ", "Crud işlemlerini interface'e ekle", Employee.employee[2], Card.Size.XS, Card.State.TODO_LINE),
            new Card("CRUD", "Crud işlemlerini ekle", Employee.employee[0], Card.Size.XS, Card.State.TODO_LINE),
            new Card("Main metot", "Main metoduna fonksyonları ekle", Employee.employee[3], Card.Size.XS, Card.State.TODO_LINE),
            new Card("Test", "Uygulamayı test et ve paylaş.", Employee.employee[1], Card.Size.XS, Card.State.TODO_LINE)
        };


        public void Add()
        {
            System.Console.Write("Başlık giriniz : ");
            string title = Console.ReadLine();
            System.Console.WriteLine("İçerik Giriniz : ");
            string content = Console.ReadLine();
            System.Console.WriteLine("Büyüklük Seçiniz ->XS(1),S(2),M(3),L(4),XL(5): ");
            Card.Size size = (Card.Size)Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Kişi Seçiniz :");
            // System.Console.WriteLine("Kişi seçenekleri :");
            EmployeeListPrint();
            string choosePersonWithId = Console.ReadLine();
            var result = Array.Find(Employee.employee, p => p.Id == choosePersonWithId
          );
            if (result != null)
                cardList.Add(new Card(title, content, result, size, Card.State.TODO_LINE));
            else
            {
                System.Console.WriteLine("Hatalı giriş yaptınız.Tekrar deneyiniz.");
            }
        }

        public void Delete()
        {
            bool flag = true;
            while (flag)
            {
                System.Console.WriteLine(" Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
                System.Console.Write("Lütfen kart başlığını yazınız: ");
                string title = Console.ReadLine();

                var resultTodo = cardList.Find(t => t.Title == title);


                if (resultTodo != null)
                {

                    cardList.Remove(resultTodo);
                    flag = false;
                }
                else
                {
                    System.Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız. ");
                    System.Console.WriteLine("* Silmeyi sonlandırmak için : (1) ");
                    System.Console.WriteLine("* Yeniden denemek için : (2)");
                    string userInput = Console.ReadLine();
                    if (userInput == "1")
                        flag = false;
                }
            }
        }

        public void GetLists()
        {
            Console.WriteLine("TODO Line");
            Console.WriteLine("************************");
            PrintList(cardList, Card.State.TODO_LINE);
            Console.WriteLine("IN PROGRESS Line");
            Console.WriteLine("************************");
            PrintList(cardList, Card.State.IN_PROGRESS_LINE);
            Console.WriteLine("DONE Line");
            Console.WriteLine("************************");
            PrintList(cardList, Card.State.DONE_LIST);
        }

        public void PrintList(List<Card> list, Card.State getState)
        {
            if (list.Count == 0)
                System.Console.WriteLine("Boş");

            foreach (var item in list)
            {
                if (item.State1 == getState)
                {
                    System.Console.WriteLine("Başlık          : {0}", item.Title);
                    System.Console.WriteLine("İçerik          : {0}", item.Content);
                    System.Console.WriteLine("Atanan Kişi     : {0}", item.Employee.Name + item.Employee.Surname);
                    System.Console.WriteLine("Büyüklük        : {0}", item.Sizee);
                    System.Console.WriteLine("-");
                }

            }
        }

        public void CardTransport()
        {
            bool flag = true;
            while (flag)
            {
                System.Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
                System.Console.WriteLine("Lütfen kart başlığını yazınız: ");

                string cardTitle = Console.ReadLine();
                var result = cardList.Find(c => c.Title == cardTitle);
                if (result != null)
                {
                    System.Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz: ");
                    System.Console.WriteLine("(1) TODO");
                    System.Console.WriteLine("(2) IN PROGRESS");
                    System.Console.WriteLine("(3) DONE");

                    string userChose = Console.ReadLine();

                    if (userChose == "1")
                        result.State1 = Card.State.TODO_LINE;
                    else if (userChose == "2")
                        result.State1 = Card.State.IN_PROGRESS_LINE;
                    else if (userChose == "3")
                        result.State1 = Card.State.DONE_LIST;

                    flag = false;
                }
                else
                {
                    System.Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız. ");
                    System.Console.WriteLine("* İşlemi sonlandırmak için : (1) ");
                    System.Console.WriteLine("* Yeniden denemek için : (2)");
                    string userInput = Console.ReadLine();
                    if (userInput == "1")
                        flag = false;
                }
            }

        }
        public void Update()
        {
            bool flag = true;
            while (flag)
            {
                System.Console.WriteLine(" Öncelikle Güncellemek istediğiniz kartı seçmeniz gerekiyor.");
                System.Console.Write("Lütfen kart başlığını yazınız: ");
                string title = Console.ReadLine();

                var resultTodo = cardList.Find(t => t.Title == title);
                if (resultTodo != null)
                {
                    System.Console.WriteLine("Değiştirmek istenen özellikler :");
                    System.Console.WriteLine("Başlık(1) :");
                    System.Console.WriteLine("İçerik(2) :");
                    System.Console.WriteLine("Kişi(3) :");


                    string userInput = Console.ReadLine();

                    foreach (var item in userInput)
                    {
                        if (item == '1')
                        {
                            System.Console.WriteLine("Başlık :");
                            resultTodo.Title = Console.ReadLine();
                        }
                        else if (item == '2')
                        {
                            System.Console.WriteLine("İçerik : ");
                            resultTodo.Content = Console.ReadLine();

                        }
                        else if (item == '3')
                        {
                            System.Console.WriteLine("Çalışan idleri");
                            EmployeeListPrint();
                            string id = Console.ReadLine();
                            if (CheckUserId(id))
                            {
                                resultTodo.Employee.Id = id;
                            }
                            else
                            {
                                System.Console.WriteLine("Hatalı kullanıcı girdiniz.İşlem iptal edildi.");
                            }

                        }
                    }
                    flag = false;
                }
                else
                {
                    System.Console.WriteLine("Kullanıcı bulunamadı.");
                    flag = false;
                }
            }
        }

        private void EmployeeListPrint()
        {
            foreach (var item in Employee.employee)
            {
                System.Console.WriteLine($"{(Convert.ToInt32(item.Id) - 1)}- {item.Name} {item.Surname}");
            }
        }

        private bool CheckUserId(string id)
        {
            string Ids = "";
            foreach (var item in Employee.employee)
            {
                if (id == item.Id) return true;

            }

            return false;

        }
    }
}