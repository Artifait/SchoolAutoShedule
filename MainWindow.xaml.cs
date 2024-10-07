
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;


namespace SchoolAutoShedule
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void hidePopup(object sender, MouseEventArgs e)
        {
            Popup.Visibility = Visibility.Collapsed;
            Popup.IsOpen = false;
        }
        private void ShowPopup(UIElement element, string text)
        {
            if (Tg_Btn.IsChecked == false)
            {
                Popup.PlacementTarget = element;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                Header.PopupText.Text = text;
            }
        }
        private void BG_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Tg_Btn.IsChecked = false;
        }

        // Start: MenuLeft PopupButton //
        private void btnTeachers_MouseEnter(object sender, MouseEventArgs e)        => ShowPopup(btnTeachers, "Учителя");
        private void btnSchProgram_MouseEnter(object sender, MouseEventArgs e)      => ShowPopup(btnSchProgram, "Шк. Программа");
        private void btnSubjects_MouseEnter(object sender, MouseEventArgs e)        => ShowPopup(btnSubjects, "Предметы");
        private void btnSchInfo_MouseEnter(object sender, MouseEventArgs e)         => ShowPopup(btnSchInfo, "Инфа О Школе");
        private void btnCreateSchedule_MouseEnter(object sender, MouseEventArgs e)  => ShowPopup(btnCreateSchedule, "Создать Расписание");
        private void btnExportSchedule_MouseEnter(object sender, MouseEventArgs e)  => ShowPopup(btnExportSchedule, "Экспортировать Расписание");
        private void btnSetting_MouseEnter(object sender, MouseEventArgs e)         => ShowPopup(btnSetting, "Настройки");
        // End: MenuLeft PopupButton //

        // Start: Button Close | Restore | Minimize 
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnRestore_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Normal)
                WindowState = WindowState.Maximized;
            else
                WindowState = WindowState.Normal;
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        // End: Button Close | Restore | Minimize

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            fContainer.Navigate(new System.Uri("Pages/Teachers.xaml", UriKind.RelativeOrAbsolute));
        }

        private void btnSubjects_Click(object sender, RoutedEventArgs e)
        {
            fContainer.Navigate(new System.Uri("Pages/Subjects.xaml", UriKind.RelativeOrAbsolute));
        }
        private void btnSchProgram_Click(object sender, RoutedEventArgs e)
        {
            fContainer.Navigate(new System.Uri("Pages/SchProgram.xaml", UriKind.RelativeOrAbsolute));
        }
        private void btnSchInfo_Click(object sender, RoutedEventArgs e)
        {
            fContainer.Navigate(new System.Uri("Pages/SchInfo.xaml", UriKind.RelativeOrAbsolute));
        }
        private void btnScheduleCreator_Click(object sender, RoutedEventArgs e)
        {
            fContainer.Navigate(new System.Uri("Pages/ScheduleCreator.xaml", UriKind.RelativeOrAbsolute));
        }
        private void btnExportSchedule_Click(object sender, RoutedEventArgs e)
        {
            fContainer.Navigate(new System.Uri("Pages/Export.xaml", UriKind.RelativeOrAbsolute));
        }
        private void btnSettings_Click(object sender, RoutedEventArgs e)
        {
            fContainer.Navigate(new System.Uri("Pages/Settings.xaml", UriKind.RelativeOrAbsolute));
        }


        private void WindowMove(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
                this.DragMove();
        }

    }
}
