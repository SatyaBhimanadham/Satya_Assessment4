using System;
using System.Collections.Generic;

namespace AssesmentOnEF.Entities;

public partial class Company
{
    public int CompanyId { get; set; }

    public string? Name { get; set; }

    public string? City { get; set; }

    public string? Address { get; set; }
}
