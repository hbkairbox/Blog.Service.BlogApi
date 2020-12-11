﻿using MediatR;

namespace Blog.Service.BlogApi.Application.Features.Comments.Commands.DeleteComment
{
    public class DeleteCommentCommand : IRequest<bool>
    {
        public string Id { get; set; }
        public string PostId { get; set; }
    }
}
