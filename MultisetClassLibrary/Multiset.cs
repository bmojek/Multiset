using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MultisetClassLibrary
{
    public class Multiset<T> : IMultiSet<T>
    {
        private Dictionary<T, int> mset = new Dictionary<T, int>();

        #region ctor's
        public Multiset() { }

        #endregion
        public override string ToString()
        {
            StringBuilder wynik = new StringBuilder("{");
            foreach(var x in mset)
            {
                wynik.Append($"{x.Key}:{x.Value}, ");
            }
            return wynik.ToString(0,wynik.Length-2)+"}";
        }

        public IMultiSet<T> Add(T item, int numberOfItems = 1)
        {
            if (mset.ContainsKey(item))
                mset[item] += numberOfItems;
            else
                mset.Add(item, 1);
            return this;
        }

        public void Add(T item) => this.Add(item, 1);
        public int Count => mset.Values.Sum();
        public bool IsEmpty => mset.Count == 0;
        public bool IsReadOnly => false;

      /*  public int GetIndex(T item)
        {
            foreach(var x in mset)
            {
                if(x.Key.Equals(item))
                {
                    return x.Value;
                }
            }
            return 0;
        }*/

        public IMultiSet<T> Remove(T item, int numberOfItems = 1)
        {
            return this;
        }

        public bool Remove(T item)
        {
            foreach (var x in mset)
            {
                if (x.Key.Equals(item))
                {
                    mset.Remove(item);
                    return true;
                }
            }
            return false;
        }

        public IMultiSet<T> RemoveAll(T item)
        {
            foreach (var x in mset)
            {
                if (x.Key.Equals(item))
                {
                    mset.Remove(item);
                }
            }
            return this;
        }

        public int this[T item] => throw new NotImplementedException();
        public IEqualityComparer<T> Comparer => throw new NotImplementedException();

        public IReadOnlyDictionary<T, int> AsDictionary()
        {
            throw new NotImplementedException();
        }

        public IReadOnlySet<T> AsSet()
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IMultiSet<T> ExceptWith(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public IMultiSet<T> IntersectWith(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public bool IsProperSubsetOf(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public bool IsProperSupersetOf(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public bool IsSubsetOf(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public bool IsSupersetOf(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public bool MultiSetEquals(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public bool Overlaps(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public IMultiSet<T> SymmetricExceptWith(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public IMultiSet<T> UnionWith(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
