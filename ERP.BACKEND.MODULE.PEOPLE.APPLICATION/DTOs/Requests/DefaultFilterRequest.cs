using ERP.BACKEND.MODULE.PERSON.COMMON.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.BACKEND.MODULE.PERSON.APPLICATION.DTOs.Requests
{
    public class DefaultFilterRequest
    {
        public string OrderBy { get; set; } = "";
        public OrderDirection OrderDirection { get; set; } = OrderDirection.ASC;
        public int MinIndex { get; set; } = 0;
        public int MaxIndex { get; set; } = 30;
        public bool Distinct { get; set; } = false;
    }
}
