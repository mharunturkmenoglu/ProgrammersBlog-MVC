using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Mvc.Areas.Admin.Models;
using ProgrammersBlog.Services.Abstract;
using ProgrammersBlog.Shared.Utilities.Results.ComplexTypes;
using ProgrammersBlog.Shared.Utilities.Results.Concrete;

namespace ProgrammersBlog.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IArticleService _articleService;
        private readonly ICommentService _commentService;
        private readonly UserManager<User> _userManager;

        public HomeController(UserManager<User> userManager, ICommentService commentService, IArticleService articleService, ICategoryService categoryService)
        {
            _userManager = userManager;
            _commentService = commentService;
            _articleService = articleService;
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {
            var categoriesCountResult = await _categoryService.CountByNonDeletedAsync();
            var articlesCountResult = await _articleService.CountByNonDeletedAsync();
            var commentCountResult = await _commentService.CountByNonDeletedAsync();
            var userCount = await _userManager.Users.CountAsync();
            var articlesResult = await _articleService.GetAllAsync();
            if (categoriesCountResult.ResultStatus == ResultStatus.Success && articlesResult.ResultStatus == ResultStatus.Success &&
                commentCountResult.ResultStatus == ResultStatus.Success && userCount > -1 && articlesResult.ResultStatus == ResultStatus.Success)
            {
                return View(new DashboardViewModel
                {
                    CategoriesCount = categoriesCountResult.Data,
                    ArticlesCount = articlesCountResult.Data,
                    CommentsCount = commentCountResult.Data,
                    UsersCount = userCount,
                    Articles = articlesResult.Data
                });
            }
            return NotFound();
        }
    }
}
