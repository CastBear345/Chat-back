namespace Api.Abstractions;

public interface IChatClient
{
    public Task ReceiveMessage(string userName, string message);
}