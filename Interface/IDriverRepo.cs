
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormulaApi.Interface
{
    public interface IDriverRepo
    {
        public Task<string> Get();

    }
}