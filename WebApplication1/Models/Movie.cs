using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [Display(Name = "电影名称")]
        [Required(ErrorMessage = "必填")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "必须是[3,60]个字符")]
        public string Title { get; set; }

        [Display(Name = "上映日期")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "电影类型")]
        [Required]
        public string Genre { get; set; }

        [Display(Name = "电影票价")]
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Display(Name = "电影分级")]
        [StringLength(5)]
        [Required]
        public string Rating { get; set; }
    }
}