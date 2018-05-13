namespace CustomerWebApp.Abstract
{
    public class MessageHelper : IMessageHelper
    {
        public string GetAboutMessage()
        {
            return "Your application description page.";
        }

        public string GetContactMessage()
        {
            return "Your contact page.";
        }
    }
}