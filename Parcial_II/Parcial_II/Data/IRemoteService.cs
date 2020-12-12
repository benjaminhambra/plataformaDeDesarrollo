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

        /* GET by ID */

        [Get("/usuario/{id}")]
        Task<Usuarios> GetUsuariosById(int Id);

        [Get("/recurso/{id}")]
        Task<Recursos> GetRecursosById(int id);

        [Get("/tarea/{id}")]
        Task<Tareas> GetTareasById(int Id);

        [Get("/detalle/{id}")]
        Task<Detalles> GetDetallesById(int Id);

        /* POST */

        [Post("/usuario")]
        Task<Usuarios> CreateUsuarios(Usuarios usuario);

        [Post("/tarea")]
        Task<Tareas> CreateTarea(Tareas tarea);

        [Post("/recurso")]
        Task<Recursos> CreateRecurso(Recursos recurso);

        [Post("/detalle")]
        Task<Detalles> CreateDetalle(Detalles detalle);

        /* DELETE */

        [Delete("/usuario/{id}")]
        Task<Usuarios> DeleteUsuario(int id);

        [Delete("/tarea/{id}")]
        Task<Tareas> DeleteTarea(int id);

        [Delete("/recurso/{id}")]
        Task<Recursos> DeleteRecurso(int id);

        [Delete("/detalle/{id}")]
        Task<Detalles> DeleteDetalle(int id);
    }
}
