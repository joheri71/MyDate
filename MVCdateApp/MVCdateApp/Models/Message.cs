using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCdateApp.Models
{
    public class Message
    {
        public int Id { get; set; }
        public int SenderUserId { get; set; }
        public int ReceiverUserId { get; set; }
        public string Msg { get; set; }
    }
}