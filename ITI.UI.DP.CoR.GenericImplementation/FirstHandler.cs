namespace ITI.UI.DP.CoR.GenericImplementation
{
    class FirstHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if ((request as string) == "first request")
            {
                return $"First Handler: I'll handle the {request.ToString()}.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}