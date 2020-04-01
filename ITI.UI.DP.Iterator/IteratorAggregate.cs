using System.Collections;

namespace ITI.UI.DP.Iterator
{
    abstract class IteratorAggregate : IEnumerable
    {
        public abstract IEnumerator GetEnumerator();
    }
}