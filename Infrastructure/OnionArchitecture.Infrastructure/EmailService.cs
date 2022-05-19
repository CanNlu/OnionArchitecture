using OnionArchitecture.Application.Interfaces;

namespace OnionArchitecture.Infrastructure
{
    public class EmailService : IEmailService
    {
        public bool Send(string to, string message)
        {
            Console.WriteLine("mail sent");
            return true;
        }
    }
}
