﻿using Sistema.Entidades;
using Sistema.Negocio.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Negocio._UsuarioLogic
{
    public interface IUsuarioAccessRepo<T> : IEstadoOnOfN
    {
        Task<List<T>> Listar();
        Task<string> Insertar(T objInsertar);
        Task<string> Actualizar(T objActualizar, string numDocuAnt, string emailAnt);
        Task<string> Eliminar(int id);
        Task<(T, string)> Login(string username, string password);
    }
}
