using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
public class Controller
{
    private readonly Dictionary<string, Subject> subjects = new Dictionary<string, Subject>();
    public string AddSubject(List<string> args)
    {
        string name = args[0];
        if (subjects.ContainsKey(name))
        {
            return "Subject already exists!";
        }
        subjects[name] = new Subject(name);
        return $"Created Subject {name}!";
    }
    public string AddLesson(List<string> args)
    {
        string name = args[0];
        string title = args[1];
        int duration = int.Parse(args[2]);
        int grade = int.Parse(args[3]);
        int difficulty = int.Parse(args[4]);
        string teacher = args[5];
        string type = args[6];
        Lesson subject = null;
        if (type == "online")
        {
            string platform = args[7];
            subject = new OnlineLesson(title, duration, grade, difficulty, teacher, platform);
        }
        else if (type == "lecture")
        {
            string location = args[7];
            subject = new LectureLesson(title, duration, grade, difficulty, teacher, location);
        }
        subjects[name].AddLesson(subject);
            return $"Created Lesson {title} in Subject {name}!";
    }
    public string RateLesson(List<string> args)
    {
        string name = args[0];
        string title = args[1];
        int rate = int.Parse(args[2]);
        subjects[name].AddRate(title, rate);
        return $"Rated {title} with {rate} rate.";
    }
    public string GetAverageRating(List<string> args)
    {
        string name = args[0];
        return $"The average rating is: {subjects[name].AverageRating():F2}";
    }
    public string GetLessonsByTeacher(List<string> args)
    {
        string name = args[0];
        string teacher = args[1];
        return string.Join(Environment.NewLine, subjects[name].GetLessonsByTeacher(teacher));
    }
    public string GetLessonsBetweenDuration(List<string> args)
    {
        string name = args[0];
        int from = int.Parse(args[1]);
        int to = int.Parse(args[2]);
        return string.Join(Environment.NewLine, subjects[name].GetLessonsBetweenDuration(from, to));
    }
}