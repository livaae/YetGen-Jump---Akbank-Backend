using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Week2_2.Entities;

namespace Week2_2.Services
{
    internal class NotepadService
    {
        public void PlaylistToNotepad(Playlist playlist)
        {
            //Saving to notepad
            string directory = $"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}\\Playlists"; // \ error @$ or \\

            if(!File.Exists(directory))
            Directory.CreateDirectory(directory);

            string saveFile = Path.Combine(directory, $"{playlist.Id}.txt");

            File.WriteAllText(saveFile, playlist.GetSongs());

            Console.WriteLine("Data Successfully Saved");
        }
    }
}
