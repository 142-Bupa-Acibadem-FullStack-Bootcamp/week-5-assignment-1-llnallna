﻿using Microsoft.EntityFrameworkCore;
using NorthwindBupa.Dal.Abstract;
using NorthwindBupa.Dal.Concrete.EntityFramework.Repository;
using NorthwindBupa.Entity.Dto;
using NorthwindBupa.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindBupa.Dal.Concrete.EntityFramework.Repository
{
    public class QuarterlyOrderRepository : GenericRepository<QuarterlyOrder>, IQuarterlyOrderRepository
    {
        public QuarterlyOrderRepository(DbContext context) : base(context)
        {
        }
    }
}
