using System.ComponentModel.DataAnnotations;

namespace api.Dtos.Comment
{
    public class UpdateCommentRequestDto
    {
        [Required]
        [MinLength(5, ErrorMessage = "Title must be 5 Characters long")]
        [MaxLength(280, ErrorMessage = "Title can nt be longer than 280 characters")]
        public string Title { get; set; } = string.Empty;
        [Required]
        [MinLength(5, ErrorMessage = "Content must be 5 Characters long")]
        [MaxLength(280, ErrorMessage = "Content can nt be longer than 280 characters")]
        public string Content { get; set; } = string.Empty;
    }
}
