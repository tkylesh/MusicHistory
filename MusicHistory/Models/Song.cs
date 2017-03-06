using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MusicHistory.Models
{
    public class Song
    {
        [Key]
        public int SongId { get; set; }
        public int SongArtistId { get; set; }
        public int SongAlbumId { get; set; }
        public int SongGenreId { get; set; }
        public TimeSpan SongLength { get; set; }
    }
}