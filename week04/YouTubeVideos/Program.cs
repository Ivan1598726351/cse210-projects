using System;

class Program
{
    static void Main(string[] args)
    {
        List <Video> _videos=new List<Video>();
        Video video1=new Video("Ivan523","How to boil an egg",253);
        Comment comment1= new Comment("Danilo172","Good tutorial");
        Comment comment2= new Comment("JurijDim","Very good!");
        Comment comment3= new Comment("Valcic81", "Just what I needed");
        video1.AddComments(comment1);
        video1.AddComments(comment2);
        video1.AddComments(comment3);
        _videos.Add(video1);
        Video video2=new Video("Maksim091","Classical mechanics vs Quantum mechanics",1072);
        Comment comment4= new Comment("Dmitrij_Vasil","Well explained");
        Comment comment5= new Comment("Ivanovich_Koslov","Could someone tell me where is QM applicable?");
        Comment comment6= new Comment("198uvy", "Remember this from my university, good stuff");
        video2.AddComments(comment4);
        video2.AddComments(comment5);
        video2.AddComments(comment6);
        _videos.Add(video2);
        Video video3=new Video("SiviSoko192","Funny cats video part 12",759);
        Comment comment7= new Comment("Lukacin1","So funny, needed this");
        Comment comment8= new Comment("Kiviwi","Fantastic stuff haha");
        Comment comment9= new Comment("Vigo09871", "Love your cat videos");
        video3.AddComments(comment7);
        video3.AddComments(comment8);
        video3.AddComments(comment9);
        _videos.Add(video3);

        foreach (Video video in _videos)
        {
            Console.WriteLine(video.GetDisplayVideo());
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            Console.WriteLine(video.DisplayComments());

        }



        
    }
}