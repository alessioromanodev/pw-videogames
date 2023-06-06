﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pw_videogames.Models
{
    public class VideogameModel
    {
        [MaxLength(50)]
        public int Id {  get; set; }
        
        [MaxLength(400)]
        public string Name { get; set; }
        
        [MaxLength(500)]
        public string Description { get; set; }

        [Url]
        public string ImgUrl { get; set; }

        public float Price { get; set; }

        public VideogameModel() { }

        public VideogameModel(int id, string name, string description, string imgUrl, float price)
        {
            Id = id;
            Name = name;
            Description = description;
            ImgUrl = imgUrl;
            Price = price;
        }
    }
}
