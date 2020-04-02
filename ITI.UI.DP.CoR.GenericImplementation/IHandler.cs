namespace ITI.UI.DP.CoR.GenericImplementation
{
    interface IHandler
    {
        IHandler SetNext(IHandler handler);
        object Handle(object request);
    }
}