using Microsoft.Extensions.DependencyInjection;
/*IoC klasörü, IoC prensiplerine uygun şekilde bağımlılık 
 * enjeksiyonunu yöneten sınıfları içerebilir. Bu sınıflar,
 * servis bağımlılıklarını tanımlar ve yönetir, genellikle
 * bir DI (Dependency Injection) konteyneri kullanılarak.
 * Bu klasör, uygulamanın servisleri arasında bağımlılıkları yönetmek için kullanılır*/

namespace Core.Utilities.IoC
{
    //Bu kod, Inversion of Control (IoC) prensiplerine uygun olarak servis bağımlılıklarını
    //yükleyen modül sınıfları için bir arayüz (ICoreModule) tanımlar. 
    public interface ICoreModule
    {
        //genel bağımlılıkları yükleyecek
        void Load(IServiceCollection serviceCollection);
    }
}