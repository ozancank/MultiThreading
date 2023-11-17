using MultiThreading.MailProviders;
using MultiThreading.MailProviders.Base;
using MultiThreading.Models;

namespace MultiThreading;

internal class MailProviderFactory
{
    public static BaseProvider CreateProvider(MailProviderType mailProviderType)
    {
        return mailProviderType switch
        {
            MailProviderType.Smtp => new SmtpProvider(),
            MailProviderType.GoogleMail => new GoogleMailProvider(),
            _ => throw new NotSupportedException(),
        };
    }
}