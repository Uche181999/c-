using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Iteratable;


namespace Iteratable
{
    class ListOfAnimals : IEnumerable<Animal>
    {
        List<Animal> animals = new List<Animal>();
        public ListOfAnimals(List<Animal> animals) => this.animals = animals;

        public Animal this[int index]
        {
            get { return animals[index]; }
            set { animals.Insert(index, value); }
        }
        public ListOfAnimals()
        {

        }


        IEnumerator<Animal> IEnumerable<Animal>.GetEnumerator()
        {
            return animals.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return animals.GetEnumerator();
        }
    }
}