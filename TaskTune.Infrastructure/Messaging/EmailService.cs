using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;
using TaskTune.Core.Services.Messaging;
using TaskTune.Entities.Settings;


namespace TaskTune.Infrastructure.Messaging
{
    public class EmailService : IEmailService
    {
        private readonly IOptions<SendGridSettings> _sendGridSettings;

        public EmailService(IOptions<SendGridSettings> sendGridSettings)
        {
            _sendGridSettings = sendGridSettings;
        }

        public async Task SendEmailAsync(string email, string subject, string message)
        {
            var client = new SendGridClient(_sendGridSettings.Value.ApiKey);
            var from = new EmailAddress(_sendGridSettings.Value.FromEmail, _sendGridSettings.Value.FromName);
            var to = new EmailAddress(email);
            var msg = MailHelper.CreateSingleEmail(from, to, subject, message, message);
            await client.SendEmailAsync(msg);
        }
    }
}
