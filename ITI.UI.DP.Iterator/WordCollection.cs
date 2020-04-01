using System.Collections;
using System.Collections.Generic;

namespace ITI.UI.DP.Iterator
{
    class WordCollection : IteratorAggregate
    {
        private List<string> _collection = new List<string>();
        private bool _direction = false;

        public List<string> GetItems()
        {
            return _collection;
        }

        public void AddItem(string value)
        {
            _collection.Add(value);
        }

        public void ReverseDirection()
        {
            _direction = !_direction;
        }
        public override IEnumerator GetEnumerator()
        {
            return new WordsIterator(this, _direction);
        }
    }
}