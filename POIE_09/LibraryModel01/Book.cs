using System;
using System.Collections.Generic;

namespace BookstoreModel
{
    [Serializable]
    public class Book:Item
    {

        private string ISBN;
        private uint pageNumber;
        private string publisher;


        public override decimal CalculateGrossPrice()
        {
            return price + CalculateTax();
        }

        public override void UpdatePrice(decimal rate)
        {
            this.price = this.price * rate;
        }
        public override void UpdatePrice()
        {
            this.price = price - price * 0.1M;
        }
        public override decimal CalculateTax()
        {
            return price * 0.08M;
        }

        public Book(string title, string author, string ISBN, uint pageNumber, string publisher, decimal price)
            :base(title, author, price)
        {
            this.ISBN = ISBN;
            this.pageNumber = pageNumber;
            this.publisher = publisher;
        }

        public class ByAuthor : IComparer<Item>
        {
            public int Compare(Item x, Item y)
            {
                if (x is Book && y is Book)
                {
                    return (x as Book).author.CompareTo((y as Book).author);
                }
                return -1;
            }
        }

        public class ByTitle : IComparer<Item>
        {
            public int Compare(Item x, Item y)
            {
                if (x is Book && y is Book)
                {
                    return (x as Book).title.CompareTo((y as Book).title);
                }
                return -1;
            }
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Book) || base.Equals(obj) == false)
            {
                return false;
            }
            Book book = obj as Book;
            if (this.ISBN == book.ISBN && this.publisher == book.publisher)
            {
                return true;
            }
            return false;

        }
        public override string ToString()
        {
            return base.ToString() + " " + string.Format("{0} {1} {2}", ISBN, pageNumber, publisher);
        }


    }
}
