﻿using IntexQueensSlay.Data;
using IntexQueensSlay.Models;

namespace IntexQueensSlay.Models
{
    public interface ISlayRepository
    {
        public IQueryable<Customer> Customers { get; }
        public IQueryable<Product> Products { get; }
        public IQueryable<LineItem> LineItems { get; }
        public IQueryable<Order> Orders { get; }
        public IQueryable<AspNetUsers> AspNetUserss { get; }

        Product GetProductById(int id);
        void AddProduct(Product product);

        void RemoveProduct(Product product);

        void RemoveCustomer(Customer customer);
   
        void Update(Product product);
        void SaveChanges();

        public void AddCustomer(Customer task);
        public void EditCustomer(Customer task);

        Customer GetCustomerById(int id);

        Order GetOrderById(int id);

        void UpdateCustomer(Customer customer);
    }
}


