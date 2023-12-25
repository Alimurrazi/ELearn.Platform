using ELearn.Platform.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearn.Platform.Infrastructure
{
    public interface ICourseRepository
    {
        List<Course> GetCourses();
        Course AddCourse(Course course);
    }
}
