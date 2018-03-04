using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FileManager.Models
{
    public class File
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string FileName { get; set; }

        public string FileCode { get; set; }
        [Required]
        public int Size { get; set; }
        
        public FileType FileType { get; set; }

        public byte FileTypeId { get; set; }

        public DateTime DateUploaded { get; set; }

        public DateTime DateModified { get; set; }

        [Required]
        public string FileLocation { get; set; }

        public byte StatusCode { get; set; }
    }
}