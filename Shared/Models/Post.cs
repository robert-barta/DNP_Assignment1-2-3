﻿namespace Shared;

public class Post
{
    public int Id { get; set; }
    public User Owner { get; set; }
    public String Title { get; }
    public String Body { get; set; }

    public Post(User owner, string title, string body)
    {
        Owner = owner;
        Title = title;
        Body = body;
    }
}