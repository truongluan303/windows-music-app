using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;


namespace MusicApp.Controls
{
    /// <summary>
    /// Interaction logic for PlaylistButton.xaml
    /// </summary>
    public partial class PlaylistButton : UserControl
    {
        private bool _clicked;

        public PlaylistButton()
        {
            InitializeComponent();
            _clicked = false;
        }


        public void UnclickUI()
        {
            ButtonBorder.BorderThickness = new Thickness(2);
            ButtonBorder.Background = new SolidColorBrush(Colors.Gray);
            _clicked = false;
        }


        private void PlaylistButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (_clicked) return;
            ButtonBorder.BorderThickness = new Thickness(4);
            ButtonBorder.Background = new SolidColorBrush(Colors.White);
            _clicked = true;
        }


        private void PlaylistButton_MouseEnter(object sender, MouseEventArgs e)
        {
            if (_clicked) return;
            ButtonBorder.Background = new SolidColorBrush(Colors.White);
        }


        public void PlaylistButton_MouseLeave(object sender, MouseEventArgs e)
        {
            if (_clicked) return;
            ButtonBorder.Background = new SolidColorBrush(Colors.Gray);
        }
    }
}
