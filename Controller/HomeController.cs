using Microsoft.AspNetCore.Mvc;
[Route("[Action]")]
[ApiController]
public class HomeController : Controller
{
    private readonly Context dbContext;
    public HomeController(Context context)
    {
        dbContext = context;
    }

    [HttpPost]
    public IActionResult AddSlider(MaddSlider mslider)
    {
        var Slider = new Slider();
        Slider.nameslider = mslider.nameslider;
        Slider.active = mslider.active;

        dbContext.slider_tbl.Add(Slider);
        dbContext.SaveChanges();

        return Ok("ثبت با موفقیت انجام شد");
    }
    [HttpGet]

    public List<Slider> Getsliders()
    {
        var Slider = dbContext.slider_tbl.ToList();
        return Slider;

    }
    [HttpDelete]

    public IActionResult Delslider(int Id)
    {
        var Slider = dbContext.slider_tbl.Find(Id);
        dbContext.slider_tbl.Remove(Slider);
        dbContext.SaveChanges();
        return Ok("با موفقیت پاک گردید");
    }
    [HttpPut]
    public IActionResult Upslider(Updateslider updateslider)
    {
      var Slider=dbContext.slider_tbl.Find(updateslider.Id);
      Slider.nameslider=updateslider.nameslider;
      Slider.active=updateslider.active;

      dbContext.slider_tbl.Update(Slider);
      dbContext.SaveChanges();
        return Ok("با موفقثیت آپدیت شد");
    }
}