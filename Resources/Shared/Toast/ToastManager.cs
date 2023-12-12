using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToastNotifications;
using System.Windows;
using ToastNotifications.Position;
using ToastNotifications.Lifetime;
using ToastNotifications.Messages;

namespace my_school.Resources.Shared.Toast
{
    internal class ToastManager
    {

        Notifier notifier = new Notifier(cfg =>
        {

            var mainWindow = Application.Current.MainWindow;

            var positionProvider = new WindowPositionProvider(
                 parentWindow: mainWindow,
                corner: Corner.TopRight,
                 offsetX: 0,
                 offsetY: 0
   );

            cfg.PositionProvider = positionProvider;

            cfg.LifetimeSupervisor = new TimeAndCountBasedLifetimeSupervisor(
                notificationLifetime: TimeSpan.FromSeconds(5),
                maximumNotificationCount: MaximumNotificationCount.FromCount(5));

            cfg.Dispatcher = Application.Current.Dispatcher;
        });


        public void ToastError()
        {
            notifier.ShowError("alguma coisa aqui");
        }
    }
}
