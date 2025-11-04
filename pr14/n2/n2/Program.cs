using System;

class Message
{
    public virtual void Send()
    {
        Console.WriteLine("Сообщение отправлено.");
    }
}

class Email : Message
{
    public override void Send()
    {
        Console.WriteLine("Email отправлен!");
    }
}

class SMS : Message
{
    public override void Send()
    {
        Console.WriteLine("SMS отправлено!");
    }
}

class ProgramMessages
{
    static void Main()
    {
        Message[] messages = { new Email(), new SMS(), new Message() };
        foreach (var m in messages)
        {
            m.Send();
        }
        Console.ReadLine();
    }
}