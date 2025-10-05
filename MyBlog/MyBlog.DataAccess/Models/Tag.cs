﻿using System;
using System.Collections.Generic;

namespace MyBlog.DataAccess.Models;

public partial class Tag
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Post> Posts { get; set; } = new List<Post>();
}
