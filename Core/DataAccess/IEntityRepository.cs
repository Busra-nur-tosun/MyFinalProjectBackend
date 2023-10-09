using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.DataAccess

    //GENERİC CONSTRAİNT 
    //CLASS  REFERANS TİP
    //IENTİTY:ı entitiy olabilr veye ıentity implemenete eden bir nesene olabilir
{   //
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        //filtre vermemizi sağlayan yapının adı expressiondur
        //bu expressionun yazım eşwkline deleege denir
        List<T> GetAll(Expression<Func<T,bool>>filter=null);//filtre vermeueyedibilirisn
        T Get(Expression<Func<T, bool>> filter );//get de sadece bir tane getiri ve filtre zorunnludur
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

       //expression yazdığında bu koda gerek yok çünkü bunun giibi filrre yapmanı sağlıuor List<T> GetAllByCategory(int categoryId);
    }
}
