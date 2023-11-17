namespace MultiThreading;

public partial class FrmMain : Form
{
    public FrmMain()
    {
        InitializeComponent();
        LogManager.Default.OnLogAdded += (s, e) => { AddLog(e); };
    }

    private void AddLog(string logMessage)
    {
        if (LbLogs.InvokeRequired)
        {
            LbLogs.Invoke(new Action(() => AddLog(logMessage)));
            return;
        }

        LbLogs.Items.Add($"[{DateTime.Now:dd.MM.yyyy HH:mm:ss:fff}] - {logMessage}");
        LbLogs.SelectedIndex = LbLogs.Items.Count - 1;
    }

    private void BtnListMailTasks_Click(object sender, EventArgs e)
    {
        var smtpMailTask = new MailTask(Models.MailProviderType.Smtp)
        {
            Second = 10
        };

        var googleMailTask = new MailTask(Models.MailProviderType.GoogleMail)
        {
            Second = 60
        };

        MailTaskBindingSource.Clear();
        MailTaskBindingSource.Add(smtpMailTask);
        MailTaskBindingSource.Add(googleMailTask);
    }

    private void MailTaskBindingSource_CurrentItemChanged(object sender, EventArgs e)
    {
        if (MailTaskBindingSource.Current is not MailTask mailTask) return;
        BtnStartTask.Enabled = !mailTask.IsStarted;
        BtnStopTask.Enabled = mailTask.IsStarted;
        BtnRunTask.Enabled = mailTask.IsStarted && !mailTask.IsRunning;
    }

    private void BtnStartTask_Click(object sender, EventArgs e)
    {
        if (MailTaskBindingSource.Current is not MailTask mailTask) return;
        mailTask.Start();
    }

    private void BtnStopTask_Click(object sender, EventArgs e)
    {
        if (MailTaskBindingSource.Current is not MailTask mailTask) return;
        mailTask.Stop();
    }

    private async void BtnRunTask_Click(object sender, EventArgs e)
    {
        if (MailTaskBindingSource.Current is not MailTask mailTask) return;
        await mailTask.Run(50);
    }
}