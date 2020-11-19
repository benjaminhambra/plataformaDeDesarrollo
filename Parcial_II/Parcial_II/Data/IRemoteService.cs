using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial_II.Data
{
    interface IRemoteService
    {
        /* GET */
        [Get("/tarea")]
        Task<List<Tareas>> GetTareas();

        [Get("/usuario")]
        Task<List<Usuarios>> GetUsuarios();

        [Get("/recurso")]
        Task<List<Recursos>> GetRecursos();

        [Get("/detalle")]
        Task<List<Detalles>> GetDetalles();

        /* NEWS */

        [Get("/usuario/{id}")]
        Task<Usuarios> GetUsuariosById(int Id);

        /* POST */
        [Post("/tarea")]
        Task<List<Tareas>> CreateTareas();

        [Post("/usuario")]
        Task<Usuarios> CreateUsuarios();

        [Post("/recurso")]
        Task<List<Recursos>> CreateRecursos();

        [Post("/detalle")]
        Task<List<Detalles>> CreateDetalles();

    }
}
