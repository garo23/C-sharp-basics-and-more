﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinance
{
    public class ExpenseType
    {
       private string name;

        public ExpenseType()
        {
        }

        public ExpenseType(string name)
        {
            Name = name; 
        }

        public string Name { get; set; }

    }
}
   

