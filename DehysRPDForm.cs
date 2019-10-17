using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DehysRPD
{
    public partial class DehysRPDForm : Form
    {

        private readonly System.Threading.Timer _timer;
        private SoundPlayer _soundPlayer;

        private DiscordRpc.RichPresence presence;
        DiscordRpc.EventHandlers handlers;

        private NotifyIcon notifyIcon;

        public bool isRunning = false;

        public DehysRPDForm()
        {
            InitializeComponent();
            _timer = new System.Threading.Timer(_ => StopAnimation(), null, Timeout.Infinite, Timeout.Infinite);
            _soundPlayer = new SoundPlayer();
            _soundPlayer.Stream = DehysRPD.Properties.Resources.bling;

            Process[] processes = Process.GetProcesses();

            listboxProccesses.Items.Add("(none)");
            listboxProccesses.SelectedIndex = 0;

            foreach (Process p in processes)
            {
                if (!String.IsNullOrEmpty(p.MainWindowTitle))
                {
                    listboxProccesses.Items.Add("("+p.Id+") "+p.ProcessName);
                }
            }


            notifyIcon = new NotifyIcon();
            notifyIcon.Icon = DehysRPD.Properties.Resources.logo;
            notifyIcon.Visible = false;

            notifyIcon.Click += new EventHandler(onNotifyIconClick);

        }

        private void onNotifyIconClick(object sender, EventArgs e)
        {
            notifyIcon.Visible = false;
            this.Show();
        }

        private void onMinimizeMouseEnter(object sender, EventArgs e)
        {
            panelMinimizeButton.BackColor = Color.FromArgb(255, 233, 127);
        }

        private void onMinimizeMouseLeave(object sender, EventArgs e)
        {
            panelMinimizeButton.BackColor = Color.White;
        }

        private void onMinimizeMouseDown(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void onExitMouseEnter(object sender, EventArgs e)
        {
            panelExitButton.BackColor = Color.FromArgb(255,233,127);
        }

        private void onExitMouseLeave(object sender, EventArgs e)
        {
            panelExitButton.BackColor = Color.White;
        }

        private void onExitMouseDown(object sender, MouseEventArgs e)
        {
            if (isRunning == false) Close(); else
            {
                notifyIcon.Visible = true;
                this.Hide();
            }
        }

        private void onImageBigMouseEnter(object sender, EventArgs e)
        {
            lblBigText.Visible = true;
        }

        private void onImageBigMouseLeave(object sender, EventArgs e)
        {
            lblBigText.Visible = false;
        }

        private void onImageSmallMouseEnter(object sender, EventArgs e)
        {
            lblSmallText.Visible = true;
        }

        private void onImageSmallMouseLeave(object sender, EventArgs e)
        {
            lblSmallText.Visible = false;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void onHeaderMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void onUpdateMouseDown(object sender, MouseEventArgs e)
        {
            pictureboxAnimation.Visible = false;
            pictureboxAnimation.Location = new Point((this.PointToClient(Cursor.Position).X)-20, pictureboxAnimation.Location.Y);
            _soundPlayer.Play();
            pictureboxAnimation.Visible = true;
            _timer.Change(TimeSpan.FromMilliseconds(500), Timeout.InfiniteTimeSpan);
        }

        private void StopAnimation()
        {
            this.Invoke((MethodInvoker)delegate
            {
                pictureboxAnimation.Visible = false;
            });
        }

        private void onProccessesDoubleClick(object sender, EventArgs e)
        {
            String selectedItem = listboxProccesses.SelectedItem.ToString();

            if (selectedItem.ToLower() == "(none)") { ResetFields(); } else
            {

                int selectedItemId = int.Parse(((selectedItem.Split('(')[1]).Split(')')[0]));
                Process process = GetProcessById(selectedItemId);

                textboxDetails.Text = process.ProcessName;
                textboxState.Text = process.MainWindowTitle;

                textboxBigPictureAsset.Text = process.ProcessName.ToLower().Replace(' ', '_').Replace('.', '_');

            }
        }

        private void ResetFields()
        {
            textboxDetails.Text = "Good day";
            textboxState.Text = "everyone!";
            textboxBigPictureAsset.Text = "Asset Name";
            textboxBigPictureText.Text = "Text";
            textboxSmallPictureAsset.Text = "Asset Name";
            textboxSmallPictureText.Text = "Text";

            lblBigText.Text = "Big Text";
            lblSmallText.Text = "Small Text";
        }

        private Process GetProcessById(int id)
        {
            Process[] processes = Process.GetProcesses();
            foreach (Process p in processes)
            {
                if (p.Id == id) return p;
            }
            return null;
        }

        private void onBigPictureTextTextChanged(object sender, EventArgs e)
        {
            lblBigText.Text = textboxBigPictureText.Text;
        }

        private void onSmallPictureTextTextChanged(object sender, EventArgs e)
        {
            lblSmallText.Text = textboxSmallPictureText.Text;
        }


        private void onUpdateClick(object sender, EventArgs e)
        {
            DiscordRpc.RPCShutdown();
            DiscordRpc.RPCInit(textboxApplicationId.Value + "", ref handlers, true, null);

            presence = new DiscordRpc.RichPresence();
            presence.details = textboxDetails.Text;
            presence.state = textboxState.Text;
            presence.largeImageKey = textboxBigPictureAsset.Text;
            presence.largeImageText = textboxBigPictureText.Text;
            presence.smallImageKey = textboxSmallPictureAsset.Text;
            presence.smallImageText = textboxSmallPictureText.Text;

            DiscordRpc.RPCUpdate(ref presence);

            btnStop.BackColor = Color.FromArgb(255, 94, 89);

            isRunning = true;
        }

        private void onStopClick(object sender, EventArgs e)
        {
            DiscordRpc.RPCShutdown();
            isRunning = false;
            btnStop.BackColor = Color.FromArgb(147, 168, 198);
        }
    }
}
