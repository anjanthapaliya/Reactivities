using Microsoft.AspNetCore.Mvc;
using Domain;
using Application.Activities;
using Microsoft.AspNetCore.Http.HttpResults;


namespace API.Controllers
{
    public class ActivitiesController : BaseApiController
    {
        // private readonly DataContext _context;
        // public ActivitiesController(DataContext context)
        // {
        //     _context = context;
        // }

        // [HttpGet]  //api/activities
        // public async Task<ActionResult<List<Activity>>> GetActivities()
        // {
        //     return await _context.Activities.ToListAsync();
        // }

        // [HttpGet("{id}")]  //api/activities/id
        // public async Task<ActionResult<Activity>> GetActivity(Guid id)
        // {
        //     return await _context.Activities.FindAsync(id);
        // }

        /*  
          private readonly IMediator _mediator;

          public ActivitiesController(IMediator mediator)
          {
              _mediator = mediator;
          }  

          [HttpGet]  //api/activities
          public async Task<ActionResult<List<Activity>>> GetActivities()
          {
              return await _mediator.Send(new List.Query());
          }

          [HttpGet("{id}")]  //api/activities/id
          public async Task<ActionResult<Activity>> GetActivity(Guid id)
          {
              //return await _mediator.Send(new Details.Query{Id = id});
              return Ok();
          }
          */

        [HttpGet]  //api/activities
        public async Task<ActionResult<List<Activity>>> GetActivities()
        {
            return await Mediator.Send(new List.Query());
        }

        [HttpGet("{id}")]  //api/activities/id
        public async Task<ActionResult<Activity>> GetActivity(Guid id)
        {
            return await Mediator.Send(new Details.Query { Id = id });

        }

        [HttpPost]
        public async Task<IActionResult> CreateActivity(Activity activity)
        {
            await Mediator.Send(new Create.Command { Activity = activity });
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditActivity(Guid id, Activity activity)
        {
            activity.Id = id;
            await Mediator.Send(new Edit.Command { Activity = activity });
            return Ok();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteActivity(Guid id)
        {
            await Mediator.Send(new Delete.Command { Id = id });
            return Ok();
        }
    }
}