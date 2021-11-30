using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CamSanctuaryRest.Controllers;
using CamSanctuaryRest.Models;

namespace CamSanctuaryRest.Managers
{
    public class ReceiverManager
    {
        private static int _nextId = 1;

        private readonly CamsanctuarydbContext _context;

        public ReceiverManager(CamsanctuarydbContext context)
        {
            _context = context;
        }

        //public ReceiverManager()
        //{

        //}

        public IEnumerable<Message> GetAll()
        {
            return _context.Messages.ToList();
        }


        public Message AddMessage(Message newMessage)
        {
            newMessage.Id = 0;
            _context.Messages.Add(newMessage);
            _context.SaveChanges();
            return newMessage;
        }



        }


}
