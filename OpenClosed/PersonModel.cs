﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    internal class PersonModel : IApplicantModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public IAccounts accountProcessor { get; set; } = new Accounts();
    }
}
