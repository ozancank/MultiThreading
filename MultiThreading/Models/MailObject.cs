namespace MultiThreading.Models;

internal class MailObject
{
    public string? To { get; set; }
    public string? From { get; set; } = "sender@senderdomain.com";

    public MailProviderType ProviderType { get; set; }
}

internal enum MailProviderType : byte
{
    Smtp = 1,
    GoogleMail = 2
}