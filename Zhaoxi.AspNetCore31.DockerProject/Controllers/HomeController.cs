using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Zhaoxi.AspNetCore31.DockerProject.Models;

namespace Zhaoxi.AspNetCore31.DockerProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _IConfiguration;
        private IDistributedCache _iDistributedCache;
        public HomeController(ILogger<HomeController> logger, IConfiguration configuration, IDistributedCache distributedCache)
        {
            _logger = logger;
            this._IConfiguration = configuration;
            this._iDistributedCache = distributedCache;
        }

        public IActionResult Index()
        {
            this._logger.LogWarning($"This is {this._IConfiguration["CustomMessage"]}");

            return View();
        }
        public IActionResult IndexRedis()
        {
            this._logger.LogWarning($"This is {this._IConfiguration["CustomMessage"]}");

            #region 解决缓存在不同实例共享问题
            {
                string keyDistributedCache = $"HomeController-Info-DistributedCache";
                string time = this._iDistributedCache.GetString(keyDistributedCache);
                if (!string.IsNullOrWhiteSpace(time))
                {

                }
                else
                {
                    time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss fff");
                    this._iDistributedCache.SetString(keyDistributedCache, time, new DistributedCacheEntryOptions()
                    {
                        AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(120)
                    });
                }
                base.ViewBag.DistributedCacheNow = time;
            }
            //Redis数据结构可不止这一个
            #endregion

            base.ViewBag.Now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss fff");
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
