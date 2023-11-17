namespace MultiThreading;

partial class FrmMain
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            this.LbLogs = new System.Windows.Forms.ListBox();
            this.BtnListMailTasks = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnStartTask = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnRunTask = new System.Windows.Forms.Button();
            this.BtnStopTask = new System.Windows.Forms.Button();
            this.TaskId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProviderType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ısRunningDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ısStartedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.secondDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextRunningDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MailTaskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MailTaskBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LbLogs
            // 
            this.LbLogs.BackColor = System.Drawing.Color.Silver;
            this.LbLogs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LbLogs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LbLogs.FormattingEnabled = true;
            this.LbLogs.ItemHeight = 20;
            this.LbLogs.Location = new System.Drawing.Point(0, 349);
            this.LbLogs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LbLogs.Name = "LbLogs";
            this.LbLogs.Size = new System.Drawing.Size(883, 164);
            this.LbLogs.TabIndex = 0;
            // 
            // BtnListMailTasks
            // 
            this.BtnListMailTasks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnListMailTasks.Location = new System.Drawing.Point(12, 10);
            this.BtnListMailTasks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnListMailTasks.Name = "BtnListMailTasks";
            this.BtnListMailTasks.Size = new System.Drawing.Size(859, 58);
            this.BtnListMailTasks.TabIndex = 1;
            this.BtnListMailTasks.Text = "List Mail Tasks";
            this.BtnListMailTasks.UseVisualStyleBackColor = true;
            this.BtnListMailTasks.Click += new System.EventHandler(this.BtnListMailTasks_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaskId,
            this.ProviderType,
            this.ısRunningDataGridViewCheckBoxColumn,
            this.ısStartedDataGridViewCheckBoxColumn,
            this.secondDataGridViewTextBoxColumn,
            this.nextRunningDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.MailTaskBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 202);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(883, 147);
            this.dataGridView1.TabIndex = 2;
            // 
            // BtnStartTask
            // 
            this.BtnStartTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnStartTask.Enabled = false;
            this.BtnStartTask.Location = new System.Drawing.Point(6, 13);
            this.BtnStartTask.Name = "BtnStartTask";
            this.BtnStartTask.Size = new System.Drawing.Size(122, 40);
            this.BtnStartTask.TabIndex = 3;
            this.BtnStartTask.Text = "Start";
            this.BtnStartTask.UseVisualStyleBackColor = true;
            this.BtnStartTask.Click += new System.EventHandler(this.BtnStartTask_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnRunTask);
            this.groupBox1.Controls.Add(this.BtnStopTask);
            this.groupBox1.Controls.Add(this.BtnStartTask);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(883, 59);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // BtnRunTask
            // 
            this.BtnRunTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRunTask.Enabled = false;
            this.BtnRunTask.Location = new System.Drawing.Point(755, 13);
            this.BtnRunTask.Name = "BtnRunTask";
            this.BtnRunTask.Size = new System.Drawing.Size(122, 40);
            this.BtnRunTask.TabIndex = 5;
            this.BtnRunTask.Text = "Run";
            this.BtnRunTask.UseVisualStyleBackColor = true;
            this.BtnRunTask.Click += new System.EventHandler(this.BtnRunTask_Click);
            // 
            // BtnStopTask
            // 
            this.BtnStopTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnStopTask.Enabled = false;
            this.BtnStopTask.Location = new System.Drawing.Point(134, 13);
            this.BtnStopTask.Name = "BtnStopTask";
            this.BtnStopTask.Size = new System.Drawing.Size(122, 40);
            this.BtnStopTask.TabIndex = 4;
            this.BtnStopTask.Text = "Stop";
            this.BtnStopTask.UseVisualStyleBackColor = true;
            this.BtnStopTask.Click += new System.EventHandler(this.BtnStopTask_Click);
            // 
            // TaskId
            // 
            this.TaskId.DataPropertyName = "TaskId";
            this.TaskId.HeaderText = "TaskId";
            this.TaskId.MinimumWidth = 6;
            this.TaskId.Name = "TaskId";
            this.TaskId.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ProviderType";
            this.dataGridViewTextBoxColumn1.HeaderText = "ProviderType";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 415;
            // 
            // ProviderType
            // 
            this.ProviderType.DataPropertyName = "ProviderType";
            this.ProviderType.HeaderText = "ProviderType";
            this.ProviderType.MinimumWidth = 6;
            this.ProviderType.Name = "ProviderType";
            // 
            // ısRunningDataGridViewCheckBoxColumn
            // 
            this.ısRunningDataGridViewCheckBoxColumn.DataPropertyName = "IsRunning";
            this.ısRunningDataGridViewCheckBoxColumn.HeaderText = "IsRunning";
            this.ısRunningDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.ısRunningDataGridViewCheckBoxColumn.Name = "ısRunningDataGridViewCheckBoxColumn";
            this.ısRunningDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // ısStartedDataGridViewCheckBoxColumn
            // 
            this.ısStartedDataGridViewCheckBoxColumn.DataPropertyName = "IsStarted";
            this.ısStartedDataGridViewCheckBoxColumn.HeaderText = "IsStarted";
            this.ısStartedDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.ısStartedDataGridViewCheckBoxColumn.Name = "ısStartedDataGridViewCheckBoxColumn";
            this.ısStartedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // secondDataGridViewTextBoxColumn
            // 
            this.secondDataGridViewTextBoxColumn.DataPropertyName = "Second";
            this.secondDataGridViewTextBoxColumn.HeaderText = "Second";
            this.secondDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.secondDataGridViewTextBoxColumn.Name = "secondDataGridViewTextBoxColumn";
            this.secondDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nextRunningDataGridViewTextBoxColumn
            // 
            this.nextRunningDataGridViewTextBoxColumn.DataPropertyName = "NextRunning";
            this.nextRunningDataGridViewTextBoxColumn.HeaderText = "NextRunning";
            this.nextRunningDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nextRunningDataGridViewTextBoxColumn.Name = "nextRunningDataGridViewTextBoxColumn";
            this.nextRunningDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // MailTaskBindingSource
            // 
            this.MailTaskBindingSource.AllowNew = false;
            this.MailTaskBindingSource.DataSource = typeof(MultiThreading.MailTask);
            this.MailTaskBindingSource.CurrentItemChanged += new System.EventHandler(this.MailTaskBindingSource_CurrentItemChanged);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 513);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnListMailTasks);
            this.Controls.Add(this.LbLogs);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mail App";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MailTaskBindingSource)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private ListBox LbLogs;
    private Button BtnListMailTasks;
    private DataGridView dataGridView1;
    private BindingSource MailTaskBindingSource;
    private Button BtnStartTask;
    private GroupBox groupBox1;
    private Button BtnStopTask;
    private Button BtnRunTask;
    private DataGridViewTextBoxColumn TaskId;
    private DataGridViewTextBoxColumn ProviderType;
    private DataGridViewCheckBoxColumn ısRunningDataGridViewCheckBoxColumn;
    private DataGridViewCheckBoxColumn ısStartedDataGridViewCheckBoxColumn;
    private DataGridViewTextBoxColumn secondDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn nextRunningDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
}
