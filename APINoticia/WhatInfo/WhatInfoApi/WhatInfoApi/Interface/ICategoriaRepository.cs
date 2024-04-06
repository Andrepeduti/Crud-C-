using WhatInfoApi.models;

namespace WhatInfoApi.Interface
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> GetCategorias();
        Categoria GetId (int id);
        Categoria Create (Categoria categoria);
        Categoria Update (Categoria categoria);
        Categoria Delete (int id);
    }
}
