using System;
using System.Collections.Generic;

namespace IPB2.WinFormsApp.Database.AppDbContextModels;

public partial class TblStudent
{
    public string StudentId { get; set; } = null!;

    public string StudentName { get; set; } = null!;

    public int Age { get; set; }

    public string ClassNo { get; set; } = null!;

    public string MobileNo { get; set; } = null!;

    public string ParentName { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public decimal Fees { get; set; }
}
