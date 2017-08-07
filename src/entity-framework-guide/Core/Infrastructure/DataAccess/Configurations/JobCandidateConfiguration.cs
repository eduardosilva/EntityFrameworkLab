﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entity_framework_guide.Core.Entities;

namespace entity_framework_guide.Core.Infrastructure.DataAccess.Configurations
{
    public class JobCandidateConfiguration : EntityTypeConfiguration<JobCandidate>
    {
        public JobCandidateConfiguration()
        {
            ToTable("JobCandidate", "HumanResources");
        }
    }
}
