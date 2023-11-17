using MultiThreading.Models;
using System.ComponentModel;

namespace MultiThreading;

internal class MailTask(MailProviderType providerType) : INotifyPropertyChanged
{
    private bool _isRunning;
    private bool _isStarted;
    private DateTime? _nextRunning;

    public Guid TaskId { get; set; } = Guid.NewGuid();

    public MailProviderType ProviderType { get; set; } = providerType;

    public bool IsRunning
    {
        get => _isRunning; set
        {
            _isRunning = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsRunning)));
        }
    }

    public bool IsStarted
    {
        get => _isStarted; set
        {
            _isStarted = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsStarted)));
        }
    }

    public DateTime? NextRunning
    {
        get => _nextRunning; set
        {
            _nextRunning = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(NextRunning)));
        }
    }

    public int Second { get; set; } = 60;

    public event PropertyChangedEventHandler? PropertyChanged;

    public async Task Run(int number)
    {
        var manager = new MailManager();

        while (IsStarted)
        {
            IsRunning = true;

            var mails = ProviderType switch
            {
                MailProviderType.Smtp => FakeDataCreator.GetMails(number, ProviderType),
                MailProviderType.GoogleMail => FakeDataCreator.GetMails(number, ProviderType),
                _ => []
            };

            manager.AddMails(mails);

            await manager.SendAllMails();

            IsRunning = false;

            NextRunning = DateTime.Now.AddSeconds(Second);
            await Task.Delay(Second * 1000);
        }
    }

    public void Start()
    {
        IsStarted = true;
        NextRunning = DateTime.Now.AddSeconds(Second);
    }

    public void Stop()
    {
        IsStarted = false;
        NextRunning = null;
    }
}