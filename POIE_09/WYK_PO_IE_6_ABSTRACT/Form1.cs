using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

using BookstoreModel;

namespace Bookstore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // private List<Item> itemList = new List<Item>(); // z listy już nie będziemy korzystać
        // i tworzymy repozytorium - teraz dane będziemy przechowywać w repozytorium
        private BookstoreRepository repository = new BookstoreRepository();

        private void Form1_Load(object sender, EventArgs e)
        {

            // obiekty tworzymy za każdym razem, gdy aplikacja jest uruchamiana
            // i Form1 zostaje załadowany
            // Przydałoby się tutaj repozytorium danych, np. w pliku. Stworzymy je na zajęciach Serializacja 

            Book b1 = new Book("Quo Vadis?", "Henryk Sienkiewicz", "DR42145", 342, "Znak", 34.50M);
            Book b2 = new Book("Pan Tadeusz", "Adam Mickiewicz", "GF764", 231, "WSiP", 54.67M);
            Book b3 = new Book("Balladyna", "Juliusz Słowacki", "KU64875", 121, "WSiP", 31.98M);
            Book b4 = new Book("Chłopi", "Władysław Reymont", "OY6076", 452, "PWN", 74.20M);
            Book b5 = new Book("Lalka", "Bolesław Prus", "LOU75634", 224, "PWN", 39.70M);
            CD cd1 = new CD("Achtung Baby", "U2", 11, "", 32.99M);
            CD cd2 = new CD("Change of seasons", "Dream Theater", 5, "", 37.99M);

            repository.Add(b1);
            repository.Add(b2);
            repository.Add(b3);
            repository.Add(b4);
            repository.Add(b5);
            repository.Add(cd1);
            repository.Add(cd2);

            // aby w listBox1 wyświetlić jedynie książki, wykorzystamy Linq
            listBox1.DataSource = repository.ToList(typeof(Book)); // tu było itemList.Where(x => x is Book).ToList();
            // listbox2 zawiera tylko CD
            listBox2.DataSource = repository.ToList(typeof(CD)); //itemList.Where(x => x is CD).ToList();

        }   

        private void btnCalculateAvgPrice_Click(object sender, EventArgs e)
        {
            decimal sum = 0;
            int counter = 0;

            foreach (var item in repository.ToList())
            {
                sum += item.CalculateGrossPrice();
                counter++;
            }

            MessageBox.Show("Avg price = " + sum / counter);

        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            // aby dodać nowy obiekt, musimy go utworzyć
            // konstruktor nie jest kompletny, bo pobiera wartości tylko dwóch pól
            Item newBook = new Book(txtBookTitle.Text, txtBookAuthor.Text, "ISBN", 12, "Publisher", 10);

            // dodanie obiektu do listy
            repository.Add(newBook);

            // czyścimy textboxy i wyświetlamy messageBox
            txtBookTitle.Text = "";
            txtBookAuthor.Text = "";
            MessageBox.Show("Dodano książkę");

            // aktualizacja danych wyświetlanych na liście 
            listBox1.DataSource = null;
            // aby w listBox1 wyświetlić jedynie książki, wykorzystamy Linq
            // z itemList za pomocą Where wybieramy elementy, które spełniają następujący warunek
            // tzn. dla których wyrażenie x is Book zwraca true
            // x => x is Book 
            // .ToList() zmienia wynik działania klauzuli Where na listę
            listBox1.DataSource = repository.ToList(typeof(Book));

        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            decimal priceNet = 0, priceGross = 0, taxAmount = 0;

            foreach (var item in repository.ToList())
            {
                priceNet += item.CalculateGrossPrice() - item.CalculateTax();
                priceGross += item.CalculateGrossPrice();
                taxAmount += item.CalculateTax();
            }

            string reportTxt = $"Raport sumaryczny: \n"
                + $"Wartość netto: {priceNet}\n"
                + $"Wartość brutto: {priceGross}\n" 
                + $"Podatek: {taxAmount}";

            MessageBox.Show(reportTxt);
        }

        private void btnBookReport_Click(object sender, EventArgs e)
        {
            decimal priceNet = 0, priceGross = 0, taxAmount = 0;

            foreach (var item in repository.ToList())
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

            MessageBox.Show(reportTxt);
        }

        private void btnSortPrice_Click(object sender, EventArgs e)
        {
            repository.Sort();

            listBox1.DataSource = null;
            listBox1.DataSource = repository.ToList(typeof(Book));
        }

        private void btnSortAuthor_Click(object sender, EventArgs e)
        {
            repository.Sort(new Book.ByAuthor());
            listBox1.DataSource = null;
            listBox1.DataSource = repository.ToList(typeof(Book));
        }

        private void btnSorrtTitle_Click(object sender, EventArgs e)
        {
            repository.Sort(new Book.ByTitle());
            listBox1.DataSource = null;
            listBox1.DataSource = repository.ToList(typeof(Book));
        }
    }
}
