using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClumsyAssistant3._0
{
    class Notification
    {
        public Notification()
        {
           
        }

        private void NotificationThread(String title, String body, int milis)
        {
            var notification = new NotifyIcon()
            {
                Visible = true,
                Icon = System.Drawing.SystemIcons.Information,
                //BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info,
                BalloonTipTitle = title,
                BalloonTipText = body,
            };

            // Display for 5 seconds.
            notification.ShowBalloonTip(milis);

            // This will let the balloon close after it's 5 second timeout
            // for demonstration purposes. Comment this out to see what happens
            // when dispose is called while a balloon is still visible.
            Thread.Sleep(milis+5000);

            // The notification should be disposed when you don't need it anymore,
            // but doing so will immediately close the balloon if it's visible.
            notification.Dispose();
        }

        public void ShowNotification(String title, String body, int milis)
        {
            Thread myNewThread = new Thread(() => NotificationThread(title, body, milis));
            myNewThread.Start();
        }
    }
}
