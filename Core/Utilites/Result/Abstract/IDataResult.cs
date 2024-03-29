﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilites.Result.Abstract
{
    public interface IDataResult<T> : IResult
    {
        T Data { get; set; }
    }
}
