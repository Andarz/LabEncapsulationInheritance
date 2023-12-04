using System;

namespace PersonInfo;

public class Person
{
    private string _firstName;
    private string _lastName;
    private int _age;

    private const int NAME_MIN_LENGTH = 3;

    public Person(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    public string FirstName
    {
        get { return _firstName; }
        private set
        {
            if (value.Length < NAME_MIN_LENGTH)
            {
                throw new ArgumentException($"First name cannot contain fewer than {NAME_MIN_LENGTH} symbols!");
            }
            _firstName = value;
        }
    }

    public string LastName
    {
        get { return _lastName; }
        private set
        {
            if (value.Length < NAME_MIN_LENGTH)
            {
                throw new ArgumentException($"Last name cannot contain fewer than {NAME_MIN_LENGTH} symbols!");
            }
            _lastName = value;
        }
    }

    public int Age
    {
        get { return _age; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Age cannot be zero or a negative integer!");
            }
            _age = value;
        }
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName} is {Age} years old.";
    }
}
