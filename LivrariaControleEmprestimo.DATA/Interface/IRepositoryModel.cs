﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LivrariaControleEmprestimo.DATA.Interface
{
    interface IRepositoryModel<T> where T : class
    {
        List<T> SelecionarTodos();
        T SelecionarPK(params object[] variavel);
        T Incluir(T objeto);
        T Alterar(T objeto);
        void Excluir(T objeto);
        void Excluir(params object[] variavel);
        void SaveChages();
    }
}
