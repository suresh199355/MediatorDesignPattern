using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryBooks.Application.Requests;

public class DeleteBookRequest : IRequest
{
    public int BookId { get; set; }
}

