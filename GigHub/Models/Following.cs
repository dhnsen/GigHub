using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GigHub.Models
{
    public class Following
    {
        [Key]
        [Column(Order = 1)]
        public string FollowedId { get; set; }

        [Key]
        [Column(Order = 2)]
        public string FollowerId { get; set; }
    }
}