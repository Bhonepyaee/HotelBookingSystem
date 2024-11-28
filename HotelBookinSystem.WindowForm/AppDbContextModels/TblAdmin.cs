using System;
using System.Collections.Generic;

namespace HotelBookinSystem.WindowForm.AppDbContextModels;

public partial class TblAdmin
{
    public string UserId { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? ModifiedAt { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string? ModifiedBy { get; set; }

    public bool IsDeleted { get; set; }
}
