﻿
using System.ComponentModel.DataAnnotations;

namespace BusinessObjects;

//MySql
public class Customer
{
    [Key]
    public int CustomerId { get; set; }
    public string? CustomerName { get; set; }
    public string? CustomerCountry { get; set; }
    public string? CustomerCity { get; set; }
    public string? CustomerZipCode { get; set; }
}
