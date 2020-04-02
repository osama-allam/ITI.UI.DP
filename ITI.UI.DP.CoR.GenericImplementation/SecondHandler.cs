namespace ITI.UI.DP.CoR.GenericImplementation
{
    class SecondHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if ((request as string) == "second request")
            {
                return $"Second Handler: I'll handle the {request.ToString()}.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}