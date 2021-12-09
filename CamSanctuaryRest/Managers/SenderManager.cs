using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using CamSanctuaryRest.Models;

namespace CamSanctuaryRest.Managers
{
    public class SenderManager
    {
        public static List<VideoData> data = new List<VideoData>();

        private readonly CamsanctuarydbContext _context;
        public SenderManager(CamsanctuarydbContext context)
        {
            _context = context;
        }
        public SenderManager()
        {

        }
        public IEnumerable<Message> GetAll()
        {
            return _context.Messages.ToList();
        }

        public Message GetById(int id)
        {
            return _context.Messages.Find(id);

        }
        public IEnumerable<VideoData> GetAllVideo()
        {
            return new List<VideoData>(data);
        }

    }
}