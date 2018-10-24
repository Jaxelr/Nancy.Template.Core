﻿using Api.Model.Operations;
using FluentValidation;

namespace Api.Validators
{
    public class HelloValidator : AbstractValidator<HelloRequest>
    {
        public HelloValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
        }
    }
}