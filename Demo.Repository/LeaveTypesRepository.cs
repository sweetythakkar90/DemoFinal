using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Domain.Misc;
using Demo.Interface.Misc;

namespace Demo.Repository
{
    public class LeaveTypesRepository : ILeaveTypesRepository
    {
        public ILeaveTypes GetLeaveTypes(int leaveTypeId)
        {
            return GetLeaveTypesById(leaveTypeId);
        }

        private ILeaveTypes GetLeaveTypesById(int leaveTypeId)
        {
            ILeaveTypes leaveTypes = new LeaveTypes();
            leaveTypes.LeaveTypeId = 123;
            return leaveTypes;
        }
    }
}
