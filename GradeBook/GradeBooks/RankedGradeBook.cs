using System;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
  public class RankedGradeBook : BaseGradeBook
  {
    public RankedGradeBook(string name) : base(name)
    {
      Type = GradeBookType.Ranked;
    }

    public override char GetLetterGrade(double averageGrade)
    {
      if(Students.Count < 5)
        throw new InvalidOperationException("Minimum number of students to create a Ranked Grade Book is 5");

      switch(averageGrade)
      {
        case var grade when grade >= 80:
          return 'A';

        case var grade when grade >= 60 && grade < 80:
          return 'B';

        case var grade when grade >=40 && grade < 60:
          return 'C';

        case var grade when grade >=20 && grade < 40:
          return 'D';

        default:
          return 'F';
      }
    }
  }
}