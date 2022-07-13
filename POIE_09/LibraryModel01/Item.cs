using System;
using System.Collections.Generic;
using System.Text;

namespace BookstoreModel
{
    [Serializable]
    public abstract class Item : IComparable, IUpdatable, IResetable
    {
        protected string itemCode;
        protected string title;
        protected string author;
        protected decimal price;

        protected Item(string title, string author, decimal price)
        {
            this.title = title;
            this.author = author;
            this.price = price;
        }

        public abstract decimal CalculateTax();
        public abstract decimal CalculateGrossPrice();

        public abstract void UpdatePrice(decimal rate);

        public void ResetCode(decimal value)
        {
            if (this.price < value)
            {
                itemCode = "XU34";
            }
        }

        public abstract void UpdatePrice();

        public int CompareTo(object o)
        {
            Item tmp = o as Item;

            if (this.price > tmp.price)
            {
                return 1;
            }
            if (this.price == tmp.price)
            {
                return 0;
            }

            return -1;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Item))
            {
                return false;
            }
            Item item = obj as Item;
            if (this.itemCode == item.itemCode && this.author == item.author && this.title == item.title)
            {
                return true;
            }
            return false;

        }

        public override string ToString()
        {
            return title + " " + author + " " + price;
        }
    }
}
