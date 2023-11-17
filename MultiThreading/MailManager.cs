using MultiThreading.MailProviders.Base;
using MultiThreading.Models;
using System.Collections.Concurrent;

namespace MultiThreading;

internal class MailManager
{
    private readonly ConcurrentQueue<MailObject> _mailObjects = new();
    private readonly ConcurrentDictionary<MailProviderType, BaseProvider> _mailProviders = new();

    public void AddMails(IEnumerable<MailObject> mails)
    {
        foreach (var mail in mails)
        {
            _mailObjects.Enqueue(mail);
        }
    }

    public async Task SendAllMails()
    {
        LogManager.Default.Log("SendAllMails started!");
        LogManager.Default.Log($"{_mailObjects.Count} mails found!");

        while (_mailObjects.Any())
        {
            _mailObjects.TryDequeue(out var mail);
            var provider = GetProvider(mail.ProviderType);
            await provider.Send(mail);
        }

        LogManager.Default.Log("SendAllMails finished!");
    }

    private BaseProvider GetProvider(MailProviderType mailProviderType)
    {
        return _mailProviders.GetOrAdd(mailProviderType, (x) => MailProviderFactory.CreateProvider(mailProviderType));
    }
}