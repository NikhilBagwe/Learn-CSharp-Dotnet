using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FormulaApi.Interface;

namespace FormulaApi.Service
{
    public class DriverRepo : IDriverRepo
    {
        public async Task<string> Get()
        {
            string test = "BHarat";
            return test;
            // throw new NotImplementedException();
        }
    }
}