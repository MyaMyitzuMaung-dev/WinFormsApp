using System;
using System.Collections.Generic;

namespace IPB2.WinFormsApp.Database.AppDbContextModels;

public partial class Teacher
{
    public int TeacherId { get; set; }

    public string Name { get; set; } = null!;

    public string Phone { get; set; } = null!;
}
