﻿using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    public interface ICharterService
    {
        Task<List<Charter>> GetAll();
        Task<Charter> GetById(int id);
        Task Create(Charter model);

        Task Update(Charter model);
        Task Delete(int id);
    }
}
