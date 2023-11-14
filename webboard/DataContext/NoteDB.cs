using System.Collections.Generic;
using webboard.Models;
using Microsoft.EntityFrameworkCore;
using webboard.Models;

namespace webboard.DataContext
{
    /// <summary>
    /// 상속 콜론 : 부모이름
    /// </summary>

    public class NoteDB : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Note> Notes { get; set; }

        /// <summary>
        /// DB 연결 Connectionstring 홈페이지 참조
        /// 마이그레이션 : CodeFirst : 코드먼저 작성후 마이그레이션하면 테이블이 생성됨
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        }
    }
}
