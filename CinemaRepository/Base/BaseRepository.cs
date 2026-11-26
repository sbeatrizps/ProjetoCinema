using CinemaDomain.Base;
using CinemaRepository.Context;
using Microsoft.EntityFrameworkCore;

namespace CinemaRepository.Base
{
    public class BaseRepository<TypeEntity> : IBaseRepository<TypeEntity> where TypeEntity : BaseEntity
    {
        protected readonly MyDBContext _myDBContext;

        public BaseRepository(MyDBContext myDBContext)
        {
            _myDBContext = myDBContext;
        }

        public void Create(TypeEntity entity)
        {
            _myDBContext.Add(entity);
            _myDBContext.SaveChanges();
        }

        public TypeEntity ReadById(int id)
        {
            // Filtra no banco (gera WHERE) em vez de carregar a tabela inteira em memoria.
            return _myDBContext.Set<TypeEntity>()
                .FirstOrDefault(entity => entity.Id == id)!;
        }

        public IList<TypeEntity> ReadAll()
        {
            return _myDBContext.Set<TypeEntity>().ToList();
        }

        public void Update(TypeEntity entity)
        {
            var localEntity = _myDBContext.Set<TypeEntity>()
                .Local
                .FirstOrDefault(existingEntity => existingEntity.Id == entity.Id);

            if (localEntity is not null)
            {
                _myDBContext.Entry(localEntity).CurrentValues.SetValues(entity);
                _myDBContext.Entry(localEntity).State = EntityState.Modified;
            }
            else
            {
                _myDBContext.Entry(entity).State = EntityState.Modified;
            }

            _myDBContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = _myDBContext.Set<TypeEntity>()
                .FirstOrDefault(e => e.Id == id);
            if (entity is null)
                throw new InvalidOperationException($"Registro {id} nao encontrado.");

            _myDBContext.Remove(entity);
            _myDBContext.SaveChanges();
        }
    }
}
