using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Kreta.Models;
using Kreta.Repositories;

namespace Kreta.ViewModel
{
    class ClassViewModel
    {
        private ClassesRepo classesRepo;

        public ClassViewModel()
        {
            classesRepo = new ClassesRepo();
        }

    }
}
