namespace MessengerAPI
{
    public interface IGateway<T, Params, Result> where T: ISendMessagePlatform<Params, Result>
    {
        
    }

    public struct SendResponse
    {
        string sendid;
    }
}