using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository<Person> repository = new Repository<Person>();
            repository.Insert(new Person());
            var people = repository.GetAllRecords();
        }
    }
}
