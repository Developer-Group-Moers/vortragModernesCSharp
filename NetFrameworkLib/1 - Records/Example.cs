using System;

namespace NetFrameworkLib._1___Records
{
    public static class Example
    {
        public static void Run()
        {
            // Person person = new Person
            // {
            //     Id = new PersonId(Guid.Parse("CCD4D745-98E9-40AC-A702-C3792B8A0180")),
            //     Name = "timo"
            // };
        }
    }

    record Person(string Name, int Age)
    {
        public required string Address { get; init; }
    }
    
    readonly record struct Point2d(int X, int Y);

    readonly record struct PersonId(Guid Value);
}

namespace System.Runtime.CompilerServices
{
    public class IsExternalInit
    {
        
    }

    public class RequiredMemberAttribute
    {
        
    }

    public class CompilerFeatureRequiredAttribute : Attribute
    {
        public CompilerFeatureRequiredAttribute(string featureName)
        {
            
        }
    }
}

namespace System.Diagnostics.CodeAnalysis
{
    public class SetsRequiredMembersAttribute : Attribute
    {
        
    }
}