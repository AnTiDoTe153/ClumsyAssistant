using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClumsyAssistant3._0
{
    public partial class ClipBoardForm : Form
    {
        private ClipboardHandler cbHandler;
        private IntPtr nextClipboardViewer;
        private Notification not = new Notification();

        [DllImport("User32.dll")]
        protected static extern int
            SetClipboardViewer(int hWndNewViewer);
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern bool
               ChangeClipboardChain(IntPtr hWndRemove,
                                    IntPtr hWndNewNext);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SendMessage(IntPtr hwnd, int wMsg,
                                             IntPtr wParam,
                                             IntPtr lParam);

        public ClipBoardForm()
        {
            InitializeComponent();
            this.cbHandler = new ClipboardHandler();
            nextClipboardViewer = (IntPtr)SetClipboardViewer((int)
                                   this.Handle);
            this.Load += new EventHandler(ClipBoardForm_Load);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.ShowInTaskbar = false;
        }

        protected override void
          WndProc(ref System.Windows.Forms.Message m)
        {
            // defined in winuser.h
            const int WM_DRAWCLIPBOARD = 0x308;
            const int WM_CHANGECBCHAIN = 0x030D;

            switch (m.Msg)
            {
                case WM_DRAWCLIPBOARD:
                    this.not.ShowNotification("You tryied to copy something!", "I changed it with something more appropriate", 5000);
                    this.cbHandler.SwapClipboardHText("nope");
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        private void ClipBoardForm_Load(object sender, EventArgs e)
        {
            this.Size = new Size(0, 0);
        }
    }
}