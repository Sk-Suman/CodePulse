using CodePulseProject.Data;
using CodePulseProject.Model.Domain;
using CodePulseProject.Model.DTO;
using CodePulseProject.Repository.Interface;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.EntityFrameworkCore;

namespace CodePulseProject.Repository.Implementation
{
    public class CategoryRepository : ICategoryRepository
    {
        private ApplicationDbContext dbContext;

        public CategoryRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Category> Create(Category category)
        {

            await dbContext.Categories.AddAsync(category);
            await dbContext.SaveChangesAsync();
            return category;
        }

        public async Task<Category> Delete(Guid Id)
        {
            var res = await dbContext.Categories.FindAsync(Id);
           
            if(res == null)
            {
                return null;
            }


             dbContext.Categories.Remove(res);
            await dbContext.SaveChangesAsync();

            return res;
            
        }

        public async Task<List<Category>> GetAll()
        {
            var res = await dbContext.Categories.ToListAsync();
            return res;
        }

    

      

        async Task<Category> ICategoryRepository.GetById(Guid Id)
        {
            var item = await dbContext.Categories.FindAsync(Id);
            if(item ==null)
            {
                return null;
            }
            return item;
        }

     

        async Task<Category> ICategoryRepository.Update(Guid Id, Category category)
        {
            var res = await dbContext.Categories.FindAsync(Id);
            if(res == null) 
            {
                return null;
            }
            res.Name=category.Name;
            res.UrlHandel=category.UrlHandel;

            await dbContext.SaveChangesAsync();
            return res;
            
        }
    }
}
