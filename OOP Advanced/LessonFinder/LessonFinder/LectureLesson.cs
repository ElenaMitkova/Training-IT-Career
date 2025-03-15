using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class LectureLesson : Lesson
{
    public LectureLesson(string title, int duration, int grade, int difficulty, string teacher, string location) : base(title, duration, grade, difficulty, teacher)
    {
        if (location.Length < 3 || location.Length > 30)
        {
            throw new ArgumentException("Location should be between 3 and 30 characters!");
        }
        this.Location = location;
    }
    public string Location { get; set; }
    public override string ToString()
    {
        return $"{base.ToString()} @ Onsite: {Location}";
    }
}