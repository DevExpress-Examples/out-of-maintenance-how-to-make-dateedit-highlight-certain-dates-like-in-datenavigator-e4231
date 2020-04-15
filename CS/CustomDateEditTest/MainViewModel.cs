using DevExpress.Mvvm;
using System;
using System.Collections.ObjectModel;

namespace CustomDateEditTest {
    public class MainViewModel : ViewModelBase {
        public ObservableCollection<DateTime> Dates {
            get { return GetValue<ObservableCollection<DateTime>>(); }
            set { SetValue(value); }
        }
        public MainViewModel() {
            Dates = new ObservableCollection<DateTime>();
            DateTime today = DateTime.Today;
            Dates.Add(new DateTime(today.Year, today.Month, 3));
            Dates.Add(new DateTime(today.Year, today.Month, 4));
            Dates.Add(new DateTime(today.Year, today.Month, 5));
            Dates.Add(new DateTime(today.Year, today.Month, 12));
            Dates.Add(new DateTime(today.Year, today.Month, 13));
            Dates.Add(new DateTime(today.Year, today.Month, 14));
            Dates.Add(new DateTime(today.Year, today.Month, 21));
            Dates.Add(new DateTime(today.Year, today.Month, 22));
            Dates.Add(new DateTime(today.Year, today.Month, 23));
        }
    }
}