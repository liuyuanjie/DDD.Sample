﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Sample.Domain.IRepository
{
    public interface IStudentRepository
    {
        Student Get(int id);
    }
}
