using System;
using System.ComponentModel;
using System.Timers;
using System.Windows;
using System.Windows.Threading;

namespace Clock
{
    public class ClockModel : INotifyPropertyChanged
    {
        private volatile bool isTimerActive;
        private static ClockModel thisModel => new ClockModel();
        public static ClockModel GetInstance() => thisModel;

        private ClockModel()
        {
            Application.Current.Exit += (s, e) => isTimerActive = false;
            InitializeClockTimer();
        }

        private void InitializeClockTimer()
        {
            var timer = new Timer(200);

            timer.Elapsed += (s, e) =>
            {
                if (!isTimerActive)
                {
                    timer.Stop();
                    timer.Dispose();
                    return;
                }

                if (Application.Current != null)
                    try
                    {
                        Application.Current.Dispatcher.BeginInvoke(DispatcherPriority.Normal, new Action(() =>
                        {
                            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CurrentTime)));
                        }));
                    }
                    catch { }
            };

            isTimerActive = true;
            timer.Start();
        }

        public DateTime CurrentTime => DateTime.Now;

        public event PropertyChangedEventHandler PropertyChanged;

        ~ClockModel() { isTimerActive = false; }
    }
}
