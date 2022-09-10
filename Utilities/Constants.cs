using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;

namespace App.Utilities
{
    public static class MyConstants
    {
        public static List<string> Educations = new List<string>
        {
            primaryEducation, SecondaryEducation, FirstDegree, Masters, Doctorates
        };

        public const string primaryEducation = "Primary Education";
        public const string SecondaryEducation = "O, Levels";
        public const string FirstDegree = "First Degree";
        public const string Masters = "Masters";
        public const string Doctorates = "Doctorates";

    }
}
