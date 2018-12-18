using System;
using Hourly.Interface.JobTitle;

namespace Hourly.Domain.JobTitle
{
    public class JobTitleService : IJobTitleService
    {
        private readonly IJobTitleRepository _jobTitleRepository;

        public JobTitleService(IJobTitleRepository jobTitleRepository)
        {
            if (jobTitleRepository == null) throw new ArgumentNullException(nameof(jobTitleRepository));
            _jobTitleRepository = jobTitleRepository;
        }
        public IJobTitle GeJobTitle(int jobTitleId)
        {
            if (jobTitleId <= 0)
                throw new Exception("Invalid jobTitle id");
            return _jobTitleRepository.GeJobTitle(jobTitleId);
        }
    }
}
