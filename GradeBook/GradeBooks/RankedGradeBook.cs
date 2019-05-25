using System;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
  public class RankedGradeBook : BaseGradeBook
  {
    public RankedGradeBook(string name, bool isWeighted) : base(name, isWeighted)
    {
      Type = GradeBookType.Ranked;
    }

    public override char GetLetterGrade(double averageGrade)
    {
      if (Students.Count < 5)
        throw new InvalidOperationException("Minimum number of students to create a Ranked Grade Book is 5");

      switch (averageGrade)
      {
        case var grade when grade >= 80:
          return 'A';

        case var grade when grade >= 60 && grade < 80:
          return 'B';

        case var grade when grade >= 40 && grade < 60:
          return 'C';

        case var grade when grade >= 20 && grade < 40:
          return 'D';

        default:
          return 'F';
      }
    }

    public override void CalculateStatistics()
    {
      if (Students.Count < 5)
      {
        Console.WriteLine("Ranked grading requires at least 5 students with grades in order to properly calculate a student's overall grade.");
        return;
      }

      base.CalculateStatistics();
    }

    public override void CalculateStudentStatistics(string name)
    {
      if(Students.Count < 5)
      {
        Console.WriteLine("Ranked grading requires at least 5 students with grades in order to properly calculate a student's overall grade.");
        return;
      }

      base.CalculateStudentStatistics(name);
    }
  }
}