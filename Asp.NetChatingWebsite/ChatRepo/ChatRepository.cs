using Asp.NetChatingWebsite.Data;
using Asp.NetChatingWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetChatingWebsite.ChatRepo
{
    public class ChatRepository
    {
        public ChatContext _chatContext = null;
        public ChatRepository (ChatContext chatContext)
        {
            _chatContext = chatContext;
        }


        public int SentDataIntoDb(string UserMessage, string UserKaNaam )
        {
            
            var data = new ChatingPage()
            {
                Message2 = UserMessage,
                SentOn2 = DateTime.Now,
                Name2= UserKaNaam
            };

            _chatContext.MsgTable1.Add(data);
            _chatContext.SaveChanges();
            return data.Id;
        }

        public List<ChatingPage> SentDataIntoDb()
        {
            var Data = _chatContext.MsgTable1.ToList();
            return Data;
        }
        public List<ChatingPage> chatingpage()
        {
            var Data = _chatContext.MsgTable1.ToList();
            return Data;
        }
        public int Index_Repository()
        {
            var Data = _chatContext.MsgTable1.ToList();
            int id = 0;
            foreach(var a in Data)
            {
                id = a.Id;
            }
            return id;
        }


    }
}
