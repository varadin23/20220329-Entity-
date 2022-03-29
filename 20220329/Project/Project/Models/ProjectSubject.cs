using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable disable

namespace Project.Models
{
    public partial class ProjectSubject
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [JsonIgnore]
        public int StudentId { get; set; }

        [JsonIgnore]
        public virtual ProjectStudent Student { get; set; }
    }
}
