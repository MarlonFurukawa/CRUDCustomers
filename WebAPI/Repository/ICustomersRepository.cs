﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDCustomersWebAPI.Models
{
    public interface ICustomersRepository
    {
        List<Customers> GetCustomers();
    }
}