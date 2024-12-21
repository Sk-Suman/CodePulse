using CodePulseProject.Model.Domain;

namespace CodePulseProject.Repository.Interface
{
    public interface ICategoryRepository
    {
        public Task<Category> Create(Category category);

        public Task<List<Category>> GetAll();

        public Task<Category> GetById(Guid Id);

        public Task<Category> Update(Guid Id, Category category);

        public Task<Category> Delete(Guid Id);
    }
}
