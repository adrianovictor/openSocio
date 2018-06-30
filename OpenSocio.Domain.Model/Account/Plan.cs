using System;
using OpenSocio.Domain.Common;
using OpenSocio.Common.Extensions;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace OpenSocio.Domain.Model.Account
{
    public class Plan : Entity<Plan>, IAggregateRoot
    {
        private readonly ICollection<User> _users = new Collection<User>();

        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Value { get; set; }
        public int NumberParcels { get; set; }
        public int ValidityPeriod { get; set; }
        public virtual ICollection<User> User => _users;
        public PlanStatus Status { get; set; }

        public Plan (string name, string description, decimal value, int numberParcels = 12, int validityPeriod = 12, PlanStatus status = PlanStatus.Active)
        {
            if (name.IsEmpty()) throw new ArgumentNullException(nameof(name));
            if (value.IsNullOrEmpty()) throw new ArgumentNullException(nameof(value));

            Name = name;
            Description = description;
            Value = value;
            NumberParcels = numberParcels;
            ValidityPeriod = validityPeriod;
            Status = status;
        }

        public void ChangeName(string name)
        {
            Name = name;
        }

        public void ChanageDescription(string description)
        {
            Description = description;
        }

        public void ChangeStatus(PlanStatus planStatus)
        {
            if (Status == PlanStatus.Deleted)
                throw new CannotChangeStatusOfADeletedEntityException();

            Status = planStatus;

        }

        protected override bool IsTransient()
        {
            return false;
        }

        public override bool IsPersisted()
        {
            return Id > 0;
        }
    }
}