using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Service
{
    public interface IService
    {
        Task<List<string>> GetCustomerAll();
    }
}
