
namespace Test
{
    class Program
    {
        private static void Main(string[] args)
        {
            Test_MsgPack.Execute();
            Test_WriteStream.Execute();
            Test_PubSub.Execute();
            //Test_WCF.Execute();   // kmp crashes
            Test_Stream.Execute();
            //Test_SocketObject.Execute();  // kmp crashes
            Test_Pair.Execute();
            Test_PushPull.Execute();
            Test_Listener.Execute();
            //Test_Symbol.Execute();    // kmp crashes
            //Test_ReqRep.Execute();    // kmp crashes
            //Test_GetSetOptions.Execute(); // kmp crashes
        }
    }
}
