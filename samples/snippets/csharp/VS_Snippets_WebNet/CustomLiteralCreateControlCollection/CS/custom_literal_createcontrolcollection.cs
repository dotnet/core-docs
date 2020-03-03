﻿// <Snippet2>
using System.Web;
using System.Security.Permissions;

namespace Samples.AspNet.CS.Controls
{
  [AspNetHostingPermission(SecurityAction.Demand, Level=AspNetHostingPermissionLevel.Minimal)]
  public sealed class CustomLiteralCreateControlCollection : System.Web.UI.LiteralControl
  {
    protected override System.Web.UI.ControlCollection CreateControlCollection()
    {
      // Return a new EmptyControlCollection
      return new System.Web.UI.EmptyControlCollection(this);
    }
  }
}
// </Snippet2>
