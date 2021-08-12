using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDAssignment.Program.Entities;
using TDDAssignment.Program.Interface;

namespace TDDAssignment.Program.Service
{
    public class UserService : IUserService
    {
        public void Save(User user)
        {
            if(user.Lastname == null)
            {
                throw new ArgumentNullException(nameof(user.Lastname));
            }
            if (string.IsNullOrWhiteSpace(user.Lastname))
            {
                throw new ArgumentException(nameof(user.Lastname));
            }
            if(user.Email == null)
            {
                throw new ArgumentNullException(nameof(user.Email));
            }

            throw new NotImplementedException();
        }

        public bool Validate(User user)
        {
            throw new NotImplementedException();
        }
    }
}
