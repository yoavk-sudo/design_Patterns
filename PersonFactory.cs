using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_Patterns
{
    internal class PersonFactory
    {
        public static IPerson Create(Person person)
        {
            switch (person)
            {
                case Person.Reader:
                    return new Reader();
                case Person.Athlete:
                    return new Athlete();
                case Person.Progammer:
                    return new Programmer();
                    default:
                    throw new NotSupportedException(
                        $"{person} is not a person, probably an alien in disguise. " +
                        $"Did you mean Programmer perhaps?");
            }
        }
    }
}
