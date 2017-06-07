using System;
public class Avaliacao : ICloneable 
{
    public int Rating {
        get
        {
            return Rating;
        }
        set
        {
            if (value < 1 || value > 5)
                throw new InvalidInputException("Rating must be between 1 and 5.");

            this.Rating = value;
        }
    }
    public string Comment { get; set; }
    public DateTime Date { get; set; }
    
    public Avaliacao(int rating, string comment, DateTime date)
    {
        this.Rating = rating;
        this.Comment = comment;
        this.Date = date;
    }

    public object Clone()
    {
        return this.MemberwiseClone();
    }
}