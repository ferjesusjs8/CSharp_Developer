﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Model
{
    public class Curso
    {
        private IList<Aula> aulas;
        private string nomeCurso;
        private string instrutor;

        public IList<Aula> Aulas
        {
            get { return new ReadOnlyCollection<Aula>(aulas); }
        }

        internal void AdicionarAula(Aula aula)
        {
            this.aulas.Add(new Aula(aula.Nome, aula.Tempo));
        }

        public Curso(string nomeCurso, string instrutor)
        {
            this.nomeCurso = nomeCurso;
            this.instrutor = instrutor;
            this.aulas = new List<Aula>();
        }

        public string NomeCurso
        {
            get { return nomeCurso; }
            set { nomeCurso = value; }
        }


        public string Instrutor
        {
            get { return instrutor; }
            set { instrutor = value; }
        }
    }
}
