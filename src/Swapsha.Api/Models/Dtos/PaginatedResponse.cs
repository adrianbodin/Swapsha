﻿namespace Swapsha.Api.Models.Dtos;

public class PaginatedResponse<T>
{
    public int PageIndex { get; set; }
    public int PageSize { get; set; }
    public int TotalRecords { get; set; }
    public List<T> Data { get; set; }
}