﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Zza.Services
{
    [ServiceContract]
    public interface IZzaService
    {
        [OperationContract]
        List<Product> GetProducts();
        [OperationContract]
        List<Customer> GetProducts();
        [OperationContract]
        void SubmitOrder(Order order);
    }
}
