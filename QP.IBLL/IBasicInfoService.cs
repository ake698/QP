using QP.Bussiness;
using QP.Entity;
using QP.Vo;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QP.IBLL
{
    public interface IBasicInfoService : IBaseService<VideoBasicInfo, BasicInfoDto>
    {
        //Task<BasicInfoDto> GetListOrderByLastModificationTime(int size);
        Task<PageResultDto<BasicInfoDto>> GetListPageAsync(int seriesId, VodQueryVo vo);
        Task<List<BasicInfoDto>> GetListTopsAsync(int id, int seriesId, int size = 10);
        Task<List<BasicInfoDto>> GetListRecommendsAsync(int id, string dierctor, string actor, string en, float rate, int size = 10);
    }
}
