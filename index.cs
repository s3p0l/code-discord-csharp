using System;
using System.Collections.Generic;
using System.Text;



namespace Kawhi
{
    class program
    {
 
     static void Main(string[]args)
     {
		 var bot = new Bot();
         bot.RunAsync().GetAwaitter().GetResult();
	
     }
    }
}