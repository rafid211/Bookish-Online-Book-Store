﻿using Project_ATP2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_ATP2.Repositories
{
    public class RakibPublisherRepository : Repository<Publisher>
    {
        public RakibPublisherRepository(ProjectDBEntities Context) : base(Context)
        {
        }
        public ProjectDBEntities EContext
        {
            get { return Context as ProjectDBEntities; }
        }
    }
}