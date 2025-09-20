using System;
using System.Collections.Generic;

namespace DtabaseFirst.Models;

public partial class User
{
    public Guid Id { get; set; }

    public string UsersName { get; set; } = null!;

    public string UsersLastname { get; set; } = null!;

    public string UsersLogin { get; set; } = null!;

    public string UsersPassword { get; set; } = null!;

    public string? UsersEmail { get; set; }
}
