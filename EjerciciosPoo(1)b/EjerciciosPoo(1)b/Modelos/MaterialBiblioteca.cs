using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPoo_1_b.Modelos
{
     public class MaterialBiblioteca
    {
        public int id;
        public String titulo;
        public String Autor;
        public int Anoplublicacion;
        public String Categoria;

        public MaterialBiblioteca(int id, String titilo, String Auntor,int Anoplublicacion,String Categoria) 
        {
            this.id = id;
            this.titulo = titilo;
            this.Autor = Auntor;
            this.Anoplublicacion = Anoplublicacion;
            this.Categoria= Categoria;
        }
    }
}
