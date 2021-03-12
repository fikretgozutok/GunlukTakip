﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
    public class Event : IEntity
    {
        public int Id { get; set; }
        public string EventName { get; set; }
    }
}
