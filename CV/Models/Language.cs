using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CV.Models
{
    public class Language
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public Level Level { get; set; }

        
    }

    public sealed class Level
    {
        public string Name { get; }

        public static readonly Level MOTHERTONGUE = new Level("Mother Tongue");
        public static readonly Level A1 = new Level("A1");
        public static readonly Level A2 = new Level("A2");
        public static readonly Level B1 = new Level("B1");
        public static readonly Level B2 = new Level("B2");
        public static readonly Level C1 = new Level("C1");
        public static readonly Level C2 = new Level("C2");


        public Level(string name)
        {
            this.Name = name;
        }
    }
}