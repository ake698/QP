using QP.Bussiness;
using QP.Entity;
using System.Threading.Tasks;

namespace QP.IBLL
{
    public interface IBasicInfoService : IBaseService<VideoBasicInfo, BasicInfoDto>
    {
        //Task<BasicInfoDto> GetListOrderByLastModificationTime(int size);
    }
}
