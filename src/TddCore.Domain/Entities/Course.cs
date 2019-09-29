using System;
using TddCore.Domain.Enums;
using TddCore.Domain.Validators;

namespace TddCore.Domain.Entities
{
    public class Course : EntityBase
    {
        public string Name { get; protected set; }
        public int Workload { get; protected set; }
        public TargetAudience TargetAudience { get; protected set; }
        public double Price { get; protected set; }

        public Course()
        {

        }

        public Course(Guid id, string name, int workload, TargetAudience targetAudience, double price)
        {
            SetId(id);
            SetName(name);
            SetWorkload(workload);
            SetTargetAudience(targetAudience);
            SetPrice(price);

            Validate(this, new CourseValidator());
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public void SetWorkload(int workload)
        {
            Workload = workload;
        }

        public void SetTargetAudience(TargetAudience targetAudience)
        {
            TargetAudience = targetAudience;
        }

        public void SetPrice(double price)
        {
            Price = price;
        }
    }
}