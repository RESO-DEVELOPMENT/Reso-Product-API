using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pos_System.API.Constants;
using Pos_System.API.Enums;
using Pos_System.API.Payload.Response.Promotion;
using Pos_System.API.Services.Interfaces;
using Pos_System.API.Validators;


namespace Pos_System.API.Controllers
{
    public class PromotionController : BaseController<PromotionController>
    {
        private readonly IPromotionService _promotionService;
        public PromotionController(ILogger<PromotionController> logger, IPromotionService promotionService) : base(logger)
        {
            _promotionService = promotionService;
        }
        [CustomAuthorize(RoleEnum.BrandAdmin)]
        [HttpGet(ApiEndPointConstant.Promotion.PromotionEndpoint)]
        [ProducesResponseType(typeof(GetPromotionResponse), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetListPromotion([FromQuery] PromotionEnum? type, [FromQuery] int page, [FromQuery] int size)
        {
            var response = await _promotionService.GetListPromotion(type, page, size);
            return Ok(response);
        }
    }
}

        