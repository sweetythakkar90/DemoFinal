using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface.JobTitle
{
    public interface IJobTitleRepository
    {
        IJobTitle GeJobTitle(int jobTitleId);
    }
}
