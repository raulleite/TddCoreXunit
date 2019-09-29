using System;
using TddCore.Domain.Enums;
using TddCore.Domain.Entities;
using TddCore.Domain.Tests.Extensions;

namespace TddCore.Domain.Tests.Builders
{
    public class CourseBuilder
    {
        private string _name = "Course Test";
        private int _workload = 100;
        private TargetAudience _targetAudience = TargetAudience.Student;
        private double _price = 100;

        public Course Build()
        {
            var course = new Course(
                Guid.Empty,
                _name,
                _workload,
                _targetAudience,
                _price)
                .WithBuildId();

            return course;
        }

        public CourseBuilder WithName(string name)
        {
            _name = name;

            return this;
        }
        
        public CourseBuilder WithWorkload(int workload)
        {
            _workload = workload;

            return this;
        }

        public CourseBuilder WithTargetAudience(TargetAudience targetAudience)
        {
            _targetAudience = targetAudience;

            return this;
        }

        public CourseBuilder WithPrice(double price)
        {
            _price = price;

            return this;
        }
    }
}