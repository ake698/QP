using QP.Bussiness;
using QP.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QP.IBLL
{
    public interface IPlayInfoService : IBaseService<VideoPlayInfo, PlayInfoDto>
    {
        Task<List<PlayInfoWithResourceDto>> GetPlayInfos(int basicInfoId);
    }
}
