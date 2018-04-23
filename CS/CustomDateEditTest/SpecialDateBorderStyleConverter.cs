using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Markup;
using System.Windows.Data;
using DevExpress.Xpf.Editors.Popups.Calendar;
using System.Windows;

namespace CustomDateEditTest {
    public class SpecialDateBorderStyleConverter : MarkupExtension, IMultiValueConverter {

        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            List<DateTime> specialDatesList = values[0] as List<DateTime>;
            CalendarCellButton currentCellButton = (CalendarCellButton)values[1];
            DateTime dt = (DateTime)DateEditCalendar.GetDateTime((DependencyObject)currentCellButton);
dt=dt.Date;
            return specialDatesList.Contains(dt);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture) {
            throw new NotImplementedException();
        }

        public override object ProvideValue(IServiceProvider serviceProvider) {
            return this;
        }
    }
}
