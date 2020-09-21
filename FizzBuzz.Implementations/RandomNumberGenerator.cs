using System;
using FizzBuzz.Interfaces;

namespace FizzBuzz.Implementations 
{
    public class RandomNumberGenerator : IRandomNumberGenerator
    {
        public int Generate(int rangeFrom, int rangeTo)
        {
            Random random = new Random();
            return random.Next(rangeFrom, rangeTo);
        }
    }
}