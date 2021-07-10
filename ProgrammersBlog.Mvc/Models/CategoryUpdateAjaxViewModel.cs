using ProgrammersBlog.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgrammersBlog.Mvc.Models
{
    public class CategoryUpdateAjaxViewModel
    {
        public CategoryUpdateDto CategoryAddDto { get; set; }
        public string  CategotyUpdatePartial { get; set; }
        public CategoryDto CategoryDto { get; set; }
    }
}
