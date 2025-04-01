using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    //Factory Class
    public class FactoryClass
    {
        private readonly Dictionary<string, IFactory> dic;

        public FactoryClass()
        {
            dic = new Dictionary<string, IFactory>();
        }


        public IFactory GetFactoryObject(string value)
        {
            return dic.TryGetValue(value, out var factory) ? factory : throw new ArgumentException("Invalid key");
        }
         public void SetFactoryObject(string value, IFactory db)
        {
            if(!dic.ContainsKey(value))  dic.Add(value, db);
        }
    }




    //Interface
    public interface IFactory
    {
        public void AddEmployee();
    }



    


    //Classes implementing Interface
    public class SQLClaass : IFactory
    {
        public void AddEmployee()
        {

        }

    }
     public class OracleClass : IFactory
    {
        public void AddEmployee()
        {

        }
    }
}