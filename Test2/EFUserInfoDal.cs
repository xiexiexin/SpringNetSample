using System;

namespace Spring.Net
{
    public class EFUserInfoDal : IUserInfoDal
    {
        public EFUserInfoDal()
        {

        }
        public UserInfo UserInfo { get; set; }
        public string Name { get; set; }

        public void Show()
        {
            Console.WriteLine("I'm EF Dal,inject ：Name=" + Name);
            Console.WriteLine("UserInfo ,Name=" + UserInfo.Name + " Age=" + UserInfo.Age);
        }
    }
}