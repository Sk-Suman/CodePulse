using CodePulseProject.Data;
using CodePulseProject.Model.Domain;
using CodePulseProject.Model.DTO;
using CodePulseProject.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodePulseProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private ICategoryRepository categoryrepo;

        public CategoriesController(ICategoryRepository categoryrepo)

        {
            this.categoryrepo = categoryrepo;
        }

        [HttpPost]

        public async Task<IActionResult> CreateCategories(CreateCategoriesRequestDto requestDto)
        {
            // DTO to Domain
            var request = new Category()
            {
                Name = requestDto.Name,
                UrlHandel = requestDto.UrlHandel,
            };

            //  await dbContext.Categories.AddAsync(request);
            //  await dbContext.SaveChangesAsync();

            await categoryrepo.Create(request);

            // Domain to DTO

            var reuest1 = new CategoriesRequest()
            {
                Id = request.Id,
                Name = request.Name,
                UrlHandel = request.UrlHandel
            };


            return Ok(reuest1);
        }

        [HttpGet]

        public async Task<IActionResult> GetAllCategories()
        {
            var result = await categoryrepo.GetAll();
            if (result == null)
            {
                return NotFound();
            }
            // domain to DTO

            List<CategoriesRequest> cr = new List<CategoriesRequest>();
            foreach (var category in result)
            {
                cr.Add(new CategoriesRequest()
                {
                    Id = category.Id,
                    Name = category.Name,
                    UrlHandel = category.UrlHandel
                });
            }
            return Ok(cr);
        }

        [HttpGet]
        [Route("{Id:guid}")]


        public async Task<IActionResult> GetCategoryById(Guid Id)
        {
            var category = await categoryrepo.GetById(Id);

            if (category == null)
            {
                return NotFound();
            }
            // convert to DTO

            var catDto = new CategoriesRequest()
            {
                Id = category.Id,
                Name = category.Name,
                UrlHandel = category.UrlHandel
            };
            return Ok(category);
        }


        [HttpPut]
       
        [Route("Update/{Id:guid}")]

        public async Task<IActionResult> UpdateCategory([FromRoute] Guid Id, [FromBody] CreateCategoriesRequestDto createCategoriesRequestDto)

        {
          

            var category = new Category
            {
                Name = createCategoriesRequestDto.Name,
                UrlHandel = createCategoriesRequestDto.UrlHandel
            };

           var r= await categoryrepo.Update(Id, category);

            if(r == null)
            {
                return NotFound();

            }
            // cobvert domain to dto

            var c = new CategoriesRequest()
            {
                Id = r.Id,
                Name = r.Name,
                UrlHandel = r.UrlHandel
            };
            return Ok(c);
        }

        [HttpDelete]
        
        [Route("Delete/{Id:guid}")]

        public async Task<IActionResult> DeteleCategory([FromRoute] Guid Id)
        {
            var res=await categoryrepo.Delete(Id);
            if(res == null)
            {
                return NotFound();

            }
            // convert to DTO
            var diff = new CategoriesRequest
            {
                Id = res.Id,
                Name = res.Name,
                UrlHandel = res.UrlHandel
            };


            return Ok(diff);
        }


    }
}
