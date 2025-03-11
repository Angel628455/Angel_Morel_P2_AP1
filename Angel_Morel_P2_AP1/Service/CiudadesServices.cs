using Angel_Morel_P2_AP1.DAL;
using Angel_Morel_P2_AP1.Model;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Angel_Morel_P2_AP1.Service
{
    public class CiudadesServices
    {
        public object DbFactory { get; private set; }

        public async Task<List<Ciudades>> Listar(Expression<Func<Ciudades, bool>> criterio)
        {
            await using var contexto = await DbFactory.CreateDbContextAsync();
            return await contexto.Ciudades
                .Where(criterio)
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
