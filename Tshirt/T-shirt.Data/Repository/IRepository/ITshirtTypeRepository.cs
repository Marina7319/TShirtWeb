﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T_shirt.Models.Models;

namespace T_shirt.Data.Repository.IRepository
{
    public interface ITshirtTypeRepository : IRepository<TshirtType>
    {

        void Update(TshirtType obj);

        void Save();

    }
}