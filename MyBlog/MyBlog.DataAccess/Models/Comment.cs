using System;
using System.Collections.Generic;

namespace MyBlog.DataAccess.Models;

public partial class Comment
{
    public long Id { get; set; }

    public long PostId { get; set; }

    public long? UserId { get; set; }

    public long? ParentId { get; set; }

    public string Content { get; set; } = null!;

    public sbyte Depth { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual ICollection<Comment> InverseParent { get; set; } = new List<Comment>();

    public virtual Comment? Parent { get; set; }

    public virtual Post Post { get; set; } = null!;

    public virtual User? User { get; set; }
}
