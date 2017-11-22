using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Movie
    {

        public int ID { get; set; } //电影编号

        [Display(Name = "电影名称")]
        public string Title { get; set; } //电影名称

        [Display(Name = "上映时间")]
        public DateTime ReleaseDate { get; set; } //上映时间

        [Display(Name = "电影类型")]
        public string Genre { get; set; } //电影类型

        [Display(Name = "电影票价")]
        public decimal Price { get; set; } //电影票价

        [Display(Name = "电影分级")]
        public string Rating { get; set; } //电影分级
    }
}