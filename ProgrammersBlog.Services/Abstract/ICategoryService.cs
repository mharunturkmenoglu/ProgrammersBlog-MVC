using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Entities.Dtos;
using ProgrammersBlog.Shared.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Services.Abstract
{
    public interface ICategoryService
    {
        Task<IDataResult<CategoryDto>> GetAsync(int categoryId);
        /// <summary>
        /// returns CategoryUpdateDto representation of Category by given ID parameter.
        /// </summary>
        /// <param name="categoryId">Id value is greater than zero</param>
        /// <returns>The Task that represent the asynchronous operation, returns DataResult</returns>
        Task<IDataResult<CategoryUpdateDto>> GetCategoryUpdateDtoAsync(int categoryId);
        Task<IDataResult<CategoryListDto>> GetAllAsync();
        Task<IDataResult<CategoryListDto>> GetAllByNonDeletedAsync();
        Task<IDataResult<CategoryListDto>> GetAllByNonDeletedAndActiveAsync();
        /// <summary>
        /// Adds a new Category by given categoryAddDto and createdByName parameters.
        /// </summary>
        /// <param name="categoryAddDto">{categoryAddDto} category information for adding operation</param>
        /// <param name="createdByName">{string} username</param>
        /// <returns>The Task that represent the asynchronous operation, returns DataResult</returns>
        Task<IDataResult<CategoryDto>> AddAsync(CategoryAddDto categoryAddDto, string createdByName);
        Task<IDataResult<CategoryDto>> UpdateAsync(CategoryUpdateDto categoryUpdateDto, string modifiedByName);
        Task<IDataResult<CategoryDto>> DeleteAsync(int categoryId, string modifiedByName);
        Task<IResult> HardDeleteAsync(int categoryId);
        Task<IDataResult<int>> CountAsync();
        Task<IDataResult<int>> CountByNonDeletedAsync();
    }
}
