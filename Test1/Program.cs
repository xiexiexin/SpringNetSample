using Spring.Context;
using Spring.Context.Support;
using Spring.Net;
using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Spring.Net 创建实例的方式转为容器帮我们创建
            //创建spring容器上下文
            IApplicationContext ctx = ContextRegistry.GetContext();
            //通过容器创建对象
            IUserInfoDal efDal = ctx.GetObject("UserInfoDal") as IUserInfoDal;
            efDal.Show();
            Console.ReadKey();
        }
    }
}