using System;
using System.Linq;
using System.Reflection;

namespace Refl
{
    class Program
    {
        static void Main(string[] args)
        {
            //Moto moto = new Moto("Honda");
            //moto.GetType();
            //Console.WriteLine(moto);
            //using (FileStream f = File.AppendAllLines("",list)) foreach
            //Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
            
            Type motoType = typeof(Moto);

            Type ctorParametr = Type.GetType("System.String");
            //ConstructorInfo ctor = motoType.GetTypeInfo().DeclaredConstructors
               // .FirstOrDefault(ct => ct.GetParameters()[0].ParameterType.Equals(ctorParametr));
            object[] arg = new object[] { "Honda" };
            var ctorDefault = motoType.GetConstructors().First();

            //object obj = ctor.Invoke(arg);
            object obj = ctorDefault.Invoke(null);
            Console.WriteLine($"Current type - {obj.GetType()}");
            Console.WriteLine(obj.ToString());

            FieldInfo filedInfo = obj.GetType().GetTypeInfo().GetDeclaredField("_vinNumber");
            Console.WriteLine($"Filed - {filedInfo.Name}\nIs Private - {filedInfo.IsPrivate}");
            filedInfo.SetValue(obj, 999_999);
            Console.WriteLine(obj);
         }
    }
}
