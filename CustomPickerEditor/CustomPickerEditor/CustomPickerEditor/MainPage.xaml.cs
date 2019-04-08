using Syncfusion.SfPicker.XForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CustomPickerEditor
{
    public partial class MainPage : ContentPage
    {
        public SfPicker Picker
        {
            get { return picker; }
        }
        public MainPage()
        {
            InitializeComponent();
        }
    }
}
