using System;

namespace Test
{
    class Program
    {
        private static void Main(string[] args)
        {
            Test_MsgPack.Execute();
            Test_WriteStream.Execute();
            Test_PubSub.Execute();
            //Test_WCF.Execute();           // crashes
            Test_Stream.Execute();
            //Test_SocketObject.Execute();  // crashes
            Test_Pair.Execute();
            Test_PushPull.Execute();
            Test_Listener.Execute();
            //Test_Symbol.Execute();        // crashes
            //Test_ReqRep.Execute();        // crashes
            //Test_GetSetOptions.Execute(); // crashes

            Console.WriteLine("Finished test");
        }
    }
}
