using System;
using System.Collections.Generic;
using System.Text;

namespace TodoApp.Authors
{
    public class GetAuthorListDto:PagedAndSortedResultRequestDto
    {
        public string  Filter { get; set; }
    }
}
