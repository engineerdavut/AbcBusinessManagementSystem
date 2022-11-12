﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ProjectService
    {
        Project GetById(int id);
        void Add(Project project);
        void Update(Project project);

        void Delete(Project project);
        List<Project> GetAll();
    }
}
