using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportantInterfaces
{
    public class PeopleEnumerator : IEnumerator<Person>
    {
        private Person[] _people;
        private int _index;
        public Person Current
        {
            get { return _people[_index]; }
        }

        object IEnumerator.Current => Current;

        public PeopleEnumerator(Person[] people)
        {
            _people = people;
        }

        public void Dispose()
        {
            Reset();
        }

        public bool MoveNext()
        {
            _index++;
            return _index < _people.Length;
        }

        public void Reset()
        {
            _index = -1;
        }
    }
}
