using System.Globalization;
using System.Reflection.PortableExecutable;
using System.Transactions;

public class Video
{
    private List <Comment> _comments=new List <Comment>();    
    private string _author;
    private string _title;
    private int _length;

    public Video(string author, string title, int length)
    {
        _author=author;
        _title=title;
        _length=length;

    }

    
    public string GetDisplayVideo()
    {
        return "author:"+_author+", "+"title:"+_title+", "+"length:"+_length;
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
        
    }

    public void AddComments(Comment comment)
    {
        _comments.Add(comment);
    }    


    public string DisplayComments()
    {
        string comments="";
        foreach(Comment comment in _comments)
        {
            comments=comments+comment.DisplayComment()+"\n";
        

        }

        return comments;
    }






}
