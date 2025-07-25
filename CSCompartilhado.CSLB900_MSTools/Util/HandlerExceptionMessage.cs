namespace CSLB900.MSTools.Util
{
    public static class HandlerExceptionMessage
    {
        public static string CreateExceptionMessage(Exception ex)
        {
            var msg = ex.Message;
            if (ex.InnerException != null)
            {
                msg = ex.InnerException.Message;
            }
            return msg;
        }
    }
}
