using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyBooks.Models
{
    public class BooksModel
    {
        [Key]
        public int bookId { get; set; }

        [Column(TypeName = "nvarchar(30)")]
        [DisplayName("Назва книги")]
        [Required(ErrorMessage = "Це поле не може бути пустим")]
        public string nameBook { get; set; }

        [Column(TypeName = "nvarchar(30)")]
        [DisplayName("Жанр")]
        [Required(ErrorMessage = "Це поле не може бути пустим")]
        public string genreBook { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [DisplayName("Автор книги")]
        [Required(ErrorMessage = "Це поле не може бути пустим")]
        public string authorBook { get; set; }

        [DisplayName("Сторінки")]
        [Required(ErrorMessage = "Це поле не може бути пустим")]
        public int pagesBook { get; set; }
        [DisplayName("Дата")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }
    }
}
