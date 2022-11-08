using System;
using System.ComponentModel.DataAnnotations;

namespace Bercea_Anelise_Laborator2_MPA.Models.LibraryViewModels
{
    public class OrderGroup
    {
        [DataType(DataType.Date)]
        public DateTime? OrderDate { get; set; }
        public int BookCount { get; set; }

    }

}
