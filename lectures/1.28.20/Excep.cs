using System;
using System.Collections.Generic;
using System.Text;

namespace _1._28._20
{
    class Excep
    {
        public void Exc()
        {
            string str = null;
            try
            {
                var leng = str?.Length;
                // throw new Exception("message");
                //throw new NullReferenceException();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Source);
                Console.WriteLine(ex.InnerException);

                throw;
            }
            finally
            {
                str = null;
            }
        }
    }
}
