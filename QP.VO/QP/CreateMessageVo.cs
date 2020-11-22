using System.ComponentModel.DataAnnotations;

namespace QP.Vo
{
    public class CreateMessageVo
    {
        [Required]
        public string Content { get; set; }
        [Required]
        public string VerifyCode { get; set; }
    }
}
