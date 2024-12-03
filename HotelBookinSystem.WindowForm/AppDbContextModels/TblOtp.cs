using System;
using System.Collections.Generic;

namespace HotelBookinSystem.WindowForm.AppDbContextModels;

public partial class TblOtp
{
    public string Id { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public int OtpValue { get; set; }

    public DateTime CreatedAt { get; set; }

    public bool IsDeleted { get; set; }
}
