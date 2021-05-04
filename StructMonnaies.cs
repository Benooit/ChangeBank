using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateurDeMonnaies
{
    struct StructMonnaies
    {
        public StructMonnaies(decimal qtyOf5cents, decimal qtyOf10cents, decimal qtyOf25cents, decimal qtyOf1dollars, decimal qtyOf2dollars)
        {
            this.QtyOf5cents = qtyOf5cents;
            this.QtyOf10cents = qtyOf10cents;
            this.QtyOf25cents = qtyOf25cents;
            this.QtyOf1dollars = qtyOf1dollars;
            this.QtyOf2dollars = qtyOf2dollars;
            InputDate = DateTime.Now;
        }

        [JsonConstructor]
        public StructMonnaies(DateTime inputDate, decimal qtyOf5cents, decimal qtyOf10cents, decimal qtyOf25cents, decimal qtyOf1dollars, decimal qtyOf2dollars)
        {
            this.InputDate = inputDate;
            this.QtyOf5cents = qtyOf5cents;
            this.QtyOf10cents = qtyOf10cents;
            this.QtyOf25cents = qtyOf25cents;
            this.QtyOf1dollars = qtyOf1dollars;
            this.QtyOf2dollars = qtyOf2dollars;
        }

        public DateTime InputDate { get; }
        public decimal QtyOf5cents { get; }
        public decimal QtyOf10cents { get; }
        public decimal QtyOf25cents { get; }
        public decimal QtyOf1dollars { get; }
        public decimal QtyOf2dollars { get; }

        [JsonIgnore]
        public decimal TotalValue 
        {
            get { return ValueOf5cents + ValueOf10cents + ValueOf25cents + ValueOf1dollars + ValueOf2dollars; }
        }
        [JsonIgnore]
        public decimal ValueOf5cents
        {
            get { return QtyOf5cents * (decimal)0.05; }
        }
        [JsonIgnore]
        public decimal ValueOf10cents
        {
            get { return QtyOf10cents * (decimal)0.10; }
        }
        [JsonIgnore]
        public decimal ValueOf25cents
        {
            get { return QtyOf25cents * (decimal)0.25; }
        }
        [JsonIgnore]
        public decimal ValueOf1dollars
        {
            get { return QtyOf1dollars; }
        }
        [JsonIgnore]
        public decimal ValueOf2dollars
        {
            get { return QtyOf2dollars * 2; }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
