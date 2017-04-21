using System;

namespace Spring.Net
{
    public class AdoNetUserInfoDal : IUserInfoDal
    {
        public AdoNetUserInfoDal(string name, UserInfo userInfo)
        {
            Name = name;
            UserInfo = userInfo;
        }
        public UserInfo UserInfo { get; set; }
        public string Name { get; set; }

        public void Show()
        {
            Console.WriteLine("I'm AdoNet Dal ,Inject Name ：Name=" + Name);
            Console.WriteLine("UserInfo ,Name=" + UserInfo.Name + " Age=" + UserInfo.Age);
        }
    }
}