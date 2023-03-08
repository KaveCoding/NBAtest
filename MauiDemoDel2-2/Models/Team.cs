using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiDemoDel2_2.Models
{
    internal class Team
    {
        public Guid Id { get; set; }
        public string? TeamName { get; set; }
        public int? Price { get; set; }

        public string? ImageSource { get; set; }

        public string? Details { get; set; }
        public int? teamId { get; set; }
    }
}
