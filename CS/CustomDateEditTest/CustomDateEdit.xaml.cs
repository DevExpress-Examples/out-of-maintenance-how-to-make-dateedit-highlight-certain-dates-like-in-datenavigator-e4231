using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using DevExpress.Xpf.Editors;
using DevExpress.Xpf.Utils;

namespace CustomDateEditTest {
    public partial class CustomDateEdit : DateEdit {

        #region Special Dates property
        public static readonly DependencyProperty SpecialDatesProperty;
        public static readonly DependencyProperty SpecialBorderStyleProperty;

        public IList<DateTime> SpecialDates {
            get { return (IList<DateTime>)GetValue(SpecialDatesProperty); }
            set { SetValue(SpecialDatesProperty, value); }
        }
        public Style SpecialBorderStyle {
            get { return (Style)GetValue(SpecialBorderStyleProperty); }
            set { SetValue(SpecialBorderStyleProperty, value); }
        }
        #endregion
        public CustomDateEdit() {
            InitializeComponent();
            SpecialBorderStyle = FindResource("defaultSpecialBorderStyle") as Style;
        }

        static CustomDateEdit() {
            SpecialDatesProperty = DependencyPropertyManager.Register("SpecialDates", typeof(IList<DateTime>), typeof(CustomDateEdit));
            SpecialBorderStyleProperty = DependencyPropertyManager.Register("SpecialBorderStyle", typeof(Style), typeof(CustomDateEdit));
        }
    }
}
