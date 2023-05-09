using Microsoft.EntityFrameworkCore;
using NorthwindAPI.Controller;
using NorthwindAPI.Data.Repositories;
using NorthwindAPI.Models;

namespace NorthwindAPI.Services
{
    public class NorthwindService<T> : INorthwindService<T> where T : class
    {

        private readonly ILogger _logger;
        private readonly INorthwindRepository<T> _repository;
        

        public NorthwindService(ILogger<INorthwindService<T>> logger, INorthwindRepository<T> repository)
        {
            _logger = logger;
            _repository = repository;
        }


        public async Task<bool> CreateAsync(T entity)
        {
            if (_repository is null)
            {
                return false;
            }
            _repository.Add(entity);

            await _repository.SaveAsync();
            return true;
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

       




public async Task<IEnumerable<T>?> GetAllAsync()

        {

            if (_repository.IsNull)

            {

                return null;

            }

            return await _repository.GetAllAsync();

        }




        public async Task<T?> GetAsync(int id)
        {
            if (_repository.IsNull)
            {
                return null;
            }

            var entity = await _repository.FindAsync(id);


            if (entity == null)
            {
                _logger.LogWarning($"{typeof(T).Name} with id: {id} was not found");
                return null;
            }

            _logger.LogInformation($"{typeof(T).Name} with id:{id} was found");

            return entity;
        }

        public async Task<bool> UpdateAsync(int id, T entity)
        {
            _repository.Update(entity);

            try
            {
                await _repository.SaveAsync();
            }

            catch (DbUpdateConcurrencyException)
            {
                /* Add entityExists???
                if(!await EntityExists(id))
                {
                    return false;
                }

                */
                

            }

        }
    }
}
