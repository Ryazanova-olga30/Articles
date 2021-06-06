using System;
using System.Collections.Generic;

namespace ConsoleApp19
{
    public class Request
    {
        private string _orderCode;
        public string client;
        public DateTime dateOfOrder;
        public List<Article> items;
        private int _orderCost;
        public int sum;
        public RequestItem amount;
        public PayType payType;

        public int GetCost()
        {
            sum = 0;
            foreach (Article item in items)
            {
                sum += item.price * amount.amount;
            }
            return sum;
        }
    }
}