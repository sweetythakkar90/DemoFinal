using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Domain.JobTitle;
using Demo.Interface.JobTitle;

namespace Demo.Repository
{
    public class JobTitleRepository : IJobTitleRepository
    {
        public IJobTitle GeJobTitle(int jobTitleId)
        {
            return GetJobTitleById(jobTitleId);
        }
       private IJobTitle GetJobTitleById(int jobTitleId)
        {
            IJobTitle jobTitle = new JobTitle();
            jobTitle.JobTitleId = 123;
            return jobTitle;
        }
    }
}
