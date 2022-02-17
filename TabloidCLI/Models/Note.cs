﻿using System;

namespace TabloidCLI.Models
{
    public class Note
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string Content { get; set; }
        public Post Post { get; set; }

        public override string ToString()
        {
            return $"{Title} [{CreateDateTime}]: {Content}";
        }
    }
}