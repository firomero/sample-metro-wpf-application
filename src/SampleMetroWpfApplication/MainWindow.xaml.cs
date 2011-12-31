using System;
using System.Windows;

namespace SampleMetroWpfApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static readonly Thickness MainBorderMaximizedPadding = new Thickness(13);
        private static readonly Thickness MainBorderNormalPadding = new Thickness(5);

        public MainWindow()
        {
            InitializeComponent();
        }

        protected override void OnStateChanged(EventArgs e)
        {
            bdrRoot.Padding = WindowState == WindowState.Maximized
                                  ? MainBorderMaximizedPadding
                                  : MainBorderNormalPadding;
        }
    }
}
