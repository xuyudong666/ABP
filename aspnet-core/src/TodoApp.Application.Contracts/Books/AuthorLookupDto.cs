using System;
using System.Collections.Generic;
using System.Text;

namespace TodoApp.Books
{
    public class AuthorLookupDto:EntityDto<Guid>
    {
        public string Name { get; set; }
    }
}
