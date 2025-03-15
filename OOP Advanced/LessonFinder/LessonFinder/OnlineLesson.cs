using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class OnlineLesson : Lesson
{
    public string Platform { get; set; }
    public OnlineLesson(string title, int duration, int grade, int difficulty, string teacher, string platform) : base(title, duration, grade, difficulty, teacher)
    {
        if (platform.Length < 3 || platform.Length > 30)
        {
            throw new ArgumentException("Platform should be between 3 and 30 characters!");
        }
        this.Platform = platform;
    }
    public override string ToString()
    {
        return $"{base.ToString()} @ Online: {Platform}";
    }
}