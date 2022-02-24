﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Kreta.Models;
using Kreta.Repositories;
using System.Collections.ObjectModel;

namespace Kreta.ViewModel
{
    class ClassViewModel
    {
        private ClassesRepo classesRepo;
        private ObservableCollection<Class> classes;

        public ClassViewModel()
        {
            classesRepo = new ClassesRepo();
        }

        public ObservableCollection<Class> Classes { get => classes; set => classes = value; }
    }
}
