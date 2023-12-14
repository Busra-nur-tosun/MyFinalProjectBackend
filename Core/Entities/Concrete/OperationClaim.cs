namespace Core.Entities.Concrete
{/*OperationClaim sınıfı, bir kullanıcının sistemde sahip olabileceği yetkileri tanımlar. 
  * Genellikle bir kullanıcının bir rolü veya bir dizi yetkisi bu şekilde temsil edilir.*/
    public class OperationClaim:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
