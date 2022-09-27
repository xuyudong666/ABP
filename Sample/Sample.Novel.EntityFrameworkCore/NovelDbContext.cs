using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Sample.Novel.EntityFrameworkCore
{
    [ConnectionStringName("Novel")]
    public class NovelDbContext:AbpDbContext<NovelDbContext>
    {

    }
}