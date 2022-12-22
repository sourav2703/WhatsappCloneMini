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
                Message = UserMessage,
                SentOn = DateTime.Now,
                Name= UserKaNaam


            };

            _chatContext.Messagesss.Add(data);
            _chatContext.SaveChanges();
            return data.Id;
        }

        public List<ChatingPage> SentDataIntoDb()
        {
            var Data = _chatContext.Messagesss.ToList();
            return Data;
        }
        public List<ChatingPage> chatingpage()
        {
            var Data = _chatContext.Messagesss.ToList();
            return Data;
        }
       

    }
}
