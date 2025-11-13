using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem8Course23
{
    internal class Program
    {
//        Dynamic Skill Matching
//Problem: Match a candidate’s skills to a job’s required skills.

//Input:

//candidateSkills = { "C#", "SQL", "JavaScript" }

//jobRequirements = { "C#", "JavaScript", "React" }

//Output: Matching Skills: C#, JavaScript
        static void Main(string[] args)
        {
            HashSet<string> candidateSkills = new HashSet<string> { "C#", "SQL", "JavaScript" };
            HashSet<string> jobRequirements = new HashSet<string> { "C#", "JavaScript", "React" };

            candidateSkills.IntersectWith(jobRequirements);

            Console.WriteLine($"Job Requirements : " + string.Join(" , ", candidateSkills));

            Console.ReadLine();
        }
    }
}
