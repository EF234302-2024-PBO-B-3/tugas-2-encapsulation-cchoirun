using System;

namespace Encapsulation.Invoicing
{
    public class Invoice
    {
        public string PartNumber { get; set; }
        public string PartDescription { get; set; }
        private int _quantity;
        private double _price;

        
        public Invoice(string partNumber, string partDescription, int quantity, double price)
        {
            PartNumber = partNumber;
            PartDescription = partDescription;
            Quantity = quantity; 
            Price = price; 
        }

        
        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value < 0 ? 0 : value; }
        }

       
        public double Price
        {
            get { return _price; }
            set { _price = value < 0 ? 0.0 : value; }
        }

        
        public double GetInvoiceAmount()
        {
            return _quantity * _price;
        }
    }
}
