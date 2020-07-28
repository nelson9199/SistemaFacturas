﻿using Sistema.Datos.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Datos._UsuariosRepository
{
    public interface IUsuarioRepository<T> : IEstadoOnOfD
    {
        Task<List<object>> Listar();
        Task<string> Insertar(T objInsertar);
        Task<string> Actualizar(T objActualizar);
        Task<string> Eliminar(int id);
        Task<bool> ExisteNumDocumento(string numDocumento);
        Task<bool> ExisteEmail(string email);
        Task<bool> ValidarPassword(string username, string password);
    }
}
