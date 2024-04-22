using IMTC.CodeTest.App.Request;
using IMTC.CodeTest.Application.Features.Bond;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace IMTC.CodeTest.App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BondsController : ControllerBase
    {
        protected IMediator _mediator;

        public BondsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetBondRequest bondRequest)
        {
            var serviceRequest = new GetBondQuery(bondRequest.BondName??"");
            var filteredBond = await _mediator.Send(serviceRequest);
            return Ok(filteredBond);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PostBondRequest postBondRequest)
        {
            var serviceRequest = new PostBondCalculationCommand(
                postBondRequest.Name, postBondRequest.FaceValue, 
                postBondRequest.CouponRate, postBondRequest.MaturityDate, 
                postBondRequest.CouponType, postBondRequest.BondType);
            
            var calculated = await _mediator.Send(serviceRequest);
            return Ok(calculated);
        }
    }
}
