using System;
using System.Windows;
using System.Windows.Media;
/*
Jiwant Singh
Nihal Ahmed Gesudraz
Apoorva Solanki
Kiranpreet Kaur
Harkirat Kaur
*/
namespace Color_Mixer
{
	/// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
		public const int max = 225;
		public const int min = 0;
		public const int trans_lvl = 200;

		public MainWindow()
        {
            InitializeComponent();
        }

        private void MixColours(object sender, RoutedEventArgs e)
        {
            try
            {
				Boolean lr = (LeftRed.IsChecked == true);
				Boolean lg = (LeftGreen.IsChecked == true);
				Boolean lb = (LeftBlue.IsChecked == true);
				Boolean rr = (RightRed.IsChecked == true);
				Boolean rg = (RightGreen.IsChecked == true);
				Boolean rb = (RightBlue.IsChecked == true);
				if ((lr||lg||lb)&&(rr||rg||rb))
                {
                    if ((lr&&rr)||(lb&&rb)||(lg && rg))
                    {
                        if (lr)
                            MainGrid.Background = new SolidColorBrush(Color.FromArgb(trans_lvl, max, min, min));
                        else if (lg)
                            MainGrid.Background = new SolidColorBrush(Color.FromArgb(trans_lvl, min, max, min));
                        else
                            MainGrid.Background = new SolidColorBrush(Color.FromArgb(trans_lvl, min, min, max));
                    }

                    else
                    {
                        if ((lr&&rg)||(lg&&rr))
                        { MainGrid.Background = new SolidColorBrush(Color.FromArgb(trans_lvl, max, max, min)); }

                        if ((lr&&rb)||(lb&&rr))
                        { MainGrid.Background = new SolidColorBrush(Color.FromArgb(trans_lvl, max, min, max)); }

                        if ((lb&&rg)||(lg&&rb))
                        { MainGrid.Background = new SolidColorBrush(Color.FromArgb(trans_lvl, min, max, max)); }

                    }
                }
				else
                    throw new Exception();
            }
			catch
            {
                MessageBox.Show("Select from Both Columns");
            }
		}
		private void Reset(object sender, RoutedEventArgs e)
        {
            LeftRed.IsChecked = false;
            LeftBlue.IsChecked = false;
            LeftGreen.IsChecked = false;
            RightRed.IsChecked = false;
            RightBlue.IsChecked = false;
            RightGreen.IsChecked = false;
            MainGrid.Background = new SolidColorBrush(Color.FromArgb(min, min, min, min));
        }
    }
}
