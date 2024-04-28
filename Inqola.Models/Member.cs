﻿namespace Inqola.Models;

public class Member
{
    public int ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Gender { get; set; }
    public DateTime JoinDate { get; set; }
    public int BranchID { get; set; }
    public int RoleID { get; set; }
}
