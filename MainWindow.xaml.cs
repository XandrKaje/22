using System.Windows;
using System.Windows.Controls;
using ТИМП_курсовая.ViewModel;

namespace ТИМП_курсовая.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static ListView AllDepartmentsView;
        public static ListView AllPositionsView;
        public static ListView AllUsersView;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new DataManageVM();
            AllDepartmentsView = ViewAllDepartments;
            AllPositionsView = ViewAllPositions;
            AllUsersView = ViewAllUsers;
        }

        private void ViewAllDepartments_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
