using Syncfusion.SfPicker.XForms;
using Syncfusion.XForms.DataForm;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CustomPickerEditor
{
    public class DataFormBehavior : Behavior<ContentPage>
    {
        SfDataForm dataForm = null;
        public SfPicker picker = null;
        protected override void OnAttachedTo(ContentPage bindable)
        {
            base.OnAttachedTo(bindable);
            dataForm = bindable.FindByName<SfDataForm>("dataForm");

            dataForm.DataObject = new ContactInfo();
            dataForm.RegisterEditor("CustomPickerEditor", new DataFormEditorExe(dataForm));
            dataForm.RegisterEditor("Color", "CustomPickerEditor");

            picker = bindable.FindByName<SfPicker>("picker");
            picker.BindingContext = new ColorInfo();
            picker.SelectionChanged += Picker_SelectionChanged;

            var footerView = bindable.FindByName<Button>("footerView");
            footerView.Clicked += OnPickerClosed;

        }

        void OnPickerClosed(object sender, EventArgs e)
        {
            this.picker.IsOpen = false;
        }


        void Picker_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            dataForm.Commit("Color");
        }
    }
}
