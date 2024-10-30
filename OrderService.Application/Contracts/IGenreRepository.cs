﻿using OrderServise.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.Application.Contracts
{
    public interface IGenreRepository:IBaseRepositoryAsync<Genre>
    {
    }
}
