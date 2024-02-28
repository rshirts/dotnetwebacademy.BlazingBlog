using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazingBlog.Domain.Articles;
using Microsoft.EntityFrameworkCore;

namespace BlazingBlog.Infrastructure.Repositories {
    internal class ArticleRepository : IArticleRepository {

        private readonly ApplicationDbContext _context;

        public ArticleRepository(ApplicationDbContext context) {
            _context = context;
        }

        public async Task<List<Article>> GetAllArticlesAsync() {
            return await _context.Articles.ToListAsync();
        }
    }
}
