using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Caching
{
    // Bu arayüz, çeşitli uygulama katmanları arasında geçici verilerin önbelleğe alınması ve yönetilmesi için kullanılır.
    // Genellikle, özellikle veritabanı erişimine olan sıkışmış durumları azaltmak ve uygulamanın performansını artırmak amacıyla kullanılır.

    public interface ICacheManager
    {
        T Get<T>(string key);
        object Get(string key);

        void Add(string key, object value, int duration);
        bool IsAdd(string key);
        void Remove(string key);

        void RemoveByPattern(string pattern);
    }
}
