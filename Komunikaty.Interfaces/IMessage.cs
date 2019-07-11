namespace Komunikaty.Interfaces
{
    public interface IMessage
    {
        int Id { get; set; }
        bool ConfirmationRequired { get; set; }
        bool Confirmed { get; set; }
        bool Favourite { get; set; }
        MessageType MessageType { get; set; }
        string Content { get; set; }
    }
}
