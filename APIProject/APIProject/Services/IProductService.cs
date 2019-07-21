using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIProject.Models;

namespace APIProject.Services
{
    public interface IProductService
    {
        string Get(int id);
        string Add(Product product);
    }
}
