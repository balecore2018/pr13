using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _13prak.Interfaces;
using _13prak.Models;
using System.Collections.Generic;

namespace _13prak.Interfaces
{
    public interface IUsers
    {
        void All(out List<Users> Users);
    }
}
