using System;
using System.Collections.Generic;
using System.Text;

namespace TodoApp.Authors
{
    public class AuthorDto:EntityDto<Guid>
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string ShortBio { get; set; }
    }
}
