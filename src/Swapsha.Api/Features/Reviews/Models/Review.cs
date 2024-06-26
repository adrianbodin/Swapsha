﻿using System.ComponentModel.DataAnnotations;
using Swapsha.Api.Features.Users.Models;

namespace Swapsha.Api.Features.Reviews.Models;

public class Review
{
    [Key]
    public string ReviewId { get; set; }

    public byte Rating { get; set; }

    public string? Comment { get; set; }

    public DateTime DateCreated { get; set; } = DateTime.Now;

    public string UserId { get; set; }
    public CustomUser User { get; set; } = null!;

    public string PostedById { get; set; }
    public CustomUser PostedByUser { get; set; } = null!;
}