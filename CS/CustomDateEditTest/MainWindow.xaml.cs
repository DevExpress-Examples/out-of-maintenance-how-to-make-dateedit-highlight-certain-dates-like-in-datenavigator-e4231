using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace CustomDateEditTest {
    public partial class MainWindow : Window {
        List<DateTime> dates;

        public List<DateTime> Dates {
            get {
                return dates;
            }
            set {
                dates = value;
            }
        }

        public MainWindow() {
            InitializeComponent();
            FillDates();
        }

        public void FillDates() {
            dates = new List<DateTime>();
            dates.Add(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 3));
            dates.Add(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 4));
            dates.Add(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 5));
            dates.Add(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 12));
            dates.Add(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 13));
            dates.Add(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 14));
            dates.Add(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 21));
            dates.Add(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 22));
            dates.Add(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 23));
        }
    }
}
