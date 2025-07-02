using Microsoft.AspNetCore.Mvc;
namespace StoreApi.Controller;

public class ProductController : StoreController
{
    [HttpGet("{id:int}")]
    public async Task<ActionResult<string>> Get(int id)
    { 
        return Ok(await Task.FromResult<string>($"Возвращение метода {id}!"));
    }
}