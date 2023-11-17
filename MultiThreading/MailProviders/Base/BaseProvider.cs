using MultiThreading.Models;

namespace MultiThreading.MailProviders.Base;

internal abstract class BaseProvider
{
    public short Port { get; set; } = 587;
    public string ServerHostName { get; set; } = "smtp.senderdomain.com";

    public abstract Task Send(MailObject mailObject);
}