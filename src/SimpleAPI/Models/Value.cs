using System;

namespace simpleAPI {
  public class Value {
    public int id  { get; set; }
    public string name  { get; set; }

    public Value(int id, string name) {
      this.id = id;
      this.name = name;
    }
  }
}