﻿using System;
using SSar.Contexts.Common.AbstractClasses;
using SSar.Contexts.Common.Results;

namespace SSar.Contexts.Membership.Domain.Entities
{
    public class ExamplePerson : AggregateRoot
    {
        public string _name;
        public string _emailAddress;

        private ExamplePerson()
        {
        }
        
        public string Name => _name;
        public string EmailAddress => _emailAddress;

        public static ExamplePerson CreateFromData(string name, string emailAddress)
        {
            var aggregate = new ExamplePerson();

            aggregate.SetName(name);
            aggregate.SetEmailAddress(emailAddress);

            return aggregate;
        }

        public OperationResult SetName(string name)
        {
            return new OperationResult();
        }

        public OperationResult SetEmailAddress(string emailAddress)
        {
            return new OperationResult();
        }
    }
}