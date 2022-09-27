using AutoMapper;
using TodoApp.Authors;
using TodoApp.Books;

namespace TodoApp
{
    public class BookStoreApplicationAutoMapperProfile:Profile
    {
        public BookStoreApplicationAutoMapperProfile()
        {
            CreateMap<Book, BookDto>();
            CreateMap<CreateUpdateBookDto, Book>();
            CreateMap<Author, AuthorDto>();
            CreateMap<Author, AuthorLookupDto>();
        }
    }
}
