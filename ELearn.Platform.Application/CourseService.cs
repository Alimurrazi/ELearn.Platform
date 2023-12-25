using ELearn.Platform.Application.Dtos.Course;
using ELearn.Platform.Domain.Entity;
using ELearn.Platform.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearn.Platform.Application
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            this.courseRepository = courseRepository;
        }
        public Course AddCourse(AddCourseDto course)
        {
            Course newCourse = new Course() { CourseId = Guid.NewGuid(), Title = course.Title, Content = course.Content };
            var result = this.courseRepository.AddCourse(newCourse);
            return result;
        }

        public List<Course> GetCourses()
        {
            var result = this.courseRepository.GetCourses();
            return result;
        }
    }
}
