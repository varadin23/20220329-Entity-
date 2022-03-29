using System;
using System.Collections.Generic;

#nullable disable

namespace Project.Models
{
    public partial class ProjectStudent
    {
        public ProjectStudent()
        {
            ProjectSubjects = new HashSet<ProjectSubject>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public virtual ICollection<ProjectSubject> ProjectSubjects { get; set; }
        public object ProjectSubject { get; internal set; }
    }
}
