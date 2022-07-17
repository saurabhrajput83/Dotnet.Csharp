using Delegates;
using IAAC;
using SOLID;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Startup
{
    public class SOLIDTest
    {

        public void Run()
        {
            Console.WriteLine("====SOLIDTest Run Starts====");

            PostHandler objPostHandler = new PostHandler();
            objPostHandler.CreatePost("@This is a mention post.");
            objPostHandler.CreatePost("#This is a tag post.");
            objPostHandler.CreatePost("This is a post.");

            Console.WriteLine("====SOLIDTest Run Ends====");
        }


    }
}
