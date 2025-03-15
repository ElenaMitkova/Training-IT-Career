using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Subject
{
    public string Name { get; set; }
    private List<Lesson> lessons;
    public Subject(string name)
    {
        if (name.Length < 2 || name.Length > 40)
        {
            throw new ArgumentException("Name should be between 2 and 40 characters!");
        }
        this.Name = name;
        this.lessons = new List<Lesson>();
    }
    public void AddLesson(Lesson lesson)
    {
        lessons.Add(lesson);
    }
    public double AverageRating()
    {
        double rating = 0;
        foreach (var lesson in lessons)
        {
            rating += lesson.Rating;
        }
        return rating;
    }
    public List<Lesson> GetLessonsByTeacher(string teacher)
    {
        return lessons.Where(lesson => lesson.Teacher == teacher).OrderByDescending(lesson => lesson.Duration).ToList();
    }
    public List<Lesson> GetLessonsBetweenDuration(int from, int to)
    {
        return lessons.Where(lesson => lesson.Duration > from && lesson.Duration < to).OrderByDescending(lesson => lesson.Rating).ToList();
    }
    public void AddRate(string title, int rate)
    {
        Lesson lesson = lessons.Where(name => name.Title == title).First();
        if (lesson == null)
        {
            throw new ArgumentException("Lesson not found!");
        }
        lesson.AddRating(rate);
    }
}