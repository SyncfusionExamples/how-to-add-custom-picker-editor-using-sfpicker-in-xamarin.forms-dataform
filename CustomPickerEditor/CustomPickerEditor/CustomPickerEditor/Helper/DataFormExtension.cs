using Syncfusion.XForms.DataForm;
using Syncfusion.XForms.DataForm.Editors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace CustomPickerEditor
{
    public class DataFormEditorExe : DataFormEditor<Button>
    {
        public DataFormEditorExe(SfDataForm dataForm) : base(dataForm)
        {

        }
        protected override Button OnCreateEditorView(DataFormItem dataFormItem)
        {
            return new Button();
        }

        protected override void OnInitializeView(DataFormItem dataFormItem, Button view)
        {
            view.Text = ((App.Current.MainPage as MainPage).Picker.ItemsSource).Cast<object>().FirstOrDefault().ToString();
            view.BackgroundColor = Color.LightGray;
        }

        protected override void OnCommitValue(Button view)
        {
            view.Text = (App.Current.MainPage as MainPage).Picker.SelectedItem.ToString();
            var dataFormItemView = view.Parent as DataFormItemView;
            this.DataForm.ItemManager.SetValue(dataFormItemView.DataFormItem, view.Text);
        }

        protected override void OnWireEvents(Button view)
        {
            base.OnWireEvents(view);
            view.Clicked += OnButtonClicked;
        }

        void OnButtonClicked(object sender, EventArgs e)
        {
            (App.Current.MainPage as MainPage).Picker.IsOpen = true;
        }

        protected override void OnUnWireEvents(Button view)
        {
            view.Clicked -= OnButtonClicked;
        }
    }
}
