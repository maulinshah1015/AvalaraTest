﻿using System.Collections.Generic;

namespace AvalaraTest.Model
{
    public class HorizontalSlide : Slide
    {
        public Photo Photo { get; }

        public HorizontalSlide(Photo photo)
        {
            Photo = photo;
        }

        public override string ToString()
        {
            return Photo.ToString();
        }

        public override IEnumerable<Tag> Tags => Photo.Tags;
    }
}