using System;
using System.ComponentModel;
using System.Timers;
using System.Windows;
using System.Windows.Threading;

namespace Clock.Models
{
    public class ClockModel : INotifyPropertyChanged, IDisposable
    {
        private static ClockModel thisModel => new ClockModel();
        private Timer timer = new Timer(200);

        public static ClockModel GetInstance() => thisModel;

        private ClockModel()
        {
            Application.Current.Exit += (s, e) => Dispose();
            InitializeClockTimer();
        }

        private void InitializeClockTimer()
        {
            timer.Elapsed += (s, e) =>
            {

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
            timer.Start();
        }

        public void Dispose()
        {
            timer.Stop();
            timer.Dispose();
        }

        public DateTime CurrentTime => DateTime.Now;

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
