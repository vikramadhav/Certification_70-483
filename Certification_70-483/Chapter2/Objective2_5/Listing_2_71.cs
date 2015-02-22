namespace Certification.Chapter2.Objective2_5
{
    using System;
    using System.Linq;

    using Certification.Common;
    using System.Reflection;

    [Listing("Reflection")]
    public class Listing_2_71 : IRunnable
    {
        public void Run()
        {
            var assembly = typeof(Listing_2_71).Assembly;
            var plugins = from type in assembly.GetTypes()
                          where typeof(IPlugin).IsAssignableFrom(type) && !type.IsInterface
                          select type;

            foreach (Type plugin in plugins)
            {
                var instance = Activator.CreateInstance(plugin) as IPlugin;
                instance.Execute();
            }

            Console.WriteLine();
            DumpObject(new MyClass());
        }

        static void DumpObject(object obj)
        {
            FieldInfo[] fields = obj.GetType().GetFields(BindingFlags.Instance | BindingFlags.
            NonPublic);
            foreach (FieldInfo field in fields)
            {
                if (field.FieldType == typeof(int))
                {
                    Console.WriteLine(field.Name + ": " + field.GetValue(obj));
                }
            }
        }

        public interface IPlugin
        {
            string Name { get; set; }
            void Execute();
        }

        public class FirstPlugin : IPlugin
        {

            public string Name { get; set; }

            public void Execute()
            {
                Console.WriteLine("My first plugin !");
            }
        }

        public class SecondPlugin : IPlugin
        {

            public string Name { get; set; }

            public void Execute()
            {
                Console.WriteLine("My second plugin !");
            }
        }

        class MyClass
        {
            private int firstInt = 3;

            private int secondInt = 4;

            private string aString = "toto";

            private int thirdInt = 1;
        }
    }
}
