using System.Windows;

namespace AdaptationManagement
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void CreateModule_Click(object sender, RoutedEventArgs e)
        {
            CreateModuleWindow createModuleWindow = new CreateModuleWindow();
            if (createModuleWindow.ShowDialog() == true)
            {
                string moduleName = createModuleWindow.ModuleName;
                string developers = createModuleWindow.Developers;
                string approvers = createModuleWindow.Approvers;
                string position = createModuleWindow.Position;
                DateTime deadline = createModuleWindow.Deadline;

                MessageBox.Show("Модуль успешно создан.", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        public void SendApproval_Click(object sender, RoutedEventArgs e)
        {}

        public void GenerateProgram_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Программа адаптации отправлена на почту.", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
