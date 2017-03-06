using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MusicHistory.Models
{
    public class Album
    {
        [Key]
        public int AlbumId { get; set; }
        public string AlbumTitle { get; set; }
        public string AlbumArtist { get; set; }

    }
}