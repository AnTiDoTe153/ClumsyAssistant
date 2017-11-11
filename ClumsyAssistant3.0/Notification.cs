using System;
using System.Collections.Generic;
using System.Drawing;
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

        private void NotificationThread(String title, String body, int milis, ToolTipIcon icon = ToolTipIcon.Info)
        {
            //var icon = 

            var notification = new NotifyIcon()
            {
                Visible = true,
                Icon = new Icon("OK.ico",64,64),
                BalloonTipIcon = icon,
                BalloonTipTitle = title,
                BalloonTipText = body,
            };
           


            // Display for 5 seconds.
            notification.ShowBalloonTip(milis);
          
            // This will let the balloon close after it's 5 second timeout
            // for demonstration purposes. Comment this out to see what happens
            // when dispose is called while a balloon is still visible.
            Thread.Sleep(milis + 5000);

            // The notification should be disposed when you don't need it anymore,
            // but doing so will immediately close the balloon if it's visible.
            notification.Dispose();
        }

        public void ShowNotification(String title, String body, int milis, ToolTipIcon icon = ToolTipIcon.Info)
        {
            Thread myNewThread = new Thread(() => NotificationThread(title, body, milis, icon));
            myNewThread.Start();
        }
    }
}