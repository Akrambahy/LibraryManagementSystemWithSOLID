




class Book
{
    public void Borrow()
    {
    }

    public void Return()
    {
    }

   

  
}


class Report
{
    public void Generate()
    {
    }
}

class Database
{
    public void Save()
    {
    }
}

interface ISender
{
   public void Send(string massage);
}


class SendEmail : ISender

{
       public void Send(string massage)
    {
        Console.WriteLine(massage);
    }
}
class SendSMS : ISender

{
       public void Send(string massage)
    {
        Console.WriteLine(massage);
    }
}
class SendWhatsApp : ISender

{
       public void Send(string massage)
    {
        Console.WriteLine(massage);
    }
}


class Notification
{

 private    ISender Sender ;

   public Notification (ISender SendMethod)
    {
        Sender=SendMethod;
    }
    public void Send(string massage)
    {
        Sender.Send(massage);
    }
}


interface IReceiveNotification
{
    public  void ReceiveNotification(string message);
}

class User
{
    public string username , password;
}

class NormalUser : User,IReceiveNotification
{
    public  void ReceiveNotification(string message)
    {
        Console.WriteLine(message);
    }
}

class SilentUser : User
{
    

}

interface IDBMS
{
    public void Save();

}


class PostgreSql : IDBMS
{
     public void Save()
    {
        Console.WriteLine("Save with PostgreSql");
    }
   
}

class MySql : IDBMS
{
     public void Save()
    {
        Console.WriteLine("Save with MySql");
    }
   
}

class File : IDBMS
{
     public void Save()
    {
        Console.WriteLine("Save with File");
    }
   
}

class BookService
{
    private IDBMS database;



    public BookService(IDBMS databaseType)
    {
        database=databaseType;
    }


    public void SaveBook()
    {
        database.Save();
    }
}