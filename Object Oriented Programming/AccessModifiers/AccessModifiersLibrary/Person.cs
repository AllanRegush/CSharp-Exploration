using System.Collections.Generic;
using System.Text;

namespace AccessModifiersLibrary
{
    public class Person
    {
        protected string _middleName = "";
        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

    }
}
