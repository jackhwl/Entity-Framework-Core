﻿using ChangeManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChangeManagementSystem.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<ChangeRequest> ChangeRequests { get; set; }

    }
}
