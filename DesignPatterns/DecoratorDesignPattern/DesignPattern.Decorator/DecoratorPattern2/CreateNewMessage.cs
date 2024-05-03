﻿using DesignPattern.Decorator.DAL;

namespace DesignPattern.Decorator.DecoratorPattern2
{
    public class CreateNewMessage : ISendMessage
    {
        Context context = new Context();
        virtual public void SendMessage(Message message)
        {
            context.Messages.Add(message);
            context.SaveChanges();
        }
    }
}
