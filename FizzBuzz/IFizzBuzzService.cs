using System.Collections.Generic;

namespace FizzBuzz
{
    internal interface IFizzBuzzService
    {
        ///<summary>
        ///Creates a new list where every number divisable by 3 is replaced with fizz and every number divisible by 5 is replaced by buzz
        ///</summary>
        IEnumerable<string> GetFizzBuzz();

        ///<summary>
        ///Creates a new reversed list where every number divisable by 9 is replaced with Jazz and every number divisible by 5 is replaced by Fuzz 
        ///</summary>
        IEnumerable<string> GetJazzFuzz();


        ///<summary>
        ///Creates a new list of given length where every index divisable by a key in the dictionary will be replaced by the value attached to the key
        ///</summary>
        IEnumerable<string> Create(Dictionary<int, string> dic, int length, bool descending = false);
    }
}