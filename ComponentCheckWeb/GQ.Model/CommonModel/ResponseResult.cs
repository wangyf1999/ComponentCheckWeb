using System;
using System.Collections.Generic;
using System.Text;

namespace GQ.Model.CommonModel
{
    //
    // 摘要:
    //     全局返回值对象
    //
    // 类型参数:
    //   T:
    public class ResponseResult<T>
    {
        public int Code { get; set; }
        public string Message { get; set; }

    }
}
