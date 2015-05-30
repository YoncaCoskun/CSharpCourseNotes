using System;

namespace Yilmazlar.Domain
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime RegisterDate { get;  set; }
    }
}