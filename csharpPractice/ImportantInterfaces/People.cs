using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportantInterfaces
{
    public class People : IEnumerable<Person>, ICollection<Person>
    {
        private List<Person> _persons;

        public int Count => _persons.Count;

        public bool IsReadOnly => false;

        public People()
        {
            _persons = new List<Person>();
        }

        public void Add(Person item)
        {
            _persons.Add(item);
        }

        public void Clear()
        {
            _persons.Clear();
        }

        public bool Contains(Person item)
        {
            return _persons.Contains(item);
        }

        public void CopyTo(Person[] array, int arrayIndex)
        {
            _persons.CopyTo(array, arrayIndex);
        }

        public IEnumerator<Person> GetEnumerator()
        {
            return new PeopleEnumerator(_persons.ToArray());
        }

        public bool Remove(Person item)
        {
            return (_persons.Remove(item));
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
