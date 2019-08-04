using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BLL
{
    public interface IRepository<T> where T : class
    {
        T Buscar(int id);
        bool Guardar(T entity);
        bool Modificar(T entity);
        bool Eliminar(int id);
        List<T> GetList(Expression<Func<T, bool>> expression);
    }
}
