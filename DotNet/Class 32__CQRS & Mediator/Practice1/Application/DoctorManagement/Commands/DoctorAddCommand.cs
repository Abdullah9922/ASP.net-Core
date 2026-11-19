using Cortex.Mediator.Commands;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Application.DoctorManagement.Commands
{
    public class DoctorAddCommand: ICommand<Doctor>
    {
        public Doctor Doctor { get; set; }
    }
}
