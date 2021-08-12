using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDAssignment.Program.Entities;

namespace TDDAssignment.Program.Interface
{
    public interface IUserService
    {
        public void Save(User user);
        public bool Validate(User user);
    }
}
