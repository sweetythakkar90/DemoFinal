using Hourly.Domain.Misc;
using Hourly.Interface.Misc;

namespace Hourly.Repository
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
