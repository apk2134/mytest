using BookEntity;
using BookRentRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRentBL
{
    public class Manager
    {
        public void Createitems(Author author,Book book,Category cateory)
        {
            using (var repository = new CommonRepository<Book>())
            {
                repository.Create(book);
            }
            using (var repository = new CommonRepository<Author>())
            {
                repository.Create(author);
            }
            using (var repository = new CommonRepository<Category>())
            {
                repository.Create(cateory);
            }

        }
    }
}
