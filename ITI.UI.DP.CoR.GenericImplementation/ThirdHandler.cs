namespace ITI.UI.DP.CoR.GenericImplementation
{
    class ThirdHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if ((request as string) == "third request")
            {
                return $"Third Handler: I'll handle the {request.ToString()}.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}