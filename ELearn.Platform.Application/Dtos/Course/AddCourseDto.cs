using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearn.Platform.Application.Dtos.Course
{
    public class AddCourseDto
    {
        public string Title { get; set; } = String.Empty;
        public string Content { get; set; } = String.Empty;
    }
}
