using System;

namespace cSharpAdvancedConsole._04._24
{
  public class FehlerError : ApplicationException
  {
    public FehlerError() : base()
    {
    }

    public FehlerError(string message) : base(message)
    {
    }
  }
}