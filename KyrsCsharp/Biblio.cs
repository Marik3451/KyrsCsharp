using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static KyrcCsharp.Book;

namespace KyrcCsharp
{
    public class BiblioEnumerator : IEnumerator<Book>
    {
        private Biblio biblio;
        private int currentPosition = -1;

        public BiblioEnumerator(Biblio biblio)
        {
            if (biblio.Count > 0)
            {
                this.biblio = biblio;
                this.currentPosition = 0;
            }
        }
        public Book Current
        {
            get
            {

                if (currentPosition > 0)
                {
                    return biblio[currentPosition];
                }
                else
                {
                    throw new InvalidOperationException("Enumerator is not initialized.");
                }
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return biblio[currentPosition];
            }
        }

        public void Dispose()
        {

        }

        public bool MoveNext()
        {
            if (currentPosition + 1 < biblio.Count)
            {
                currentPosition++;
            }
            return currentPosition < biblio.Count;
        }

        public bool MovePrevious()
        {
            if (currentPosition - 1 >= 0)
            {
                currentPosition--;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            currentPosition = -1;
        }
    }

    public class Biblio : BindingList<Book>, IEnumerable<Book>
    {

        public IEnumerator<Book> GetEnumerator()
        {
            return new BiblioEnumerator(this);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}


