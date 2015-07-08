using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Xml.Serialization;

namespace WeChat.Models {
    [Serializable]
    [XmlRootAttribute(ElementName="xml")]
    public class TextMessage {
        public TextMessage(){
            this.MsgType = "text";
        }
        public string ToUserName { get; set; }
        public string FromUserName { get; set; }
        public string CreateTime {get; set;}
        public string MsgType {get; set;}
        public string Content {get;set;}

    }
}