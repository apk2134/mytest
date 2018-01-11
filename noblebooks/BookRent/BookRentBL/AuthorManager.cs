using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookEntity;
using BookRentRepository;

namespace BookRentBL
{
   public class AuthorManager
    {

        public void CreateAuthor(Author author) {
            using (var repository = new CommonRepository<Author>())
            {
                repository.Create(author);
            }
        }
    }
}
