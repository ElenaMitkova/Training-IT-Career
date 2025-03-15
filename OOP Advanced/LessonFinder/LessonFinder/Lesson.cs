using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public abstract class Lesson
{
    public string Title { get; set; }
    public int Duration { get; set; }
    public int Grade { get; set; }
    public int Difficulty { get; set; }
    public string Teacher { get; set; }
    private List<int> ratings;
    public Lesson(string title, int duration, int grade, int difficulty, string teacher)
    {
        if (title.Length < 3 || title.Length > 54)
        {
            throw new ArgumentException("Title should be between 3 and 54 characters!");
        }
        if (duration < 0)
        {
            throw new ArgumentException("Duration should be positive!");
        }
        if (grade < 1 || grade > 12)
        {
            throw new ArgumentException("Grade should be between 1 and 12!");
        }
        if (difficulty < 1 || difficulty > 3)
        {
            throw new ArgumentException("Difficulty should be between 1 and 3!");
        }
        if (teacher.Length < 3 || teacher.Length > 54)
        {
            throw new ArgumentException("Teacher should be between 3 and 54 characters!");
        }
        this.Title = title;
        this.Duration = duration;
        this.Grade = grade;
        this.Difficulty = difficulty;
        this.Teacher = teacher;
        this.ratings = new List<int>();
    }
    public void AddRating(int rate)
    {
        ratings.Add(rate);
    }
    public double Rating
    {
        get
        {
            if (ratings.Count == 0)
            {
                return 0;
            }
            return ratings.Average();
        }
    }
    public override string ToString()
    {
        return $"Title: {Title} for {Grade} grade ({Duration} mins.) - difficulty {Difficulty} by {Teacher} (Rating: {Rating:F2} / 5)";
    }
}