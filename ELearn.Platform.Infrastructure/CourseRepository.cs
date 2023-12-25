using ELearn.Platform.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearn.Platform.Infrastructure
{
    public class CourseRepository: ICourseRepository
    {
        private readonly EfDbContext _efDbContext;
        public CourseRepository(EfDbContext efDbContext)
        {
            _efDbContext = efDbContext;
        }
        public List<Course> GetCourses()
        {
            return _efDbContext.Courses.ToList();
        }
        public Course AddCourse(Course course)
        {
            _efDbContext.Courses.Add(course);
            _efDbContext.SaveChanges();
            return course;
        }
    }
}
