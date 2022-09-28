﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entities;
public class Client : BaseAuditableEntity
{
    public Client()
    {

    }

    public Client(FirstName firstName, string lastName, string email)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
    }

    public FirstName FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Email { get; private set; }
}
