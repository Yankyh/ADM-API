using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.BACKEND.MODULE.PEOPLE.APPLICATION.DTOs
{
    public class BaseDTO
    {
        [Required]
        public Guid Id { get; set; }
    }
}
