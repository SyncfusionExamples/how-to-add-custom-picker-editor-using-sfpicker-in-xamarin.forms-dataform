using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CustomPickerEditor
{
    public class ContactInfo
    {
        public string BrandName { get; set; }
        public String Color { get; set; }
    }
    public class ColorInfo
    {
        private ObservableCollection<string> _color;
        public ObservableCollection<string> Colors
        {
            get { return _color; }
            set { _color = value; }
        }

        public ColorInfo()
        {
            Colors = new ObservableCollection<string>();
            Colors.Add("Red");
            Colors.Add("White");
            Colors.Add("Orange");
        }
    }
}
