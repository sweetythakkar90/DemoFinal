using System;
using Hourly.Interface.Misc;

namespace Hourly.Domain.Misc
{
    public class LeaveTypesService : ILeaveTypesService
    {
        private readonly ILeaveTypesRepository _leaveTypesRepository;

        public LeaveTypesService(ILeaveTypesRepository leaveTypesRepository)
        {
            if (leaveTypesRepository == null) throw new ArgumentNullException(nameof(leaveTypesRepository));
            _leaveTypesRepository = leaveTypesRepository;
        }

        public ILeaveTypes GetLeaveTypes(int leaveTypeId)
        {
            if (leaveTypeId <= 0)
                throw new Exception("Invalid leaveType id");
            return _leaveTypesRepository.GetLeaveTypes(leaveTypeId);
        }
    }
}
