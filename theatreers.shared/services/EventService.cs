using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using theatreers.shared.Models;
using theatreers.shared.Interfaces;

namespace theatreers.shared.Services
{
    public class EventService : IEventService
    {
        public IEnumerable<Event> GetAll()
        {
            throw new NotImplementedException();
        }
        
        public Event GetById(int id)
        {
            throw new NotImplementedException();
        }
        public Event Create(Event item)
        {
            throw new NotImplementedException();
        }
        public Event Update(Event item)
        {
            throw new NotImplementedException();
        }
    
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}