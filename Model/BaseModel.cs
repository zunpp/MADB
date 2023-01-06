using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model
{
    public class BaseModel
    {
        [Range(0, int.MaxValue, ErrorMessage = "Page number should not be less than zero!")]
        public int pageNo { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Page size should not be less than zero!")]
        public int pageSize { get; set; }

        public string orderBy { get; set; }

        public string Email { get; set; }
    }
}
