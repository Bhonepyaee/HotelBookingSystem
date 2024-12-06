using FluentEmail.Core;
using HotelBookinSystem.WindowForm.AppDbContextModels;
using Microsoft.Extensions.DependencyInjection;

namespace HotelBookinSystem.WindowForm.Services;

public class OtpService
{
    internal readonly AppDbContext _context;
    internal readonly IFluentEmail _email;

    public OtpService(AppDbContext context)
    {
        _context = context;

        var serviceCollection = new ServiceCollection();
        serviceCollection
            .AddFluentEmail("lth1212001@gmail.com")
            .AddSmtpSender("smtp.gmail.com", 587, "lth1212001@gmail.com", "evzd omax jylb pdzn");
        var sericeProvider = serviceCollection.BuildServiceProvider();
        var _fluentEmail = sericeProvider.GetRequiredService<IFluentEmail>();

        _email = _fluentEmail;
    }

    #region Get Six Digit Random Number

    public string GetSixDigitRandomNumber()
    {
        Random r = new();
        int randNum = r.Next(100000, 1000000);
        return randNum.ToString();
    }

    #endregion

    #region Send Otp Via Email Async

    public async Task<string> SendOtpViaEmailAsync(
        string userId,
        string otpValue,
        string toEmail,
        string subject
    )
    {
        var otp = new TblOtp()
        {
            Id = Guid.NewGuid().ToString(),
            OtpValue = Convert.ToInt32(otpValue),
            CreatedAt = DateTime.Now,
            UserId = userId,
            IsDeleted = false,
        };
        await _context.TblOtps.AddAsync(otp);
        await _context.SaveChangesAsync();
        string body =
            $"Here is your OTP Code: {otpValue}. This Code will be expired within 3 minutes.";
        await _email.To(toEmail).Subject(subject).Body(body).SendAsync();

        return otp.Id;
    }

    #endregion
}
