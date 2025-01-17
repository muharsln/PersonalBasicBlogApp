﻿using Core.Common;

namespace Core.Entities;

public class User : BaseEntity<Guid>
{
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public ICollection<Post>? Posts { get; set; }
    public ICollection<Comment>? Comments { get; set; }
}