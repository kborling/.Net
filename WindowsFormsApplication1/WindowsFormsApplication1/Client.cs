/*
 * Kevin Borling
 * CSCD 306 | .Met Programming
 * WinForm Dating Service Part 2
 * 07/22/2013
 * Client Class Contains the Explicit Value Constructor for each client in the database.
 * Also contains the Match Algorithm to find a clients potential matches based on age, interests, and favorite color.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class Client
    {
        public String Fname, Lname, Sex, Color, Hobby, Other, Photo;
        public int Age, ID;
        public Client(String fname, String lname, String sex, int age,  String color, String hobby, String other, String photo, int id)
        {
            Fname = fname;
            Lname = lname;
            Sex = sex;
            Color = color;
            Hobby = hobby;
            Other = other;
            Photo = photo;
            Age = age;
            ID = id;
        }// End Client EVC

        public int Match(Client c)
        {

            int total = 0;
            // Prevents Client from being null, Clients Matching with themselves, and only matching with opposite sex
            if (c == null || this.ID == c.ID || this.Sex == c.Sex)
                return 0;
            // Max Interest Points = 3
            if (this.Hobby == c.Hobby)
                total += 3;
            if (this.Other == c.Other)
                total += 2;
            if (this.Hobby == c.Other)
                total += 1;
            // Max Color Point = 1
            if (this.Color == c.Color)
                total += 1;
            // Max Age Points = 5
            if (this.Age / c.Age == 1)
                total += 5;
            if (this.Age - c.Age == 1 || c.Age - this.Age == 1)
                total += 4;
            if (this.Age - c.Age == 2 || c.Age - this.Age == 2)
                total += 3;
            if (this.Age - c.Age == 3 || c.Age - this.Age == 3)
                total += 2;
            if (this.Age - c.Age == 4 || c.Age - this.Age == 4)
                total += 1;

            return total;
        }// End Match Tool
    }
}
