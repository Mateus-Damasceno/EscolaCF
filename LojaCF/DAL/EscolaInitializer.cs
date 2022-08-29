using LojaCF.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaCF.DAL
{
    internal class EscolaInitializer : DropCreateDatabaseIfModelChanges<EscolaContext>
    {

        protected override void Seed(EscolaContext context)
        {
            var Alunos = new List<Aluno>
            {
                new Aluno { Nome = "carlos", Sobrenome = "alcatraz", DataMatricula = DateTime.Parse("2022-09-01") },
                new Aluno { Nome = "Jose", Sobrenome = "formiga", DataMatricula = DateTime.Parse("2022-09-02") },

            };
            Alunos.ForEach(s => context.Alunos.Add(s));
            context.SaveChanges();

            var cursos = new List<Curso>
            {
                new Curso {CursoID=1050,Titulo="quimica",Creditos=3},
                new Curso {CursoID=1051, Titulo="economia", Creditos=4},
            };
            cursos.ForEach(s => context.Cursos.Add(s));
            context.SaveChanges();

            var matriculas = new List<Matricula>
            {
                new Matricula {AlunoID=1,CursoID=1050,Nota=Nota.A},
                  new Matricula {AlunoID=2,CursoID=1051,Nota=Nota.C},
            };
            cursos.ForEach(s => context.Cursos.Add(s));
            context.SaveChanges();


        }
    }
}
