using System.ComponentModel.DataAnnotations;

namespace webboard.Models
{
    public class User
    {
        /// <summary>
        /// 사용자번호
        /// </summary>
        [Key]   // PK 설정
        public int UserNo { get; set; }

        /// <summary>
        /// 사용자이름
        /// </summary>
        [Required]  // NOT NULL 설정
        public string UserName { get; set; }
        /// <summary>
        /// 사용자 아이디
        /// </summary>
        [Required]  // NOT NULL 설정
        public string UserId { get; set; }
        /// <summary>
        /// 사용자 비밀번호
        /// </summary>
        [Required]  // NOT NULL 설정
        public string UserPassword { get; set; }
    }
}
