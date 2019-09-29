using System;
using System.Linq;
using Xunit;
using FluentAssertions;
using TddCore.Domain.Entities;
using TddCore.Domain.Tests.Builders;

namespace TddCore.Domain.Tests.Courses
{
    public class CourseTests
    {
        [Fact]
        public void ShouldCreateValidCourse()
        {
            var course = new CourseBuilder()
                .Build();

            var courseExpected = CreateCourse(course);
            
            courseExpected.Should().BeEquivalentTo(course);
            courseExpected.Valid.Should().Be(true);
            courseExpected.ValidationResult.Errors
                .ToList()
                .Should()
                .HaveCount(0);
        }

        [Fact]
        public void ShouldCreateInvalidCourseWithNameError()
        {
            var course = new CourseBuilder()
                .WithName(string.Empty)
                .Build();

            var courseExpected = CreateCourse(course);
            
            courseExpected.Should().BeEquivalentTo(course);
            courseExpected.Valid.Should().Be(false);
            courseExpected.ValidationResult.Errors
                .Should()
                .HaveCount(1);
        }

        [Fact]
        public void ShouldCreateInvalidCourseWithWorkloadError()
        {
            var course = new CourseBuilder()
                .WithWorkload(0)
                .Build();

            var courseExpected = CreateCourse(course);
            
            courseExpected.Should().BeEquivalentTo(course);
            courseExpected.Valid.Should().Be(false);
            courseExpected.ValidationResult.Errors
                .Should()
                .HaveCount(1);
        }

        private Course CreateCourse(Course course)
        {
            return new Course(
                course.Id,
                course.Name,
                course.Workload,
                course.TargetAudience,
                course.Price);
        }
    }
}