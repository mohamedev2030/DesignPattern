using CreatinalDesignPattern.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatinalDesignPattern.Factory
{
    /// <summary>
    /// 1- Try Same Factory Example With Interface Also
    /// </summary>
   
    public abstract class CreditCardFactory
    {
        protected abstract CreditCard MakeProduct();

        public CreditCard CreateProduct()
        {
            CreditCard creditCard = MakeProduct();
            return creditCard;
        }
    }
}
