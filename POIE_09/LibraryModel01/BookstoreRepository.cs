using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryLibrary;
using BookstoreModel;

namespace BookstoreModel
{
    public class BookstoreRepository : Repository<Item>
    {

        // zwraca listę obiektów typu Type t umieszczonych w repozytorium
        // skorzystamy z tej medoty aktualizując listBox'y
        public List<Item> ToList(Type t)
        {
            return Array.FindAll(elements, x => x.GetType() == t).ToList();
            //DO ZAPAMIĘTANIA!!!
        }

        // sortuje po tytule
        //DO ZAPAMIĘTANIA!!!
        //dLACZEGO TO DZIAŁA???
        public void Sort(IComparer<Item> comparer)
        {
            Array.Sort(elements, comparer);
        }

        // dla wszystkich obiektów wykonuje metodę UpdatePrice
        public void UpdatePriceOfAllProducts()
        {
            // przykład wykorzystania ArrayForEach
            Array.ForEach(elements, x => x.UpdatePrice());
            //DO ZAPAMIĘTANIA!!!
        }

        public void ResetCodeOfAllProducts(decimal value)
        {
            // przykład wykorzystujący pętlę
            for (int i = 0; i < elements.Length; i++)
            {
                elements[i].ResetCode(value);
            }

        }

        // zwraca nowe repository zawierajace obiekty z ceną 
        // z przedziału (min; max)
        public BookstoreRepository GetProductsInPriceRange(decimal min, decimal max)
        {
            Item[] array = Array.FindAll(elements, x => (x.CalculateGrossPrice() > min && x.CalculateGrossPrice() < max));
            BookstoreRepository br = new BookstoreRepository();
            Array.ForEach(array, x => br.Add(x));
            return br;
            //DO ZAPAMIĘTANIA!!!
        }

        // sprawdza, czy dla wszystkich obiektów w repozytorium
        // podana cena jest większa od 0
        public bool IsValid()
        {
            return Array.TrueForAll(elements, x => x.CalculateGrossPrice() > 0);
            //DO ZAPAMIĘTANIA!!!
        }
    }
}
