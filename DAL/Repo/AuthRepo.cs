using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repo
{
    public class AuthRepo : IRepository<Token, string>, IAuth<Token>
    {
        private readonly AIUB_ForumEntities _db;
        public AuthRepo(AIUB_ForumEntities db)
        {
            this._db = db;
        }
        public bool Add(Token obj)
        {
            _db.Tokens.Add(obj);
            return _db.SaveChanges() != 0;
        }

        public Token Authenticate(string email, string password)
        {
            var data = _db.Users.FirstOrDefault(x => x.Email.Equals(email) && x.Password.Equals(password));
            if (data == null)
            {
                return null;
            }

            var g = Guid.NewGuid();
            var t = g.ToString();
            var token = new Token
            {
                Tkey = t,
                CreationDate = DateTime.Now,
                UserId = data.UserId,
                ExpireDate = null
            };
            return this.Add(token) ? token : null;
        }

        public bool Delete(string token)
        {
            _db.Tokens.Remove(_db.Tokens.FirstOrDefault(e => e.Tkey.Equals(token)) ?? throw new InvalidOperationException());
            return _db.SaveChanges() != 0;
        }

        public bool Edit(Token e)
        {
            var token = _db.Tokens.FirstOrDefault(en => en.Tkey.Equals(e.Tkey));
            _db.Entry(token).CurrentValues.SetValues(e);
            return _db.SaveChanges() != 0;
        }

        public Token Get(string id)
        {
            return _db.Tokens.FirstOrDefault(x => x.Tkey.Equals(id));
        }

        public List<Token> Get()
        {
            return _db.Tokens.ToList();
        }
    }
}