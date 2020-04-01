namespace ITI.UI.DP.Iterator
{
    class WordsIterator:Iterator
    {
        private WordCollection _collection;
        private bool _direction;
        private int _position = -1;
        public WordsIterator(WordCollection collection, bool reverse)
        {
            _collection = collection;
            _direction = reverse;
            if (reverse)
            {
                _position = _collection.GetItems().Count;
            }
        }
        public override bool MoveNext()
        {
            int updatedPosition = _position + (_direction ? -1 : +1);
            if (updatedPosition >=0 && updatedPosition< _collection.GetItems().Count)
            {
                _position = updatedPosition;
                return true;
            }

            return false;
        }

        public override void Reset()
        {
            _position = _direction ? _collection.GetItems().Count : 0;
        }

        public override object BeforeCurrent()
        {
            var item = _collection.GetItems()[_position];
            item = $"{item} before";
            return item;
        }
    }
}