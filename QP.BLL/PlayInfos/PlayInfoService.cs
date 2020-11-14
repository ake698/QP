using AutoMapper;
using Microsoft.EntityFrameworkCore;
using QP.Bussiness;
using QP.Entity;
using QP.IBLL;
using QP.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QP.BLL
{
    public class PlayInfoService : BaseService<VideoPlayInfo, PlayInfoDto>, IPlayInfoService
    {
        private readonly IBaseRepository<VideoPlayInfo> _repository;
        private readonly IMapper _mapper;

        public PlayInfoService(IBaseRepository<VideoPlayInfo> repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<List<PlayInfoWithResourceDto>> GetPlayInfos(int basicInfoId)
        {
            var result = await _repository.GetAllAsync()
                .Where(x => x.BasicInfoId == basicInfoId)
                .Include(x => x.Resource).ToListAsync();
            return _mapper.Map<List<PlayInfoWithResourceDto>>(result);
        }
    }
}
