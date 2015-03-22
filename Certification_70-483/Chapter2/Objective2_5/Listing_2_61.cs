namespace Certification.Chapter2.Objective2_5
{
    using System;
    using System.Diagnostics;

    using Certification.Common;

    /// <summary>
    /// Attributes
    /// </summary>
    [Listing("Attributes")]
    //[Listing("Other description")] //Does not compile because of [AttributeUsage(AllowMultiple = false)]
    public class Listing_2_61 : IRunnable
    {
        //[Listing("Run")] //Does not compile because of [AttributeUsage(AttributeTargets.Class)]
        public void Run()
        {
            var person = new Person { Name = "Toto" };
            person.Talk();

            var isSerializable = Attribute.IsDefined(typeof(Person), typeof(SerializableAttribute));
            Console.WriteLine("Person is serializable: " + isSerializable);

            foreach (var method in typeof(Person).GetMethods())
            {
                var conditionalAttribute = (ConditionalAttribute)Attribute.GetCustomAttribute(
                    method,
                    typeof(ConditionalAttribute));
                if (conditionalAttribute != null)
                {
                    Console.WriteLine(method.Name + ": " + conditionalAttribute.ConditionString);
                }
            }
        }

        [Serializable]
        class Person
        {
            public string Name { get; set; }

            [Conditional("DEBUG")]
            public void Talk()
            {
                Console.WriteLine("Hello !");
                this.SayYourName();
            }

            [Conditional("Name")]
            public void SayYourName()
            {
                Console.WriteLine("My name is " + this.Name);
            }
        }
    }
}
