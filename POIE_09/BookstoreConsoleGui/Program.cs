using System;
using System.Collections.Generic;
using BookstoreModel;
using RepositoryLibrary;

namespace BookstoreConsoleGui
{
    class Program
    {
        static void TestCalculateAvgPrice(List<Item> itemList)
        {
            decimal sum = 0;
            int counter = 0;

            foreach (var item in itemList)
            {
                sum += item.CalculateGrossPrice();
                counter++;
            }

            Console.WriteLine("Średnia cena: {0}", sum/counter);
        }
        static void TestUpdatePrice(List<Item> itemList)
        {
            Console.WriteLine("Aktualizacja ceny.");
            foreach (var item in itemList)
            {
                item.UpdatePrice(1.05M);
            }
        }
        static void TestUpdateBookPrice(List<Item> itemList)
        {
            Console.WriteLine("Aktualizacja ceny książek.");
            foreach (var item in itemList)
            {
                if(item is Book)
                {
                    item.UpdatePrice(1.05M);
                }
            }
        }

        static void TestSummaryReport(List<Item> itemList)
        {
            Console.WriteLine("Raport sumaryczny.");

            decimal priceNet = 0, priceGross = 0, taxAmount = 0;

            foreach (var item in itemList)
            {
                priceNet += item.CalculateGrossPrice() - item.CalculateTax();
                priceGross += item.CalculateGrossPrice();
                taxAmount += item.CalculateTax();
            }

            string reportTxt = $"Raport sumaryczny: \n"
                + $"Wartość netto: {priceNet}\n"
                + $"Wartość brutto: {priceGross}\n"
                + $"Podatek: {taxAmount}";

            Console.WriteLine(reportTxt);
        }

        static void TestBookReport(List<Item> itemList)
        {
            Console.WriteLine("Raport - książki.");

            decimal priceNet = 0, priceGross = 0, taxAmount = 0;

            foreach (var item in itemList)
            {
                if (item is Book)
                {
                    priceNet += item.CalculateGrossPrice() - item.CalculateTax();
                    priceGross += item.CalculateGrossPrice();
                    taxAmount += item.CalculateTax();
                }
            }

            string reportTxt = $"Raport książki: \n"
                + $"Wartość netto: {priceNet}\n"
                + $"Wartość brutto: {priceGross}\n"
                + $"Podatek: {taxAmount}";
        }

        static void TestSortByPrice(List<Item> itemList)
        {
            itemList.Sort();
        }
        static void TestSortBooksByAuthor(List<Item> itemList)
        {
            itemList.Sort(new Book.ByAuthor());
        }
        static void TestSortBooksByTitle(List<Item> itemList)
        {
            itemList.Sort(new Book.ByTitle());
        }

        static void ShowItemList(List<Item> itemList)
        {
            Console.WriteLine();
            Console.WriteLine("Produkty w księgarni:");
            foreach (var item in itemList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
        static void ShowBookList(List<Item> itemList)
        {
            Console.WriteLine();
            Console.WriteLine("Książki w księgarni:");
            foreach (var item in itemList)
            {
                if(item is Book)
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine();
        }


        static void MenuRepozytorium(BookstoreRepository repozytorium, string nazwa)
        {
            Console.WriteLine();
            Console.WriteLine("Wybież jakie działanie chcesz zastosować na swoim repozytorium?");
            Console.WriteLine("1- ResetCodeOfAllProducts, 2- UpdatePriceOfAllProducts");
            string odp = Console.ReadLine();
            if(odp == "1")
            {
                Console.WriteLine("Podaj nowy kod - podaj wyłącznie liczby");
                decimal code = Convert.ToDecimal( Console.ReadLine());
                repozytorium.ResetCodeOfAllProducts(code);
            }
            else if(odp == "2")
            {
                repozytorium.UpdatePriceOfAllProducts();
            }
            else
            {
                Console.WriteLine("Podałeć niepoprawny numer");
            }
            // automatyczny zapis
            repozytorium.Serializuj(nazwa);
        }




        //Próba własna
        static void TestSerializacji(BookstoreRepository repository, string nazwaPliku)
        {
            Console.WriteLine("Próba serialicacji:");
            repository.Serializuj(nazwaPliku);
            Console.WriteLine();
            Console.WriteLine("Próba deserialicacji:");
            List<Item> zwrócona = repository.Deserializacja(nazwaPliku);
            foreach (var item in zwrócona)
            {
                Console.WriteLine(item);
            }
        }
        static List<Item> Deserial(BookstoreRepository repository,string nazwa)
        {
            
            return  repository.Deserializacja(nazwa);
        }


        static void TestRepository(BookstoreRepository repository)
        {
            Book book1 = new Book("Quo Vadis?", "Henryk Sienkiewicz", "DR42145", 342, "Znak", 34.50M);
            Book book2 = new Book("Quo Vadis?", "Henryk Sienkiewicz", "DR42145", 342, "Znak", 31.50M);
            Book book3 = new Book("Quo Vadis?", "Henryk Sienkiewicz", "DR42147", 342, "Znak", 34.50M);


            Console.WriteLine("Bookstore repository - item");

            Console.WriteLine(repository);
            
            repository.UpdatePriceOfAllProducts();
            Console.WriteLine("Price updated");
            Console.WriteLine(repository);

            BookstoreRepository newRepo = repository.GetProductsInPriceRange(35M, 55M);
            Console.WriteLine("New repo:");

            Console.WriteLine(newRepo);
            
            newRepo.GetElements[0].UpdatePrice();
            Console.WriteLine("Old repo");
            Console.WriteLine(repository);

            Console.WriteLine("Is valid");
            Console.WriteLine(repository.IsValid());

            Console.WriteLine();
            Console.WriteLine("Test exists:");
            Console.WriteLine(book1);
            Console.WriteLine(repository.Exists(book1));
            Console.WriteLine(book2);
            Console.WriteLine(repository.Exists(book2));
            Console.WriteLine(book3);
            Console.WriteLine(repository.Exists(book3));
            
        }


        static void Main(string[] args)
        {
            List<Item> itemList = new List<Item>();


            Book b1 = new Book("Quo Vadis?", "Henryk Sienkiewicz", "DR42145", 342, "Znak", 34.50M);
            Book b2 = new Book("Pan Tadeusz", "Adam Mickiewicz", "GF764", 231, "WSiP", 54.67M);
            Book b3 = new Book("Balladyna", "Juliusz Słowacki", "KU64875", 121, "WSiP", 31.98M);
            Book b4 = new Book("Chłopi", "Władysław Reymont", "OY6076", 452, "PWN", 74.20M);
            Book b5 = new Book("Lalka", "Bolesław Prus", "LOU75634", 224, "PWN", 39.70M);

            CD cd1 = new CD("Achtung Baby", "U2", 11, "", 32.99M);
            CD cd2 = new CD("Change of seasons", "Dream Theater", 5, "", 37.99M);

            itemList.Add(cd1);
            itemList.Add(cd2);
            itemList.Add(b1);
            itemList.Add(b2);
            itemList.Add(b3);
            itemList.Add(b4);
            itemList.Add(b5);

            

            BookstoreRepository repo = new BookstoreRepository();

            // dodanie do 
            repo.Add(b1);
            repo.Add(b2);
            repo.Add(cd1);
            repo.Add(b3);
            string nazwaPliku = "pierwszaProba";
            TestSerializacji(repo, nazwaPliku);

            MenuRepozytorium(repo, nazwaPliku);

            // wyświetlam listę
            ShowItemList(Deserial(repo, nazwaPliku));
            TestCalculateAvgPrice(Deserial(repo, nazwaPliku));
            TestUpdatePrice(Deserial(repo, nazwaPliku));
            ShowItemList(Deserial(repo, nazwaPliku));
            TestUpdateBookPrice(Deserial(repo, nazwaPliku));
            ShowItemList(Deserial(repo, nazwaPliku));
            TestUpdatePrice(Deserial(repo, nazwaPliku));
            ShowItemList(Deserial(repo, nazwaPliku));

            Console.WriteLine("Sortowanie produktów po cenie:");
            TestSortByPrice(Deserial(repo, nazwaPliku));
            ShowItemList(Deserial(repo, nazwaPliku));

            Console.WriteLine("Sortowanie książek po tytule.");
            TestSortBooksByTitle(Deserial(repo, nazwaPliku));
            Console.WriteLine("Wyświetlam tylko książki:");
            ShowBookList(Deserial(repo, nazwaPliku));

            Console.WriteLine("Sortowanie książek po autorze.");
            TestSortBooksByAuthor(Deserial(repo, nazwaPliku));
            ShowBookList(Deserial(repo, nazwaPliku));

            Console.WriteLine("Test repozytorium. Uwaga! W projekcie studenta" +
                "należy przygotować interfejs użytkownika z menu" +
                "umożliwiającym operowanie na repozytorium");
            /*
            // repozytorium
            BookstoreRepository repo = new BookstoreRepository();

            // dodanie do 
            repo.Add(b1);
            repo.Add(b2);
            repo.Add(cd1);
            repo.Add(b3);

            //TestRepository(repo);

            //Console.ReadKey();


            //Serializacja - praca własna
            TestSerializacji(repo, "pierwszaProba");
            */
        }
    }
}
