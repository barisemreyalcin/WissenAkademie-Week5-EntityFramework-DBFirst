﻿using System;
using System.Collections.Generic;

namespace DBFirstCoreSample.Models;

public partial class EmployeeManager
{
    public int? ManagerId { get; set; }

    public string Manager { get; set; } = null!;

    public string Employee { get; set; } = null!;

    public int EmployeeId { get; set; }
}
