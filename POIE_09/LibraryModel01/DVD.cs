using System;

namespace BookstoreModel
{
    public class DVD
    {
        private string title;
        private string author;
        private string publisher;
        private double price;

        private double Price
        {
            get { return price; }
        }

        public DVD(string title, string author, string publisher, double price)
        {
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            this.price = price;                
        }
    }
}
