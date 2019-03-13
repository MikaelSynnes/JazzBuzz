using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzService : IFizzBuzzService
    {
        public IEnumerable<string> GetFizzBuzz()
        {
            var dic = new Dictionary<int, string>();
            dic.Add(3, "Fizz");
            dic.Add(5, "Buzz");
            return Create(dic, 100);
        }

        public IEnumerable<string> GetJazzFuzz()
        {
            var dic = new Dictionary<int, string>();
            dic.Add(9, "Jazz");
            dic.Add(4, "Fuzz");
            return Create(dic, 100, true);
        }

        public IEnumerable<string> Create(Dictionary<int, string> dic, int length, bool descending = false)
        {
            List<string> list = new List<string>();
            for (int i = 1; i <= length; i++)
            {
                var found = false;
                var stringBuild = "";
                foreach (var result in dic)
                {
                    if (i % result.Key == 0)
                    {
                        stringBuild += result.Value;
                        found = true;
                    }
                }
                if (!found)
                    stringBuild = i.ToString();
                list.Add(stringBuild);
            }
            if (descending)
                list.Reverse();

            return list;
        }
    }
}

