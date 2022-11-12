using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProjectManager : ProjectService
    {
        IProjectDal _projectDal;

        public ProjectManager(IProjectDal projectDal)
        {
            _projectDal = projectDal;
        }
        public void Add(Project project)
        {
            _projectDal.Add(project);
        }

        public void Delete(Project project)
        {
            _projectDal.Delete(project);
        }

        public List<Project> GetAll()
        {
            return _projectDal.GetAll();
        }

        public Project GetById(int id)
        {
            return _projectDal.GetById(id);
        }

        public void Update(Project project)
        {
            _projectDal.Update(project);
        }
    }
}
