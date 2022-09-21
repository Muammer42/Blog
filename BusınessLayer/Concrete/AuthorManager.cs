using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusınessLayer.Concrete
{
    public class AuthorManager
    {
        Repository<Author> repoauthor = new Repository<Author>();

        public List<Author>GetAll()
        {
            return repoauthor.List();
        }
        public int AddAuthorBl(Author p)
        {
            if (p.AuthorName=="" | p.AuthorTitle=="" )
            {
                return -1;
            }
            return repoauthor.Insert(p);
        }
        public Author FindAuthor(int id)
        {
            return repoauthor.Find(x=>x.AuthorID==id);
        }
        public int EditAuthor(Author p)
        {
            Author author = repoauthor.Find(x=>x.AuthorID==p.AuthorID);
            author.AboutShort = p.AuthorAbout;
            author.AuthorName = p.AuthorName;
            author.AuthorImage = p.AuthorImage;
            author.AuthorAbout = p.AuthorAbout;
            author.AuthorTitle = p.AuthorTitle;
            author.Mail = p.Mail;
            author.Password = p.Password;
            author.PhoneNumber = p.PhoneNumber;
            return repoauthor.Update(author);
        }

    }
}
