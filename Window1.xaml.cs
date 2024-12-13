using System;
using System.Windows;

namespace AdaptationManagement
{
    public partial class CreateModuleWindow : Window
    {
        public string ModuleName => ModuleNameTextBox.Text;
        public string Developers => DevelopersTextBox.Text;
        public string Approvers => ApproversTextBox.Text;
        public string Position => PositionTextBox.Text;
        public DateTime Deadline => DeadlineDatePicker.SelectedDate ?? DateTime.Now;

        public CreateModuleWindow()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {

            DialogResult = true;
            Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
