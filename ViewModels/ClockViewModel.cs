using Clock.Models;
using System.ComponentModel;

namespace Clock.ViewModels
{
    public class ClockViewModel : INotifyPropertyChanged
    {
        private int hour;
        private int minute;
        private int second;

        public event PropertyChangedEventHandler PropertyChanged;

        public ClockViewModel()
        {
            ClockModel.GetInstance().PropertyChanged += (s, e) =>
            {
                if (e.PropertyName == nameof(ClockModel.CurrentTime))
                {
                    var time = ClockModel.GetInstance().CurrentTime;
                    Hour = time.Hour;
                    Minute = time.Minute;
                    Second = time.Second;
                }
            };
        }
        public int Hour
        {
            get { return hour; }
            set
            {
                hour = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Hour)));
            }
        }

        public int Minute
        {
            get { return minute; }
            set
            {
                minute = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Minute)));
            }
        }

        public int Second
        {
            get { return second; }
            set
            {
                second = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Second)));
            }
        }
    }
}
