using System;
namespace Logic {
  [Serializable]
  public class SoloHayDoceMeses:Exception {

    public SoloHayDoceMeses() { }

    public SoloHayDoceMeses(string message):base(message){}

    public SoloHayDoceMeses(string message, Exception inner): base(message, inner) { }
  }
}
