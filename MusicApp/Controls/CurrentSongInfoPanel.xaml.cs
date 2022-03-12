using System.Windows.Controls;


namespace MusicApp.Controls
{
    /// <summary>
    /// Interaction logic for CurrentSongInfoPanel.xaml
    /// </summary>
    public partial class CurrentSongInfoPanel : UserControl
    {
        public CurrentSongInfoPanel()
        {
            InitializeComponent();
        }


        public void ChangeSong(Song song)
        {
            SongNameDisplay.Text = song.Name;
            ArtistNameDisplay.Text = song.Artist;
        }
    }
}
