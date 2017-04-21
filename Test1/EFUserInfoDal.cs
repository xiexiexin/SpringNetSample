using System;

namespace Spring.Net
{
    public class EFUserInfoDal : IUserInfoDal
    {
        public void Show()
        {
            Console.WriteLine("I'm EF Dal");
        }
    }
}