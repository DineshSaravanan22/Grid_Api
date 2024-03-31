using Angular_Grid_Api_Task2022.Data;
using Angular_Grid_Api_Task2022.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Any;

namespace Angular_Grid_Api_Task2022.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class gridTask : ControllerBase
    {
        private readonly DataContext _context;
        public gridTask(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<AgGrid>>GetAllData()
        {
            var getData = await _context.AgGrids.ToListAsync();
            return Ok(getData);
        }

        [HttpGet("{id}")]
         public async Task<ActionResult<AgGrid>>singleGridVal(int Id)
         {
             var AgGridVal = await _context.AgGrids.FirstOrDefaultAsync(a => a.Id == Id);
             if (AgGridVal == null)
             {
                 return NotFound("page no found");
             }
             return Ok(await _context.AgGrids.ToListAsync());
         }
        [HttpPost]
        public async Task<ActionResult<List<AgGrid>>> AddGrid([FromBody] AgGrid agGrid)
        {
            _context.AgGrids.Add(agGrid);
            await _context.SaveChangesAsync();

            return Ok(await _context.AgGrids.ToListAsync());
        }
        [HttpDelete]
        public async Task<ActionResult> DeleteGrid( int Id)
        {
            var AgGridVal = await _context.AgGrids.FirstOrDefaultAsync(a => a.Id== Id);
            if (AgGridVal == null)
            {
                return NotFound("page no found");
            }
            _context.AgGrids.Remove(AgGridVal);
            await _context.SaveChangesAsync();

            return Ok(await _context.AgGrids.ToListAsync());
        }
        /*[HttpPut]
        public async Task<ActionResult> EditGrid(int Id, [FromBody] AgGrid agGrid)
        {
            var AgGridVal = await _context.AgGrids.FirstOrDefaultAsync(a => a.Id == Id);
            if (AgGridVal == null)
            {
                return NotFound("page no found");
            }
            AgGridVal.Yard = agGrid.Yard;
            AgGridVal.LinerName = agGrid.LinerName;
            AgGridVal.ReferenceNumber = agGrid.ReferenceNumber;
            AgGridVal.Type = agGrid.Type;
            AgGridVal.BookingDate = agGrid.BookingDate;
            AgGridVal.BookingValidity = agGrid.BookingValidity;
            AgGridVal.ReleaceTo = agGrid.ReleaceTo;
            AgGridVal.VesselCarrier = agGrid.VesselCarrier;
            AgGridVal.VesselName = agGrid.VesselName;
            AgGridVal.VoyageNumber = agGrid.VoyageNumber;
            AgGridVal.ArrivalDate = agGrid.ArrivalDate;
            AgGridVal.DepartureDate = agGrid.DepartureDate;
            AgGridVal.LoadingPort = agGrid.LoadingPort;
            AgGridVal.DischargePort = agGrid.DischargePort;
            AgGridVal.Distination = agGrid.Distination;
            AgGridVal.Status = agGrid.Status;
            AgGridVal.OutContract = agGrid.OutContract;
            AgGridVal.BLNumber = agGrid.BLNumber;
            AgGridVal.Remarks = agGrid.Remarks;
            await _context.SaveChangesAsync();

            return Ok(await _context.AgGrids.ToListAsync());
        }*/
    }
}
