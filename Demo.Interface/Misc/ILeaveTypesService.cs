﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface.Misc
{
    public interface ILeaveTypesService
    {
        ILeaveTypes GetLeaveTypes(int leaveTypeId);
    }
}
