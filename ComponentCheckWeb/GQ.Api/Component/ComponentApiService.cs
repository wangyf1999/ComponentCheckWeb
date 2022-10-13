using GQ.Model.CommonModel;
using GQ.Service.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace GQ.Api.Component
{
    public class ComponentApiService
    {
        private readonly ComponentService _logService;

        public ComponentApiService()
        {
            _logService = new ComponentService();
        }

        public string test(string teststr)
        {
            if (teststr == null)
                return "参数为空";
            if (_logService.test(teststr))
                return "成功";
            return "失败";
        }
    }
}
