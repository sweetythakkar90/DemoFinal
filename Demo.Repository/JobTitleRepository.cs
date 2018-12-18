using Hourly.Domain.JobTitle;
using Hourly.Interface.JobTitle;

namespace Hourly.Repository
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
