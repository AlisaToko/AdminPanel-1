using MailKit.Net.Smtp;
using MimeKit;
namespace AdminPanel.Models
{
    public class EmailService
    {
        public async Task SendEmailAsync(string email, string subject, string message)
        {
            var emailMsg = new MimeMessage();
            emailMsg.From.Add(new MailboxAddress("Administration Bilimkana American", "adelinaabazbekova9@gmail.com"));
            emailMsg.To.Add(new MailboxAddress("", email));
            emailMsg.Subject = subject;
            emailMsg.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = message
            };
            using (var client = new SmtpClient())
            {
                await client.ConnectAsync("smtp.gmail.com", 465, true);
                await client.AuthenticateAsync("adelinaabazbekova98@gmail.com", "Adelina2007@");
                await client.SendAsync(emailMsg);
                await client.DisconnectAsync(true);

            }
        }
    }
}
