using System.Collections;

namespace ITI.UI.DP.Iterator
{
    abstract class Iterator : IEnumerator
    {
        public abstract bool MoveNext();
        public abstract void Reset();
        object IEnumerator.Current => BeforeCurrent();
        public abstract object BeforeCurrent();
    }
}