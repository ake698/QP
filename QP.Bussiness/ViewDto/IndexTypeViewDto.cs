using System;
using System.Collections.Generic;
using System.Text;

namespace QP.Bussiness.ViewDto
{
    public class IndexTypeViewDto
    {
        List<BasicInfoDto> MainInfo { get; set; }
        List<BasicInfoDto> TopInfo { get; set; }

        List<CategoryTypeDto> CategoryTypes { get; set; }
    }
}
