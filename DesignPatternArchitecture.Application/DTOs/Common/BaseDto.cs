using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternArchitecture.Application.DTOs.Common
{
    public class BaseDto
    {
        [Key]
        public int Id { get; set; }
    }
}
