﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Concrete
{
    public class EFCustomers : Domain.Abstract.ICustomers
    {
        private Domain.EFDBContext context = new EFDBContext();

        public IQueryable<Customers> Customers
        {
            get { return context.Customers; }
        }

        public bool SaveCustomer(Customers customer, out string err)
        {
            err = "";
            if (0 == customer.ID)
            {
                if (Customers.Where<Customers>(x => x.Email == customer.Email).Count<Customers>() > 0)
                {
                    err = "已存在该用户名";
                    return false;
                }
                context.Customers.Add(customer);
            }
            else
            {
                Customers old = context.Customers.Find(customer.ID);
                context.Entry(old).CurrentValues.SetValues(customer);
            }
            return context.SaveChanges() > 0 ? true : false;

        }
        public Customers GetCustomerById(int id)
        {
            return Customers.Where<Customers>(x => x.ID == id).FirstOrDefault<Customers>();
        }
    }
}
