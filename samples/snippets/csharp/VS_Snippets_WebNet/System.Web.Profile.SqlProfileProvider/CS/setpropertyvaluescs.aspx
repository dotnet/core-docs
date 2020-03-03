<%@ Page Language="C#" %>
<%@ Import Namespace="System.Web.Profile" %>
<%@ Import Namespace="System.Configuration" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
    "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head>
<title>Profile Sample: Properties and Values</title>
</head>
<body>
<h3>Properties and Values</h3>

<%
//<Snippet2>
  SqlProfileProvider p = 
    (SqlProfileProvider)Profile.Providers["SqlProvider"];

  SettingsPropertyValueCollection pvalues = 
    p.GetPropertyValues(Profile.Context, ProfileBase.Properties);

  pvalues["ZipCode"].PropertyValue = "98052";
  pvalues["CityAndState"].PropertyValue = "Redmond, WA";

  p.SetPropertyValues(Profile.Context, pvalues);
//</Snippet2>
%>

</body>
</html>