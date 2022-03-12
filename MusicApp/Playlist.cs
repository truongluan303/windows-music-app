using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    public class Song
    {
        public string Name { get; set; }
        public string Artist { get; set; }
        public string FilePath { get; set; }
        public float Duration { get; private set; }

        public Song(string name, string artist, string filepath, float duration)
        {
            Name = name;
            Artist = artist;
            FilePath = filepath;
            Duration = duration;
        }
    }


    public class Playlist : CircularDoublyLinkedList<Song>
    {
        private Node? _current;
        public string PlaylistPath { get; private set; }
        public Song? CurrentSong 
        {
            get
            {
                if (_current == null) return null;
                return _current.Value;
            }
        }


        public Playlist(string path)
        {
            ChangePath(path);
        }


        public void ChangePath(string path)
        {
            if (!Directory.Exists(path)) throw new ArgumentException("Path not exist!");

            string[] files = Directory.GetFiles(path);
            foreach (string file in files)
            {

            }
        }


        public Song? NextSong()
        {
            if (_current == null) return null;
            _current = _current.Next;
            return CurrentSong;
        }


        public Song? PreviousSong()
        {
            if (_current == null) return null;
            _current = _current.Prev;
            return CurrentSong;
        }
    }
}
