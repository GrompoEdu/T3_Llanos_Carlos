using System.ComponentModel.DataAnnotations;

namespace T3_Llanos_Carlos.Models
{
    public class Libro
    {
        [Key]
        public int Id { get; set; }
        //Titulo
        [Required(ErrorMessage = "El titulo es obligatorio")]
        public string Titulo { get; set; }
        //Autor
        [Required(ErrorMessage = "El autor es obligatorio")]
        public string Autor { get; set; }
        //Tema 
        [Required(ErrorMessage = "El tema es obligatorio")]
        public string Tema { get; set; }
        //Editorial
        [Required(ErrorMessage = "La editorial es obligatoria")]
        public string Editorial { get; set; }
        //AnioPublicacion
        [Required(ErrorMessage = "El año de publicacion es obligatorio")]
        [Range(1900, 3000, ErrorMessage = "El año de publicacion debe estar entre 1900 y 3000")]
        public int AnioPublicacion { get; set; }
        //Paginas 
        [Required(ErrorMessage = "Las paginas son obligatorias")]
        [Range(10, 1000, ErrorMessage = "Las paginas deben estar entre 10 y 1000")]
        public int Paginas { get; set; }
        //Categoria
        [Required(ErrorMessage = "La categoria es obligatoria")]
        public string Categoria { get; set; }
        //Material
        [Required(ErrorMessage = "El material es obligatorio")]
        public string Material { get; set; }
        //Copias
        [Required(ErrorMessage = "Las copias son obligatorias")]
        [Range(1, 20, ErrorMessage = "Las copias deben estar entre 1 y 20")]
        public int Copias { get; set; }
        //*****************************************************************
    }
}
