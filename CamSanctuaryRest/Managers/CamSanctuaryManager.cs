using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CamSanctuaryRest.Controllers;
using CamSanctuaryRest.Models;

namespace CamSanctuaryRest.Managers
{
    public class CamSanctuaryManager
    {
        private static int _nextId = 1;

        

        public List<Files> GetAll()
        {
            return new List<Files>();
            // copy constructor
            // Callers should no get a reference to the Data object, but rather get a copy
        }

        }
}
