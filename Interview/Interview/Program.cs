using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository<Test_T<Test>, Test> rep = new Repository<Test_T<Test>, Test>();

            //SAVE 1 item in repository
            Test_T<Test> test_1 = new Test_T<Test>();
            test_1.Id = new Test();
            rep.Save(test_1);

            //GETALL items in repository. There is 1 item
            foreach (var item in rep.GetAll())
            {
                Console.WriteLine(item.Id.GetHashCode().ToString());
            }

            //GET
            var res = rep.Get(test_1.Id);

            //DELETE one item
            rep.Delete(test_1.Id);
        }
    }

    public class Test
    {

    }

    class Test_T<Test> : IStoreable<Test> // Implements interface IStoreable
    {
        Test id;
        public Test Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
    }

}
