using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern
{
    public class Mediator : IMediator
    {
        List<User> _users = new List<User>();

        public void Register(User user)
        {
            user.Mediator = this;
            _users.Add(user);
        }

        public void SendMessage(string message, User user)
        {
            foreach (var u in _users)
            {
                if (u!=user)
                {
                    u.Send(message);
                }
            }
        }
    }
}
