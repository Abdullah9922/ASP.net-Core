using Cortex.Mediator.Commands;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Application.DoctorManagement.Quaries
{
    public class GetDoctorByIdQuery : ICommand<Doctor?>
    {
        public Guid Id { get; set; }
    }
}
