using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Interface.JobTitle;

namespace Demo.Domain.JobTitle
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
