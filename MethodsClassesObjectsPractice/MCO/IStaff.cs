﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MCO
{
    public interface IStaff
    {

        string FirstName { get; set; }

        string LastName { get; set; }

        DateTime StartDate { get; set; }

    }
}
