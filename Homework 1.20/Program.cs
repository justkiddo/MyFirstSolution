using System.Reflection;
using System.Runtime.Loader;

namespace Homework_1._20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(Environment.CurrentDirectory);

                string path = "C:\\Users\\vanek\\OneDrive\\документы\\Git Projects\\Homework 1.20\\Plugins\\Library.dll";

                Assembly assembly = AssemblyLoadContext.Default.LoadFromAssemblyPath(path);

                //var types = assembly.GetTypes();
                //foreach (var t in types)
                //{
                //    Console.WriteLine(t.FullName);  // Plugin.Plugin
                //}

                var type = assembly.GetType("Plugin.Plugin");
                var activator = Activator.CreateInstance(type);

                //var methods = type.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);
                //foreach (var m in methods)
                //{
                //    Console.WriteLine(m); // void RunLogic1
                //}


                MethodInfo methodInfo = type.GetMethod("RunLogic1", BindingFlags.NonPublic | BindingFlags.Instance);

                //var parameters = methodInfo.GetParameters();
                //foreach (var p in parameters)
                //{
                //    Console.WriteLine(p);   // System.String message
                //}


                methodInfo.Invoke(activator, new object[] { "Some message" });
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}