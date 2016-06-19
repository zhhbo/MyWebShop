﻿using MyWebShop.Models;
using Orchard.ContentManagement.Handlers;
using Orchard.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWebShop.Handlers
{
    public class OrderPartHandle : ContentHandler
    {
        public OrderPartHandle(IRepository<OrderPartRecord> repository)
        {
            Filters.Add(StorageFilter.For(repository));

        }
    }
}