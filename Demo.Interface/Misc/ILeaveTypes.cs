using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface.Misc
{
    public interface ILeaveTypes
    {
        int LeaveTypeId { get; set; }
        string LeaveTypeName { get; set; }
        string LeaveTypeDesc { get; set; }
        bool Status { get; set; }
        DateTime WhenCreated { get; set; }
        DateTime WhenChanged { get; set; }
        int ChangedBy { get; set; }
    }
}
