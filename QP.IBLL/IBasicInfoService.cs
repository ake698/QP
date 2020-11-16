using QP.Bussiness;
using QP.Entity;
using QP.VO;
using System.Threading.Tasks;

namespace QP.IBLL
{
    public interface IBasicInfoService : IBaseService<VideoBasicInfo, BasicInfoDto>
    {
        //Task<BasicInfoDto> GetListOrderByLastModificationTime(int size);
        Task<PageResultDto<BasicInfoDto>> GetListPageAsync(VodQueryVo vo);
    }
}
