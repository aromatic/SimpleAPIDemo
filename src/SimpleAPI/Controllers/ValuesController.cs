using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace simpleAPI.Controllers {
  [ApiController]
  [Route("api/[controller]")]
  public class ValuesController : ControllerBase {
      private readonly ILogger<ValuesController> _logger;

      public static Value[] values = new Value[3] {
          new Value(1, "Test"), // error here and other lines
          new Value(2, "altro test"),
          new Value(3, "ultimo"),
      };
      public ValuesController(ILogger<ValuesController> logger) {
            _logger = logger;
      }
      public ValuesController() {}

      [HttpGet]
      public Value[] Get() {
        return values;
      }

      [HttpGet("{id}")]
      public Object Get(int id) {
        Value found = null;
        int i = 0;
        while (found == null && i<values.Length) {
          if (values[i].id == id)
            found = values[i];
          i++;
        }
        if (found == null)
          return "Item non trovato";
        return found;
      }
  }
}