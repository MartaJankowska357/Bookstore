using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace RepositoryLibrary
{
    [Serializable]
    public class Repository<T> where T : IComparable
    {
        protected T[] elements;

        // skorzystamy z kolekcji ObservableCollection, gdy będziemy chcieli powiadamiać
        // o zmianach w kolekcji - moduł delegaty i zdarzenia

        // public ObservableCollection<T> oc; 
        public T[] GetElements
        {
            get { return elements; }
        }

        public Repository()
        {
            elements = new T[0];
            // oc = new ObservableCollection<T>(); // inicjalizacja kolekcji
        }

        public virtual void Serializuj( string nazwa)
        {
            FileStream path = null; 
            BinaryFormatter bform = new BinaryFormatter();

            path = new FileStream(nazwa + ".dat", FileMode.Create);
            bform.Serialize(path, elements);
           
            path.Close();
           
        }

        public virtual List<T> Deserializacja(string nazwaPliku)
        {
            FileStream path = new FileStream(nazwaPliku + ".dat", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            T[] zdeserializowane = (T[]) bf.Deserialize(path);
            path.Close();
            List<T> lista = zdeserializowane.ToList();
            return lista;
        }


      









        public void Add(T element)
        {
            Array.Resize(ref elements, elements.Length + 1);

            elements[elements.Length - 1] = element;

        }

        // zwraca elementy jako listę
        public virtual List<T> ToList()
        {
            return elements.ToList();
        }

        public void Sort()
        {
            Array.Sort(elements);
        }

        // sprawdzenie, czy obiekt istnieje w repozytorium
        
        public bool Exists(T element)
        {
            return Array.Exists(elements, x => (x != null && x.Equals(element)));
            //DO ZAPAMIĘTANIA!!!
        }
        // zwraca wszystkie obiekty spełniające warunek:
        // tekst z ToString zawiera ciąg znaków text
        public T[] Select(string text)
        {
            return Array.FindAll(elements, x => x != null && x.ToString().Contains(text));
            //DO ZAPAMIĘTANIA!!!
        }

        public int FindIndex(T element)
        {
            return Array.FindIndex(elements, y => y.CompareTo(element) == 0);
            //DO ZAPAMIĘTANIA!!!
        }

        public int FindIndex(string text)
        {
            return Array.FindIndex(elements, y => y.ToString().Contains(text));
            //DO ZAPAMIĘTANIA!!!
        }

        public override string ToString()
        {
            string output = "";

            for (int i = 0; i < elements.Length; i++)
            {
                output += elements[i] + "\n";
            }
            return output;
        }
    }
}
