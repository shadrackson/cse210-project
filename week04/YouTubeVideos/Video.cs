// I am using GitHub for the code since my VS Code keeps hanging

using System.Collection.Generic;

// Class
public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;   // A video has many comment objects


// Constructor
    public Video(string title, string author, int length)
    {
      _title = title;
      _author = author;
      _length = length;
    
      _comments = new List<Comment>();
    }

// Method
// Adding a comment
    public void AddComment(Comment comment)
    {
      _comments.Add(comment);
    }

// Getting the number of comments
    public int GetNumberOfComments()
    {
      return _comments.Count;
    }  

// Getter Methods
    public string GetTitle()
    {
      return _title;
    }

    public string GetAuthor()
    {
      return _author;
    }

    public int GetLength()
    {
      return _length;
    }

    public LIst<Comment> GetComments()
    {
      return _comments;
    }
} 



  
    
