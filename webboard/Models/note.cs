using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webboard.Models
{
    public class note
    {
        /// <summary>
        /// 게시물 번호
        /// </summary>
        [Key]   // PK  
        public int NoteNo { get; set; }
        /// <summary>
        /// 게시물 제목
        /// </summary>
        [Required]
        public int NoteTitle { get; set; }
        /// <summary>
        /// 게시물 내용
        /// </summary>
        [Required]
        public int NoteContents { get; set; }
        /// <summary>
        /// 작성자 번호
        /// </summary>
        [Required]
        public int UserNo { get; set; }

        /// <summary>
        /// 외래키, 유저 테이블의 넘버로 이름 찾기
        /// 다른테이블의 데이터 갖고올때는 virtual 붙여주기
        /// </summary>
        [ForeignKey("UserNo")]
        public virtual User User { get; set; }
    }
}
