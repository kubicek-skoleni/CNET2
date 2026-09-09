using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace Corp.Model;

public class Person
{
    public int Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public int ChildrenCount { get; set; }

    public DateTime DateOfBirth { get; set; }

    public Address? Address { get; set; }

    public List<Contract> Contracts { get; set; }

    public override string ToString()
    {
        return $"{Id}, {FirstName} {LastName}, {Email}";
    }
}
