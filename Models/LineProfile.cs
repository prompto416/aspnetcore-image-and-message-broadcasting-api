using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LineService.Models
{
    public class LineProfile
    {
        [Key]
        public int Id { get; set; }
        public string userId { get; set; }
        public string displayName { get; set; }
        public string pictureUrl { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string FullName { get; set; }
    }
}
