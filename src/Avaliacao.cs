using System;
public class Avaliacao : ICloneable 
{
    public int rating { 
        get; 
        set
        {
        if (value < 1 || value > 5)
            throw new InvalidInputException("Rating must be between 1 and 5.");

        this.rating = value;
        }
    }
    public string comment { get; set; }
    public DateTime date { get; set; }
    
    public Avaliacao(int rating, string comment, DateTime date)
    {
        this.rating = rating;
        this.comment = comment;
        this.date = date;
    }

    public object Clone()
    {
        return this.MemberwiseClone();
    }
}