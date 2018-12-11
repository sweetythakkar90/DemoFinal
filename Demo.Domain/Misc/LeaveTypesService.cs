using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Interface.Misc;

namespace Demo.Domain.Misc
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
