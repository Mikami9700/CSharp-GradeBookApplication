using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public BaseGradeBook(string name, bool isWeighted)
        {
            Type = GradeBookType.Standard;
        }
    }
}
