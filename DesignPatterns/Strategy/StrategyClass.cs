using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class StrategyClass
    {
        private IStrategy _strategy;

        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public int GetStrategyValue(int a , int b)
        {
           if (_strategy == null) throw new InvalidOperationException("Strategy is not set.");
            return _strategy.Calculate(a , b);
        }
    }




    public interface IStrategy
    {
        public int Calculate(int a , int b);
    }

    public class AlgorithmA : IStrategy
    {
        public int Calculate(int a, int b) => a + b;
    }

    public class AlgorithmB : IStrategy
    {
        public int Calculate(int a, int b) =>  a * b;
    }
}