﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public interface IProductRepository
    {
        void Save(Product product);
    }
}
