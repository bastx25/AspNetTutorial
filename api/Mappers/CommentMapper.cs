using api.Dtos.Comment;
using api.Models;

namespace api.Mappers
{
    public static class CommentMapper
    {

        public static CommentDto ToCommentDto(this Comment commentModel)
        {
            return new CommentDto
            {
                Id = commentModel.Id,
                Content = commentModel.Content,
                CreatedOn = commentModel.CreatedOn,
                StockId = commentModel.StockId,
                Title = commentModel.Title,
            };
        }

        public static Comment ToCommentFromCreate(this CreateCommentDto createCommentDto, int stockId)
        {
            return new Comment
            {
                Content = createCommentDto.Content,
                StockId = stockId,
                Title = createCommentDto.Title,
            };
        }

        //public static Comment ToCommentFromUpdate(this UpdateCommentRequestDto createCommentDto)
        //{
        //    return new Comment
        //    {
        //        Content = createCommentDto.Content,
        //        Title = createCommentDto.Title,
        //    };
        //}


    }
}
