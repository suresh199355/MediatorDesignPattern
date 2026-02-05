using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryBooks.Application.Requests
{
    public class CreateBookRequest : IRequest
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
    }
}
