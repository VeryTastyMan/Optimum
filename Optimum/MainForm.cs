using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optimum
{
    public partial class MainForm : Form
    {
        // System

        Color ColorDark = Color.FromArgb(255, 0, 80, 120);
        Color ColorLight = Color.FromArgb(255, 0, 110, 160);

        Color ColorWork = Color.FromArgb(255, 240, 100, 100);
        Color ColorCheck = Color.FromArgb(255, 255, 140, 70);
        Color ColorDone = Color.FromArgb(255, 0, 70, 100);

        enum ProcessStatus : byte
        {
            Check,
            Working,
            NotWorking,
            Done
        }


        class ProcessInfo
        {
            public ProcessInfo(string shortName, string fullName, string about)
            {
                ShortName = shortName;
                FullName = fullName;
                About = about;
            }
            public string ShortName { get; set; }
            public string FullName { get; set; }
            public string About { get; set; }

            public bool Working { get; set; }

            public Process LinkToProcess { get; set; }
        }

        List<ProcessInfo> ProcessesForDelete = new List<ProcessInfo>();

        List<Label> LabelInfo = new List<Label>();


        int ProccessesDropped = 0;



        // Start

        public MainForm()
        {
            InitializeComponent();

            BackColor = ColorLight;

            foreach (Control c in Controls)
                if (c is Button) c.BackColor = ColorDark;

            ProcessesForDelete.Add(new ProcessInfo("WU", "wuauclt", "Windows Update"));
            ProcessesForDelete.Add(new ProcessInfo("WMI", "TrustedInstaller", "Windows Modules Installer"));
            ProcessesForDelete.Add(new ProcessInfo("MMIW", "TiWorker", "Windows Modules Installer Worker"));
            ProcessesForDelete.Add(new ProcessInfo("MEU", "MicrosoftEdgeUpdate", "Microsoft Edge Update"));
            //ProcessesForDelete.Add(new ProcessInfo("NP", "notepad", "Notepad"));

            var AssemblyInfo = Assembly.GetExecutingAssembly().GetName();
            Text = $"{AssemblyInfo.Name} {AssemblyInfo.Version.Major}.{AssemblyInfo.Version.Minor}.{AssemblyInfo.Version.Build}";
            label_Info.Text = Text;

            GenerateTrayText();
            StartMenu();

            Size = new Size(320, (ProcessesForDelete.Count * 23) + 220);
            Location = new Point(Screen.PrimaryScreen.Bounds.Width - Size.Width - 5, Screen.PrimaryScreen.Bounds.Height - Size.Height - 45);

            AllProcesses();
        }



        // Form

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
                Hide();

            trayIcon.Visible = (WindowState == FormWindowState.Minimized);
        }



        // Functions

        void StartMenu()
        {
            for (int n = 0; n < ProcessesForDelete.Count; n++)
            {
                Label NewLabel = new Label()
                {
                    Parent = this,
                    Location = new Point(5, 45 + (n * 23)),
                    AutoSize = true,
                    Font = new Font("Arial Narrow", 12F, FontStyle.Regular),
                    Text = ProcessesForDelete[n].About
                };

                Label NewLabelInfo = new Label()
                {
                    Parent = this,
                    Location = new Point(NewLabel.Size.Width + 5, 47 + (n * 23)),
                    AutoSize = true,
                    Font = new Font("Arial Narrow", 10F, FontStyle.Regular),
                };

                LabelInfo.Add(NewLabelInfo);

                LabelInfoSetStatus(n, ProcessStatus.Check);
            }
        }

        void AllProcesses()
        {
            Process[] ProcessesList = Process.GetProcesses();

            for (int n = 0; n < ProcessesForDelete.Count; n++)
            {
                Process LinkToProcess = ProcessesList.FirstOrDefault((x) => x.ProcessName == ProcessesForDelete[n].FullName);

                if (LinkToProcess != null)
                {
                    ProcessesForDelete[n].Working = true;
                    ProcessesForDelete[n].LinkToProcess = LinkToProcess;
                    LabelInfoSetStatus(n, ProcessStatus.Working);
                }
                else if (LinkToProcess == null && ProcessesForDelete[n].LinkToProcess != null)
                {
                    ProcessesForDelete[n].Working = false;
                    ProcessesForDelete[n].LinkToProcess = null;
                    LabelInfoSetStatus(n, ProcessStatus.Done);
                }
                else
                {
                    ProcessesForDelete[n].Working = false;
                    ProcessesForDelete[n].LinkToProcess = null;
                    LabelInfoSetStatus(n, ProcessStatus.NotWorking);
                }
            }
        }

        void LabelInfoSetStatus(int n, ProcessStatus status)
        {
            switch (status)
            {
                case ProcessStatus.Check:
                    LabelInfo[n].Text = "Check";
                    LabelInfo[n].BackColor = ColorCheck;
                    break;

                case ProcessStatus.Working:
                    LabelInfo[n].Text = "Working";
                    LabelInfo[n].BackColor = ColorWork;
                    break;

                case ProcessStatus.NotWorking:
                    LabelInfo[n].Text = "Not Working";
                    LabelInfo[n].BackColor = ColorDone;
                    break;

                case ProcessStatus.Done:
                    LabelInfo[n].Text = "Done";
                    LabelInfo[n].BackColor = ColorDone;
                    break;

                default: break;
            }
        }

        void GenerateTrayText()
        {
            var AssemblyInfo = Assembly.GetExecutingAssembly().GetName();
            trayIcon.Text = $"{AssemblyInfo.Name} {AssemblyInfo.Version.Major}.{AssemblyInfo.Version.Minor}.{AssemblyInfo.Version.Build}";

            if (timerDropper.Enabled)
            {
                trayIcon.Text += '\n' +
                    $"Processes dropped: {ProccessesDropped}\n" +
                    $"Check every {timerDropper.Interval / 1000} sec";
            }
        }



        // Buttons

        void button_Tray_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        void button_Close_Click(object sender, EventArgs e)
        {
            Close();
        }


        void button_Refresh_Click(object sender, EventArgs e)
        {
            AllProcesses();
        }

        async void button_Optimize_Click(object sender, EventArgs e)
        {
            button_Refresh.Enabled = false;
            button_Optimize.Enabled = false;
            button_Reload_DWM.Enabled = false;
            button_AutoDrop.Enabled = false;

            bool Ready;
            byte Iteration = 0;

            do
            {
                Ready = true;

                for (int n = 0; n < ProcessesForDelete.Count; n++)
                    if (ProcessesForDelete[n].LinkToProcess != null && !ProcessesForDelete[n].LinkToProcess.HasExited)
                    {
                        ProcessesForDelete[n].LinkToProcess.Kill();
                        Ready = false;

                        if (timerDropper.Enabled)
                            ProccessesDropped++;
                    }

                AllProcesses();

                Iteration++;
                await Task.Delay(200);
            }
            while (!Ready && Iteration < 50);

            if (timerDropper.Enabled)
                GenerateTrayText();

            button_Optimize.Enabled = true;
            button_Refresh.Enabled = true;
            button_Reload_DWM.Enabled = true;
            button_AutoDrop.Enabled = true;
        }

        void button_Reload_DWM_Click(object sender, EventArgs e)
        {
            Process[] ProcessesList = Process.GetProcesses();

            Process LinkToDWM = ProcessesList.FirstOrDefault((x) => x.ProcessName == "dwm");

            if (LinkToDWM != null)
                LinkToDWM.Kill();
        }

        void button_AutoDrop_Click(object sender, EventArgs e)
        {
            if (timerDropper.Enabled)
            {
                timerDropper.Stop();
                button_AutoDrop.Text = "AutoDrop (OFF)";
            }
            else
            {
                timerDropper.Start();
                ProccessesDropped = 0;
                button_AutoDrop.Text = "AutoDrop (ON)";
            }

            GenerateTrayText();
        }



        // Other

        void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        void timerDropper_Tick(object sender, EventArgs e)
        {
            button_Optimize_Click(null, null);
        }
    }
}
