using Spring.Context;
using Spring.Context.Support;
using System;

namespace Spring.Net
{
    class Program
    {
        static void Main(string[] args)
        {
            //第一步，引用Spring.Net程序集 Spring.Core.dll 和 Common.Logging.dll
            //第二步，添加Spring.Net配置节点
            //第三步，配置object节点
            //第四步，创建spring容器上下文
            IApplicationContext ctx = ContextRegistry.GetContext();
            //第五步，通过容器创建对象
            IUserInfoDal efDal = ctx.GetObject("UserInfoDal") as IUserInfoDal;
            efDal.Show();

            IUserInfoDal adoDal = ctx.GetObject("UserInfoDal2") as IUserInfoDal;
            adoDal.Show();

            Console.ReadKey();
        }
    }
}
