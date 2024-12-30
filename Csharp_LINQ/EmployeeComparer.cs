﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_LINQ
{
    public class EmployeeComparer : IEqualityComparer<Employee>
    {
        public bool Equals([AllowNull] Employee x, [AllowNull] Employee y)
        {
            if (((x.Id == y.Id) && (x.FirstName.ToLower() == y.FirstName.ToLower())) && (x.LastName.ToLower() == y.LastName.ToLower()))
                return true;
            else
                return false;
        }

        public int GetHashCode([DisallowNull] Employee obj)
        {
            return obj.Id.GetHashCode();
        }
    }
}
