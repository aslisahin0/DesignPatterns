﻿using DesignPattern.Decorator.DAL;

namespace DesignPattern.Decorator.DecoratorPattern2
{
    public class EncryptByContentDecorator : Decorator
    {
        private readonly ISendMessage _sendMessage;
        Context context = new Context();
        public EncryptByContentDecorator(ISendMessage sendMessage) : base(sendMessage)
        {
            _sendMessage = sendMessage;
        }
        public void SendMessageByEncryptoContent(Message message)
        {
            message.MessageSender = "Takım Lideri";
            message.MessageReceiver = "Yazılım Ekibi";
            message.MessageContent = " Saat 17.00de Publish işlemi yapılacak.";
            message.MessageSubject = "Publish";
            string data = "";
            data = message.MessageContent;
            char[] chars = data.ToCharArray();
            //şifreli olması için böyle yapıldı.
            foreach (var item in chars)
            {
                message.MessageContent += Convert.ToChar(item + 3).ToString();
            }
            context.Messages.Add(message);
            context.SaveChanges();
        }
        public override void SendMessage(Message message)
        {
            base.SendMessage(message);
            SendMessageByEncryptoContent(message);  
        }
    }
}
