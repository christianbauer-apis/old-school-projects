﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication5
{
    interface ITransaction
    {
       string Name{get; set;}
        void TotalCharge();
    }
}
